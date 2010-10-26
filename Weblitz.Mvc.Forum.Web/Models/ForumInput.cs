using System.ComponentModel.DataAnnotations;

namespace Weblitz.Mvc.Forum.Web.Models
{
    public class ForumInput
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}