using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Biblio.Data;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using Biblio.Data.UnitOfWork;
using Biblio.Data.Repository;

namespace Biblio.Business
{
    public class Services
    {
        public static List<string> GetAllAutors_Names()
        {
            using (var context = new MyContextDb())
            {
                UnitOfWork unit = new UnitOfWork(context);

                Repository<Autor> r = new Repository<Autor>(unit);
               return r.All
                    .Select(a=>a.nombre)
                    .ToList();
                
            }
            
        }

        public static List<string> getAllDocumentsbyYear(int year)
        {
            //#region Get all albums that contain the track with the word 'Love' in its title
            //var query = context.Tracks
            //    .Include(t => t.Album)
            //    .Where(t => t.Name.Contains("Love"))
            //    .Select(t => t.Album)
            //    .Distinct();

            using (var context = new MyContextDb())
            {
                var query = context.Document
                    .Include(tesis => tesis.Tesis)
                    .Include(libros => libros.Libro)
                    .Include(articles => articles.Articulo)
                    .Where(d => d.year == year);
                //foreach (var item in query)
                //{
                //    item.
                //}
                    
            }


            return new List<string>();
        }

    }
}
