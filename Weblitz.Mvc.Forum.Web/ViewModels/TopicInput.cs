using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class TopicInput
    {
        public int Id { get; internal set; }
        public string Action { get; internal set; }
        public string Title { get; internal set; }
        public string Body { get; internal set; }
        public bool IsSticky { get; internal set; }
        public int ForumId { get; internal set; }
    }
}