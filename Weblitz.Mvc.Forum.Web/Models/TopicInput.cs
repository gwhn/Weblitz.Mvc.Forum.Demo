using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Weblitz.Mvc.Forum.Web.Models
{
    public class TopicInput
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(256)]
        public string Title { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [DisplayName("Sticky?")]
        public bool IsSticky { get; set; }

        [ScaffoldColumn(false), DisplayName("Forum")]
        public int ForumId { get; set; }

        public IEnumerable<SelectListItem> Forums { get; set; }
    }
}