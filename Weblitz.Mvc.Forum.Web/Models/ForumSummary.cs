namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumSummary
    {
        public int Id { get; internal set; }
        
        public string Name { get; internal set; }
        
        public int TopicCount { get; internal set; }
        
        public int PostCount { get; internal set; }
    }
}