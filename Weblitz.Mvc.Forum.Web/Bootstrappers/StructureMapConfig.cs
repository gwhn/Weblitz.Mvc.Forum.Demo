using System.Web.Mvc;
using StructureMap;
using Weblitz.Mvc.Forum.Infrastructure.Registries;
using Weblitz.Mvc.Forum.Web.Controllers.Factories;

namespace Weblitz.Mvc.Forum.Web.Bootstrappers
{
    public static class StructureMapConfig
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.AddRegistry<ForumRegistry>());
        }
    }
}