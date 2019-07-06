using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Biblio.Data;
using Biblio.Data.UnitOfWork;
using Biblio.Business.Mapper;
using Biblio.Data.Repository;

namespace Biblio.Business.Service
{
    public class ArticleServices
    {

        private UnitOfWork _unitOfWork;
        public List<long> ArticlesId = new List<long>();
        public ArticleServices()
        {}

        /// <summary>
        /// Retorna todos los articulos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ArticleDto> GetArticles()
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var art = _unitOfWork.Context.Articulo.OrderByDescending(y => y.Document.year).ToList();
                FillDocumentsType(art);
                var a = Mapper.Mapper.MapArticlesToArticlesDto(art);

                return a;
            }
        }

        /// <summary>
        /// Buscar todos los articulos que cumplan con el criterio que se pasa por parametro
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<ArticleDto> SearchArticles(string search)
        {
            search = search.ToLower();
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var artics = _unitOfWork.Context.Articulo
                    .Where(find => find.Document.tittle.ToLower().Contains(search) ||
                                   find.Document.Key_Words.Any(k => k.key_word.ToLower().Contains(search)) ||
                                   find.Document.year.ToString().Equals(search) ||
                                  find.Document.Autor.Any(nomb => nomb.nombre.ToLower().Contains(search)) ||
                                  find.Document.Autor.Any(nomb => nomb.apellidos.ToLower().Contains(search) ||
                                  find.Literatura.ToLower().Contains(search)) ||
                                   find.event_localitation.ToLower().Contains(search))
                    .Distinct()
                    .OrderByDescending(y => y.Document.year)
                    .ToList();
                FillDocumentsType(artics);
                var a = Mapper.Mapper.MapArticlesToArticlesDto(artics);
                return a;
            }
        }
        public string LiteraturaByIdDocument(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Articulo.FirstOrDefault(t => t.Documentid == id);
                return tes.Literatura;
            }
        }
        public string LocalitationByIdDocument(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Articulo.FirstOrDefault(t => t.Documentid == id);
                return tes.event_localitation;
            }
        }

        /// <summary>
        /// Llenar la lista ArticlesId, donde cada fila esta compuesta por el Id de los Articulos que se van
        /// a mostrar al usuario
        /// </summary>
        /// <param name="arts"></param>
        void FillDocumentsType(List<Articulo> arts)
        {
            ArticlesId=new List<long>();
            foreach (var idArt in arts)
            {
                ArticlesId.Add(idArt.id);
            }
        }

        public Articulo GetArticleById(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var art = _unitOfWork.Context.Articulo.FirstOrDefault(t => t.id == id);
                return art;
            }
        }
    }
}
