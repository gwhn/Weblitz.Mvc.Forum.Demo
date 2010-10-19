using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class ForumDetail
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public TopicSummary[] Topics { get; internal set; }
    }
}