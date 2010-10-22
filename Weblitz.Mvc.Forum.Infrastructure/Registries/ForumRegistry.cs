using System.Data.Objects;
using StructureMap.Configuration.DSL;
using Weblitz.Mvc.Forum.Core;
using Weblitz.Mvc.Forum.Core.Interfaces;
using Weblitz.Mvc.Forum.Db;
using Weblitz.Mvc.Forum.Infrastructure.Services;

namespace Weblitz.Mvc.Forum.Infrastructure.Registries
{
    public class ForumRegistry : Registry
    {
        public ForumRegistry()
        {
            For<ObjectContext>().Use(new ForumEntities());

            For<IObjectContext>().Use<ObjectContextAdapter>();

            For<IUnitOfWork>().Use<UnitOfWork>();

            For(typeof (IRepository<>)).Use(typeof (Repository<>));

        }
    }
}
