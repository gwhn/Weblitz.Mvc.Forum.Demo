namespace Weblitz.Mvc.Forum.Web.Models
{
    public class TopicSummary
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public int PostCount { get; set; }
        
        public bool IsSticky { get; set; }
    }
}