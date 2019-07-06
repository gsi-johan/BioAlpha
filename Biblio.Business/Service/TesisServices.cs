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
   public class TesisServices
    {
        private UnitOfWork _unitOfWork;
        public List<long> TesisId = new List<long>();
        public TesisServices()
        {}

        /// <summary>
        /// Retorna todas las tesis
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TesisDto> GetTesis()
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tesis = _unitOfWork.Context.Tesis.OrderByDescending(y => y.Document.year).ToList();
                FillDocumentsType(tesis);
                var a = Mapper.Mapper.MapTesisesToTesisDto(tesis);

                return a;
            }
        }

        /// <summary>
        /// Buscar todas las tesis que cumplan con el criterio que se pasa por parametro
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<TesisDto> SearchTesis(string search)
        {
            search = search.ToLower();
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Tesis
                    .Where(find => find.Document.tittle.ToLower().Contains(search) ||
                                   find.Category.ToLower().Contains(search) ||
                                   find.Document.Key_Words.Any(k => k.key_word.ToLower().Contains(search)) ||
                                   find.Document.year.ToString().Equals(search) ||
                                   find.Document.Autor.Any(nomb => nomb.nombre.ToLower().Contains(search)) ||
                                   find.Document.Autor.Any(nomb => nomb.apellidos.ToLower().Contains(search)))
                    .Distinct()
                    .OrderByDescending(y => y.Document.year)
                    .ToList();
                FillDocumentsType(tes);
                var a = Mapper.Mapper.MapTesisesToTesisDto(tes);
                return a;
            }
        }

       public string CategoryByIdDocument(long id)
       {
           using (_unitOfWork = new UnitOfWork(new MyContextDb()))
           {
               var tes = _unitOfWork.Context.Tesis.FirstOrDefault(t => t.Documentid == id);
               return tes.Category;
           }
       }

       public string DescripctionByIdDocument(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Tesis.FirstOrDefault(t => t.Documentid == id);
                return tes.Description;
            }
        }

        /// <summary>
        /// Llenar la lista TesisId, donde cada fila esta compuesta por el Id de las Tesis que se van
        /// a mostrar al usuario
        /// </summary>
        /// <param name="tesis"></param>
        void FillDocumentsType(List<Tesis> tesis)
        {
            TesisId=new List<long>();
            foreach (var idTesis in tesis)
            {
                TesisId.Add(idTesis.id);
            }
        }
        public Tesis GetTesisById(long id)
        {
            using (_unitOfWork = new UnitOfWork(new MyContextDb()))
            {
                var tes = _unitOfWork.Context.Tesis.FirstOrDefault(t => t.id == id);
                return tes;
            }
        }


    }
}
