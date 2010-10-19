﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblitz.Mvc.Forum.Web.ViewModels
{
    public class TopicSummary
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public int PostCount { get; internal set; }
        public bool IsSticky { get; internal set; }
    }
}