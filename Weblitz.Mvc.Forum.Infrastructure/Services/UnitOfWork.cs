using System;
using Weblitz.Mvc.Forum.Core.Interfaces;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IObjectContext _objectContext;

        public UnitOfWork(IObjectContext objectContext)
        {
            _objectContext = objectContext;
        }

        public void Dispose()
        {
            if (_objectContext != null)
            {
                _objectContext.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Commit()
        {
            _objectContext.SaveChanges();
        }
    }
}