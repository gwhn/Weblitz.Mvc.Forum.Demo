namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumDetail
    {
        public int Id { get; internal set; }
        
        public string Name { get; internal set; }
        
        public TopicSummary[] Topics { get; internal set; }
    }
}