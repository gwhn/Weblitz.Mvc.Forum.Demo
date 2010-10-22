using System;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace Weblitz.Mvc.Forum.Web.Controllers.Factories
{
    public class ForumControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return ObjectFactory.GetInstance(controllerType) as IController;
        }
    }
}