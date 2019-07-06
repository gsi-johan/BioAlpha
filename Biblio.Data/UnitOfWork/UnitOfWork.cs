using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblio.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private MyContextDb _context;

        public MyContextDb Context
        {
            get { return _context; }
        }

        public UnitOfWork(MyContextDb context)
        {
            _context = context;
        }

       public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            if(_context != null)
                _context.Dispose();
        }

    }
}
