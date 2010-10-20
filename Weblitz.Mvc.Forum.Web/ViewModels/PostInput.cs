using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class PostInput
    {
        [ScaffoldColumn(false)]
        public int TopicId { get; set; }

        [Required, StringLength(255)]
        public string Author { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}