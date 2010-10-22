namespace Weblitz.Mvc.Forum.Web.Models
{
    public class TopicSummary
    {
        public int Id { get; internal set; }

        public string Title { get; internal set; }
        
        public int PostCount { get; internal set; }
        
        public bool IsSticky { get; internal set; }
    }
}