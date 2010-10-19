using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class TopicDetail
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public string Body { get; internal set; }
        public string Forum { get; internal set; }
        public string Author { get; internal set; }
        public DateTime PublishedDate { get; internal set; }
        public PostDetail[] Posts { get; internal set; }
        public PostInput NewPost { get; internal set; }
    }
}