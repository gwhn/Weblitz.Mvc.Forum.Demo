using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class ForumInput
    {
        [Required]
        public int Id { get; internal set; }

        public string Action { get; internal set; }

        [Required, StringLength(255)]
        public string Name { get; internal set; }
    }
}