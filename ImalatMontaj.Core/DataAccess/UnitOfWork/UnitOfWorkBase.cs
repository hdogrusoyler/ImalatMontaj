using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Core.DataAccess.UnitOfWork
{
    public class UnitOfWorkBase<TContext> : IUnitOfWork, IDisposable
        where TContext : DbContext
    {
        private TContext _context;

        public UnitOfWorkBase(TContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
