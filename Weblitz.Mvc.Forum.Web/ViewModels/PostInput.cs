using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class PostInput
    {
        public string TopicId { get; internal set; }

        [Required, StringLength(255)]
        public string Author { get; internal set; }

        [Required]
        public string Body { get; internal set; }
    }
}