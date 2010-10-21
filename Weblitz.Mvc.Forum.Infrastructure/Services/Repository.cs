using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        IObjectSet<T> _objectSet;

        public Repository(IObjectContext objectContext)
        {
            _objectSet = objectContext.CreateObjectSet<T>();
        }

        public IQueryable<T> AsQueryable()
        {
            return _objectSet;
        }

        public IEnumerable<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where);
        }

        public T Single(Expression<Func<T, bool>> where)
        {
            return _objectSet.Single(where);
        }

        public T First(Expression<Func<T, bool>> where)
        {
            return _objectSet.First(where);
        }

        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
        }

        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }
    }
}
