using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Biblio.Data.Repository
{
   public class Repository<T> where T:class,IIdentifiable
    {
        private readonly MyContextDb _context;
        public Repository(UnitOfWork.UnitOfWork uow)
        {
            _context = uow.Context as MyContextDb;
        }

        public T Find(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            _context.Entry(item).State=EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Set<T>().Attach(item);
            _context.Entry(item).State=EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var item = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public List<T> All => _context.Set<T>().ToList();

        public List<T> AllEagerList(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.ToList();
        }

        public void Dispose()
        {
            if(_context != null)
                _context.Dispose();
        }
    }
}
