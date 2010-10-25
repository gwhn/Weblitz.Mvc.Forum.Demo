namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumSummary
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int TopicCount { get; set; }
        
        public int PostCount { get; set; }
    }
}