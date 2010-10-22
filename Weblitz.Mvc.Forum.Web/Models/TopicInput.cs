using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Weblitz.Mvc.Forum.Web.Models
{
    public class TopicInput
    {
        [Required, StringLength(256)]
        public string Title { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [DisplayName("Sticky?")]
        public bool IsSticky { get; set; }

        [ScaffoldColumn(false)]
        public int ForumId { get; set; }
    }
}