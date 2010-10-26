namespace Weblitz.Mvc.Forum.Web.Models
{
    public class DeleteItem
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public CancelNavigation CancelNavigation { get; set; }
    }
}