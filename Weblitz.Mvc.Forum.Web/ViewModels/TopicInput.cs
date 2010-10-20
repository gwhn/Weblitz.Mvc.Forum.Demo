using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class TopicInput
    {
        [Required, StringLength(255)]
        public string Title { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [DisplayName("Sticky?")]
        public bool IsSticky { get; set; }

        [ScaffoldColumn(false)]
        public int ForumId { get; set; }
    }
}