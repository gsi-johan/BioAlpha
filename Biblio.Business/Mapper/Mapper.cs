using System.Collections.Generic;
using System.Linq;
using Biblio.Business.Service;
using Biblio.Data;

namespace Biblio.Business.Mapper
{
    
    public static class Mapper
    {
        /// <summary>
        /// Mapear un documento a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public static DocumentDto MapDocumentToDocumentDto(Document document)
        {

          var a=  document.Autor;
            var autors = MapAutorsToString(document);


            var keysWords = MapKeysWordsToString(document);

            var documentDto = new DocumentDto
            {
                Titulo = document.tittle,
                Autores = autors,
                Año = document.year,
                Contenido = keysWords
            };
            

            return documentDto;
        }

        /// <summary>
        /// Mapear todos los documentos a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="documents"></param>
        /// <returns></returns>
        public static List<DocumentDto> MapDocumentsToDocumentsDto(List<Document> documents)
        {
            var documentsDto = new List<DocumentDto>();
            foreach (var document in documents)
            {
                documentsDto.Add(MapDocumentToDocumentDto(document));
            }
            return documentsDto;
        }

        /// <summary>
        /// Mapear una tesis a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="tesis"></param>
        /// <returns></returns>
        public static TesisDto MapTesisToTesisDto(Tesis tesis)
        {

            var a = tesis.Document.Autor;
            var autors = MapAutorsToString(tesis.Document);


            var keysWords = MapKeysWordsToString(tesis.Document);

            var tesisDto = new TesisDto()
            {
                Titulo = tesis.Document.tittle,
                Autores = autors,
                Año = tesis.Document.year,
                Contenido = keysWords,
                Categoría = tesis.Category
            };

            return tesisDto;
        }

        /// <summary>
        ///  Mapear todas las tesis a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="tesis"></param>
        /// <returns></returns>
        public static List<TesisDto> MapTesisesToTesisDto(List<Tesis> tesis)
        {
            var tesisDto = new List<TesisDto>();
            foreach (var t in tesis)
            {
                tesisDto.Add(MapTesisToTesisDto(t));
            }
            return tesisDto;
        }

        /// <summary>
        ///  Mapear un libro a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        public static BookDto MapBookToBookDto(Libro libro)
        {

            var autors = MapAutorsToString(libro.Document);
            var keysWords = MapKeysWordsToString(libro.Document);

            var libroDto = new BookDto()
            {
                Titulo = libro.Document.tittle,
                Autores = autors,
                Año = libro.Document.year,
                Contenido = keysWords,
                Literatura = libro.Literatura
            };

            return libroDto;
        }

        /// <summary>
        /// Mapear todos los libros a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public static List<BookDto> MapBooksToBooksDto(List<Libro> books)
        {
            var booksDto = new List<BookDto>();
            foreach (var b in books)
            {
                booksDto.Add(MapBookToBookDto(b));
            }
            return booksDto;
        }

        /// <summary>
        ///  Mapear un articulo a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static ArticleDto MapArticleToArticleDto(Articulo articulo)
        {

            var autors = MapAutorsToString(articulo.Document);
            var keysWords = MapKeysWordsToString(articulo.Document);

            var articuloDto = new ArticleDto()
            {
                Título = articulo.Document.tittle,
                Autores = autors,
                Año = articulo.Document.year,
                Contenido = keysWords,
                Literatura = articulo.Literatura,
                Registro = articulo.event_localitation
                
            };

            return articuloDto;
        }

        /// <summary>
        /// Mapear todos los articulos a la vista del cliente usando patron DTO
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        public static List<ArticleDto> MapArticlesToArticlesDto(List<Articulo> articles)
        {
            var articleDto = new List<ArticleDto>();
            foreach (var a in articles)
            {
                articleDto.Add(MapArticleToArticleDto(a));
            }
            return articleDto;
        }

        private static string MapAutorsToString(Document document)
        {
            string result = "";
            for (int i = 0; i < document.Autor.Count; i++)
            {
                if (i == document.Autor.Count - 1)
                {
                    result = result + document.Autor.ElementAt(i).nombre;
                }
                else
                {
                     result = result + (document.Autor.ElementAt(i).nombre + ";");
                }
               
            }
            return result;
        }

        private static string MapKeysWordsToString(Document document)
        {
            string result = "";
            for (int i = 0; i < document.Key_Words.Count; i++)
            {
                if (i == document.Key_Words.Count - 1)
                {
                    result += document.Key_Words.ElementAt(i).key_word;
                }
                else
                {
                    result += (document.Key_Words.ElementAt(i).key_word + ";");
                }
            }
            if (result == "")
                return "    _______    ";
            return result;
        }



       
    }
}
