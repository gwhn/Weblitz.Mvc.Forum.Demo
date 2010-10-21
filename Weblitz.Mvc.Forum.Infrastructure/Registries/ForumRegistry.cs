using StructureMap.Configuration.DSL;
using Weblitz.Mvc.Forum.Core;
using Weblitz.Mvc.Forum.Infrastructure.Services;

namespace Weblitz.Mvc.Forum.Infrastructure.Registries
{
    public class ForumRegistry : Registry
    {
        public ForumRegistry()
        {
            For<IRepository<Topic>>().Use<Repository<Topic>>();
        }
    }
}
