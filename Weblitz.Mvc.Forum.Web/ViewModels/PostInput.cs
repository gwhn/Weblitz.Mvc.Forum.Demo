using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class PostInput
    {
        public string TopicId { get; internal set; }
        public string Author { get; internal set; }
        public string Body { get; internal set; }
    }
}