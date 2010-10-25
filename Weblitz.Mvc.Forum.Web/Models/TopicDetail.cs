﻿namespace Weblitz.Mvc.Forum.Web.Models
{
    public class TopicDetail
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string Body { get; set; }
        
        public string Forum { get; set; }
        
        public string Author { get; set; }
        
        public string PublishedDate { get; set; }
        
        public PostDetail[] Posts { get; set; }

        public PostInput NewPost { get; set; }
    }
}