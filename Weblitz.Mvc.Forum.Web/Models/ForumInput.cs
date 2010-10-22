using System.ComponentModel.DataAnnotations;

namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumInput
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}