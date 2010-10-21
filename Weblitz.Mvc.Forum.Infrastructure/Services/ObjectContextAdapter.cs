using System.Data.Objects;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class ObjectContextAdapter : IObjectContext
    {
        readonly ObjectContext _context;

        public ObjectContextAdapter(ObjectContext context)
        {
            _context = context;
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