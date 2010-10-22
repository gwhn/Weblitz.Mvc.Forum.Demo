using System.ComponentModel.DataAnnotations;

namespace Weblitz.Mvc.Forum.Web.Models
{
    public class PostInput
    {
        [ScaffoldColumn(false)]
        public int TopicId { get; set; }

        [Required, StringLength(256)]
        public string Author { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}