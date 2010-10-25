namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumDetail
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public TopicSummary[] Topics { get; set; }
    }
}