using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Weblitz.Mvc.Forum.Web.Models.Mappings;

namespace Weblitz.Mvc.Forum.Web.Bootstrappers
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(x => x.AddProfile<ForumProfile>());
        }
    }
}