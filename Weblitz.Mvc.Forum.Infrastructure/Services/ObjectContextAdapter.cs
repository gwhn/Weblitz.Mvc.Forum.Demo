using System.Data.Objects;
using Weblitz.Mvc.Forum.Core.Interfaces;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class ObjectContextAdapter : IObjectContext
    {
        private readonly ObjectContext _context;

        public ObjectContextAdapter(ObjectContext context)
        {
            _context = context;
            _context.ContextOptions.LazyLoadingEnabled = false;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IObjectSet<T> CreateObjectSet<T>() where T : class
        {
            return _context.CreateObjectSet<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
