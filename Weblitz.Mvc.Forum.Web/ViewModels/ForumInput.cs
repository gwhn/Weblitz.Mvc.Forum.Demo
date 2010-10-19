using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class ForumInput
    {
        public int Id { get; internal set; }
        public string Action { get; internal set; }
        public string Name { get; internal set; }
    }
}