namespace Weblitz.Mvc.Forum.Web.Models
{
    public class PostDetail
    {
        public int Id { get; internal set; }

        public string Body { get; internal set; }
        
        public string Author { get; internal set; }
        
        public string PublishedDate { get; internal set; }
    }
}