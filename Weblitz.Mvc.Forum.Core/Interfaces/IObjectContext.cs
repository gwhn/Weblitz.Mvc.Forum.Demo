using System;
using System.Data.Objects;

namespace Weblitz.Mvc.Forum.Core.Interfaces
{
    public interface IObjectContext : IDisposable
    {
        IObjectSet<T> CreateObjectSet<T>() where T : class;

        void SaveChanges();
    }
}