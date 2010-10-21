using System;
using System.Data.Objects;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public interface IObjectContext : IDisposable
    {
        IObjectSet<T> CreateObjectSet<T>() where T : class;
        void SaveChanges();
    }
}