using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Biblio.Data;
using Biblio.Data.UnitOfWork;
using Biblio.Business.Mapper;
using Biblio.Business.Service.Helpers;
using Biblio.Data.Repository;

namespace Biblio.Business.Service
{
    public class DocumentServices
    {
        private UnitOfWork _unitOfWork;

        private Repository<Document> _repositoryDocument;
        private Repository<Tesis> _repositoryTesis;
        private Repository<Libro> _repositoryLibro;
        private Repository<Articulo> _repositoryArticulo;
        private Repository<Autor> _repositoryAutor;
        private Repository<Key_Words> _repositoryKeyWord;

        public List<Par> _documentsId;

        public DocumentServices()
        {
            var context = new MyContextDb();
            _unitOfWork = new UnitOfWork(context);
            _repositoryDocument = new Repository<Document>(_unitOfWork);
            _repositoryTesis = new Repository<Tesis>(_unitOfWork);
            _repositoryLibro = new Repository<Libro>(_unitOfWork);
            _repositoryArticulo = new Repository<Articulo>(_unitOfWork);
            _repositoryAutor = new Repository<Autor>(_unitOfWork);
            _repositoryKeyWord = new Repository<Key_Words>(_unitOfWork);
        }

        public List<Par> DocumentsId
        {
            get { return _documentsId; }
            set { _documentsId = value; }
        }

        #region Search Methods

        /// <summary>
        /// Retorna todos los documentos 
        /// esto comprende a todas las tesis, libros y articulos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DocumentDto> GetDocuments()
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var docs = _unitOfWork.Context.Document
                    .Include(libros => libros.Libro)
                    .Include(tesis => tesis.Tesis)
                    .Include(articles => articles.Articulo)
                    .Distinct()
                    .OrderByDescending(y => y.year)
                    .ToList();
                var a = Mapper.Mapper.MapDocumentsToDocumentsDto(docs);
                FillDocumentsType(docs);
                return a;
            }
        }

        /// <summary>
        /// Busca todos los documentos que cumplan con el criterio que se pasa por parametro
        /// esto comprende a todas las tesis, libros y articulos
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<DocumentDto> SearchDocuments(string search)
        {
            search = search.ToLower();
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var docs = _unitOfWork.Context.Document
                    .Where(find => find.tittle.ToLower().Contains(search) ||
                                   find.Key_Words.Any(k => k.key_word.ToLower().Contains(search)) ||
                                   find.year.ToString().Equals(search) ||
                                   find.Autor.Any(nomb => nomb.nombre.ToLower().Contains(search)))
                    .Distinct()
                    .OrderByDescending(y => y.year)
                    .ToList();

                var tesis = SearchCategory(search);

                var libros = SearchBooksLiterature(search);

                var articulos = SearchArticlesLiterature(search);

                var result = new List<Document>();
                result.AddRange(docs);
                foreach (var document in tesis.Where(document => result.Find(x => x.id == document.id) == null))
                {
                    result.Add(document);
                }
                foreach (var document in libros.Where(document => result.Find(x => x.id == document.id) == null))
                {
                    result.Add(document);
                }
                foreach (var document in articulos.Where(document => result.Find(x => x.id == document.id) == null))
                {
                    result.Add(document);
                }

                FillDocumentsType(result);
                var a = Mapper.Mapper.MapDocumentsToDocumentsDto(result);
                return a;
            }
        }

        private List<Document> SearchArticlesLiterature(string search)
        {
            var articulos = _unitOfWork.Context.Document
                .Where(find => find.Articulo.Any(art => art.Literatura.ToLower().Contains(search)))
                .Distinct()
                .OrderByDescending(y => y.year)
                .ToList();
            return articulos;
        }

        private List<Document> SearchBooksLiterature(string search)
        {
            var libros = _unitOfWork.Context.Document
                .Where(find => find.Libro.Any(lib => lib.Literatura.ToLower().Contains(search)))
                .Distinct()
                .OrderByDescending(y => y.year)
                .ToList();
            return libros;
        }

        private List<Document> SearchCategory(string search)
        {
            var tesis = _unitOfWork.Context.Document
                .Where(find => find.Tesis.Any(tes => tes.Category.ToLower().Contains(search)))
                .Distinct()
                .OrderByDescending(y => y.year)
                .ToList();
            return tesis;
        }

        #endregion

        #region Insert Methods

        public void Insert(List<string> documentData, List<string> autores, List<string> keyWords, string typeDocument)
        {

            var newAutores = GetTupleAutorsAndKeyWords(autores, typeof (Autor)).Item1;

            var newKeyword = GetTupleAutorsAndKeyWords(keyWords, typeof (Key_Words)).Item2;

            InsertTypeDocument(documentData, typeDocument, newAutores, newKeyword);

        }

        private void InsertTypeDocument(List<string> documentData, string typeDocument, List<Autor> newAutores,
            List<Key_Words> newKeyword)
        {
            Document newDoc = new Document()
            {
                tittle = documentData[0],
                url_pdf = documentData[2],
                year = int.Parse(documentData[1]),
                Autor = newAutores,
                Key_Words = newKeyword

            };
            _repositoryDocument.Insert(newDoc);
            if (typeDocument.Equals("Tesis"))
            {
                InsertTesis(documentData, newDoc);
            }
            else if (typeDocument.Equals("Articulo"))
            {
                InsertArticulo(documentData, newDoc);
            }
            else
            {
                InsertLibro(documentData, newDoc);
            }
        }

        private void InsertLibro(List<string> documentData, Document newDoc)
        {
            Libro nueva = new Libro();
            nueva.Literatura = documentData[4];
            nueva.Document = newDoc;
            _repositoryLibro.Insert(nueva);
        }

        private void InsertArticulo(List<string> documentData, Document newDoc)
        {
            Articulo nueva = new Articulo();
            nueva.Literatura = documentData[4];
            nueva.event_localitation = documentData[6];
            nueva.Document = newDoc;
            _repositoryArticulo.Insert(nueva);
        }

        private void InsertTesis(List<string> documentData, Document newDoc)
        {
            Tesis nueva = new Tesis();
            nueva.Category = documentData[3];
            nueva.Description = documentData[5];
            nueva.Document = newDoc;

            _repositoryTesis.Insert(nueva);
        }

        #endregion

        #region Update Methods

        public void Update(List<string> documentData, List<string> autores,
            List<string> keyWords, string typeDocument, long idDocument, List<Par> documentsParList)
        {
            _documentsId = documentsParList;

            UpdateAutorsAndKeyWordsFromDocument(autores, keyWords, idDocument);

            List<Key_Words> newKeyword;
            var newAutores = VerifeAndInsertToDocument(autores, keyWords, out newKeyword);

            UpdateTypeDocument(documentData, typeDocument, newAutores, newKeyword, idDocument);
        }

        private List<Autor> VerifeAndInsertToDocument(List<string> autores, List<string> keyWords, out List<Key_Words> newKeyword)
        {
            var newAutores = GetTupleAutorsAndKeyWords(autores, typeof (Autor)).Item1;

            newKeyword = GetTupleAutorsAndKeyWords(keyWords, typeof (Key_Words)).Item2;
            return newAutores;
        }

        private void UpdateAutorsAndKeyWordsFromDocument(List<string> autores, List<string> keyWords, long idDocument)
        {
            Document modDocument = _repositoryDocument.All.Find(doc => doc.id == idDocument);

            var removesAutors = AutorsToRemove(autores, modDocument);

            RemoveAutorsFromDocument(removesAutors, modDocument);

            var removesKeyWords = KeyWToRemove(keyWords, modDocument);

            RemoveKeyWordsFromDocument(removesKeyWords, modDocument);
        }

        private void RemoveAutorsFromDocument(List<Autor> removesAutors, Document modDocument)
        {
            foreach (var removesAutor in removesAutors)
            {
                modDocument.Autor.Remove(removesAutor);
                _repositoryDocument.Update(modDocument);
                RemoveAutorsWithoutDocument(removesAutor);
            }
        }

        private void RemoveKeyWordsFromDocument(List<Key_Words> removesKeyWords, Document modDocument)
        {
            foreach (var keyWords in removesKeyWords)
            {
                modDocument.Key_Words.Remove(keyWords);
                _repositoryDocument.Update(modDocument);
                RemoveKeyWordsWithoutDocument(keyWords);
            }
        }
        private void RemoveAutorsWithoutDocument(Autor removesAutor)
        {
            if (removesAutor.Document.Count == 0)
                _repositoryAutor.Delete(removesAutor.id);
        }
        private void RemoveKeyWordsWithoutDocument(Key_Words removesKeyWord)
        {
            if (removesKeyWord.Document.Count == 0)
                _repositoryKeyWord.Delete(removesKeyWord.id);
        }

        private List<Autor> AutorsToRemove(List<string> autores, Document modDocument)
        {
            List<Autor> removesAutors = new List<Autor>();
            foreach (var autor in modDocument.Autor)
            {
                var found = autores.Any(newAutor => newAutor == autor.nombre);
                if (!found)
                {
                    removesAutors.Add(autor);
                }
            }
            return removesAutors;
        }

        private List<Key_Words> KeyWToRemove(List<string> keyWords, Document modDocument)
        {
            List<Key_Words> removesKeyW = new List<Key_Words>();
            foreach (var keyw in modDocument.Key_Words)
            {
                var found = keyWords.Any(newKeyW => newKeyW == keyw.key_word);
                if (!found)
                {
                    removesKeyW.Add(keyw);
                }
            }
            return removesKeyW;
        }

        private void UpdateTypeDocument(List<string> documentData, string typeDocument, List<Autor> newAutores,
            List<Key_Words> newKeyword, long idDocument)
        {
            var doc = _repositoryDocument.All.Find(x => x.id == idDocument);
            doc.tittle = documentData[0];
            doc.url_pdf = documentData[2];
            doc.year = int.Parse(documentData[1]);
            doc.Autor = new List<Autor>(newAutores);
            doc.Key_Words = new List<Key_Words>(newKeyword);

            try
            {
                _repositoryDocument.Update(doc);
            }
            catch (DbEntityValidationException exception)
            {
                //exception.EntityValidationErrors
                foreach (var dbEntityValidationResult in exception.EntityValidationErrors)
                {
                    foreach (var dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Debug.WriteLine(dbValidationError.ErrorMessage);
                    }
                }
            }

            if (typeDocument.Equals("Tesis"))
            {
                Tesis nueva = _repositoryTesis.All.Find(x => x.Documentid == idDocument);
                if (nueva == null)
                {
                    //Encuentro la entidad que estaba asociada al documento(tesis,libro o articulo)
                    var type = _documentsId.First(x => x.Id == idDocument).TipoDocumento;

                    //Borro la entidad vieja, para crear la nueva enlazada al documento con los valores modificados
                    DeleteCascade(idDocument, type);
                    InsertTesis(documentData,doc);
                }
                else
                {
                    UpdateTesis(documentData, nueva, doc);
                }
            }
            else if (typeDocument.Equals("Articulo"))
            {
                Articulo nueva = _repositoryArticulo.All.Find(x => x.Documentid == idDocument);
                if (nueva == null)
                {
                    //Encuentro la entidad que estaba asociada al documento(tesis,libro o articulo)
                    var type = _documentsId.First(x => x.Id == idDocument).TipoDocumento;

                    //Borro la entidad vieja, para crear la nueva enlazada al documento con los valores modificados
                    DeleteCascade(idDocument, type);
                    InsertArticulo(documentData, doc);
                }
                else
                {
                    UpdateArticulo(documentData, nueva, doc);
                }
            }
            else
            {
                Libro nueva = _repositoryLibro.All.Find(x => x.Documentid == idDocument);
                if (nueva == null)
                {
                    //Encuentro la entidad que estaba asociada al documento(tesis,libro o articulo)
                    var type = _documentsId.First(x => x.Id == idDocument).TipoDocumento;

                    //Borro la entidad vieja, para crear la nueva enlazada al documento con los valores modificados
                    DeleteCascade(idDocument, type);
                    InsertLibro(documentData, doc);
                }
                else
                {
                    UpdateLibro(documentData, nueva, doc);
                }
            }
        }

        private void UpdateLibro(List<string> documentData, Libro nueva, Document doc)
        {
            nueva.Literatura = documentData[4];
            nueva.Document = doc;
            _repositoryLibro.Update(nueva);
        }

        private void UpdateArticulo(List<string> documentData, Articulo nueva, Document doc)
        {
            nueva.Literatura = documentData[4];
            nueva.event_localitation = documentData[6];
            nueva.Document = doc;
            _repositoryArticulo.Update(nueva);
        }

        private void UpdateTesis(List<string> documentData, Tesis nueva, Document doc)
        {
            nueva.Category = documentData[3];
            nueva.Description = documentData[5];
            nueva.Document = doc;
            _repositoryTesis.Update(nueva);
        }

        #endregion

        #region Delete Methods

        /// <summary>
        /// Borra el Documentos asociado al Id
        /// </summary>
        /// <param name="idDocument">Id del Documento</param>
        public void Delete(long idDocument)
        {
            var typeDocument = _documentsId.First(x => x.Id == idDocument).TipoDocumento;
            DeleteCascade(idDocument, typeDocument);
            _repositoryDocument.Delete(idDocument);
        }

        /// <summary>
        /// Borra el tipo de documento que este asociado al Id pasado por parametro
        /// </summary>
        /// <param name="idDocument">Id del Documento</param>
        /// <param name="typeDocument">Tipo de documento</param>
        private void DeleteCascade(long idDocument, string typeDocument)
        {
            if (typeDocument.Equals("Tesis"))
            {
                DeleteTesis(idDocument);
            }
            else if (typeDocument.Equals("Articulo"))
            {
                DeleteArticulo(idDocument);
            }
            else
            {
                DeleteLibro(idDocument);
            }
        }

        private void DeleteTesis(long idDocument)
        {
            var thesis = _repositoryTesis.All.First(x => x.Documentid == idDocument);
            _repositoryTesis.Delete(thesis.id);
        }

        private void DeleteArticulo(long idDocument)
        {
            var article = _repositoryArticulo.All.First(x => x.Documentid == idDocument);
            _repositoryArticulo.Delete(article.id);
        }

        private void DeleteLibro(long idDocument)
        {
            var book = _repositoryLibro.All.First(x => x.Documentid == idDocument);
            _repositoryLibro.Delete(book.id);
        }

        #endregion

        #region Public Methods

        public string URLById(long id)
        {
            _unitOfWork = new UnitOfWork(new MyContextDb());
            Repository<Document> repo = new Repository<Document>(_unitOfWork);
            return repo.Find(id).url_pdf;
        }

        #endregion

        #region Private Methods
        private Tuple<List<Autor>, List<Key_Words>> GetTupleAutorsAndKeyWords(List<string> datas, Type type)
        {
            var tuple = Tuple.Create(new List<Autor>(), new List<Key_Words>());
            foreach (var data in datas)
            {

                if (type == typeof(Autor))
                {
                    GetAutorsToInsert(data, tuple);
                }
                else
                {
                    GetKeywordsToInsert(data, tuple);
                }
            }
            return tuple;
        }

        private void GetAutorsToInsert(string aut, Tuple<List<Autor>, List<Key_Words>> result)
        {
            if (!_repositoryAutor.All.Exists(autor => autor.nombre == aut))
            {
                Autor autor = new Autor()
                {
                    nombre = aut
                };
                _repositoryAutor.Insert(autor);
                result.Item1.Add(autor);
            }
            else
            {
                result.Item1.Add(_repositoryAutor.All.Find(x => x.nombre == aut));
            }
        }

        private void GetKeywordsToInsert(string keywords, Tuple<List<Autor>, List<Key_Words>> keyword)
        {
            if (!_repositoryKeyWord.All.Exists(kw => kw.key_word == keywords))
            {
                Key_Words autor = new Key_Words()
                {
                    key_word = keywords
                };
                _repositoryKeyWord.Insert(autor);
                keyword.Item2.Add(autor);
            }
            else
            {
                keyword.Item2.Add(_repositoryKeyWord.All.Find(x => x.key_word == keywords));
            }
        }

        private Tuple<List<Autor>, List<Key_Words>> UpdateTupleAutorsAndKeyWords(List<string> datas, Type type)
        {
            var tuple = Tuple.Create(new List<Autor>(), new List<Key_Words>());
            foreach (var data in datas)
            {

                if (type == typeof(Autor))
                {
                    GetAutorsToUpdate(data, tuple);
                }
                else
                {
                    GetKeywordsToInsert(data, tuple);
                }
            }
            return tuple;
        }

        private void GetAutorsToUpdate(string aut, Tuple<List<Autor>, List<Key_Words>> result)
        {
            if (!_repositoryAutor.All.Exists(autor => autor.nombre == aut))
            {
                Autor autor = new Autor()
                {
                    nombre = aut
                };
                
                _repositoryAutor.Insert(autor);
                result.Item1.Add(autor);
            }
            else
            {
                Autor modified = _repositoryAutor.All.Find(x => x.nombre == aut);
                _repositoryAutor.Update(modified);
                result.Item1.Add(modified);
            }
        }

        public bool IsUnicDocument(string titulo, string year, string tipoDocument)
        {
            switch (tipoDocument)
            {
                case "Tesis":
                    return !(_repositoryTesis.All.Any(thesis => thesis.Document.tittle == titulo &&
                                                              thesis.Document.year == int.Parse(year)));
                case "Libro":
                    return !(_repositoryLibro.All.Any(book => book.Document.tittle == titulo &&
                                                            book.Document.year == int.Parse(year)));
                default:
                    return !(_repositoryArticulo.All.Any(article => article.Document.tittle == titulo &&
                                                                  article.Document.year == int.Parse(year)));
            }
        }

        private string GetDocumentType(long id)
        {
            string result = "Articulo";

            if (_unitOfWork.Context.Tesis.Any(d => d.Documentid == id))
                return "Tesis";
            if (_unitOfWork.Context.Libro.Any(d => d.Documentid == id))
                return "Libro";
            return result;
        }

        /// <summary>
        /// Llenar la lista DocumentsId, donde cada fila esta compuesta por el Id del Document
        /// y el tipo de documento que es(Tesis,Libro,Articulo)
        /// </summary>
        /// <param name="docs"></param>
        private void FillDocumentsType(List<Document> docs)
        {
            _documentsId = new List<Par>();
            foreach (var tipo in docs)
            {
                _documentsId.Add(new Par(tipo.id, GetDocumentType(tipo.id)));
            }
        }

        #endregion
    }
}
