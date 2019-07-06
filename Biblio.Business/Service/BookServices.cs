using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblio.Business.Mapper;
using Biblio.Data;
using Biblio.Data.UnitOfWork;
using System.Data.Entity;

namespace Biblio.Business.Service
{
    public class BookServices
    {
        private UnitOfWork _unitOfWork;
        public List<long> BooksId = new List<long>();

        public BookServices()
        {}
       
        /// <summary>
        /// Retorna todos los libros
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookDto> GetBooks()
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var lib = _unitOfWork.Context.Libro.OrderByDescending(y => y.Document.year).ToList();
                FillDocumentsType(lib);
                var a = Mapper.Mapper.MapBooksToBooksDto(lib);

                return a;
            }
        }

        /// <summary>
        /// Buscar todos los libros que cumplan con el criterio que se pasa por parametro
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<BookDto> SearchBooks(string search)
        {
            search = search.ToLower();
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var books = _unitOfWork.Context.Libro
                    .Where(find => find.Document.tittle.ToLower().Contains(search) ||
                                   find.Document.Key_Words.Any(k => k.key_word.ToLower().Contains(search)) ||
                                   find.Document.year.ToString().Equals(search) ||
                                  find.Document.Autor.Any(nomb => nomb.nombre.ToLower().Contains(search)) ||
                                  find.Document.Autor.Any(nomb => nomb.apellidos.ToLower().Contains(search)) ||
                                  find.Literatura.ToLower().Contains(search))
                    .Distinct()
                    .OrderByDescending(y => y.Document.year)
                    .ToList();
                FillDocumentsType(books);
                var a = Mapper.Mapper.MapBooksToBooksDto(books);
                return a;
            }
        }
        public string LiteraturaByIdDocument(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Libro.FirstOrDefault(t => t.Documentid == id);
                return tes.Literatura;
            }
        }
        /// <summary>
        /// Llenar la lista BooksId, donde cada fila esta compuesta por el Id de los libros que se van
        /// a mostrar al usuario
        /// </summary>
        /// <param name="books"></param>
        void FillDocumentsType(List<Libro> books)
        {
            BooksId=new List<long>();
            foreach (var idBook in books)
            {
                BooksId.Add(idBook.id);
            }
        }

        public Libro GetBookById(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var lib = _unitOfWork.Context.Libro.FirstOrDefault(t => t.id == id);
                return lib;
            }
        }
    }
}
