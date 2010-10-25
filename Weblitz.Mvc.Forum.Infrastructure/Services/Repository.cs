using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Weblitz.Mvc.Forum.Core.Interfaces;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly IObjectSet<T> ObjectSet;

        public Repository(IObjectContext adapter)
        {
            ObjectSet = adapter.CreateObjectSet<T>();
        }

        public virtual IQueryable<T> AsQueryable()
        {
            return ObjectSet;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return ObjectSet.ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return ObjectSet.Where(where);
        }

        public virtual T Single(Expression<Func<T, bool>> where)
        {
            return ObjectSet.Single(where);
        }

        public virtual T First(Expression<Func<T, bool>> where)
        {
            return ObjectSet.First(where);
        }

        public virtual void Delete(T entity)
        {
            ObjectSet.DeleteObject(entity);
        }

        public virtual void Add(T entity)
        {
            ObjectSet.AddObject(entity);
        }

        public virtual void Attach(T entity)
        {
            ObjectSet.Attach(entity);
        }
    }
}
