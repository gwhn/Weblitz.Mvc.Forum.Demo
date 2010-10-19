using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class DeleteItem
    {
        public int Id { get; internal set; }
        public string YesAction { get; internal set; }
        public string NoAction { get; internal set; }
        public string Description { get; internal set; }
    }
}