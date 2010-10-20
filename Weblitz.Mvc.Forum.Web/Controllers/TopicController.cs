using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Mvc.Forum.Web.ViewModels;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class TopicController : Controller
    {
        //
        // GET: /Topic/Details/5

        public ActionResult Details(int id)
        {
            var topic = new TopicDetail
                            {
                                Author = "Selected Topic Author",
                                Body = "Body of Selected Topic",
                                Forum = "Forum that Selected Topic belongs to",
                                Id = id,
                                NewPost = new PostInput{ TopicId = id },
                                Posts = new[]
                                            {
                                                new PostDetail
                                                    {
                                                        Author = "First Post of Selected Topic Author",
                                                        Body = "Body of First Post of Selected Topic",
                                                        Id = 31,
                                                        PublishedDate = DateTime.Today.ToShortDateString()
                                                    },
                                                new PostDetail
                                                    {
                                                        Author = "Second Post of Selected Topic Author",
                                                        Body = "Body of Second Post of Selected Topic",
                                                        Id = 32,
                                                        PublishedDate =
                                                            DateTime.Today.Subtract(new TimeSpan(2, 0, 0, 0)).ToString()
                                                    },
                                                new PostDetail
                                                    {
                                                        Author = "Third Post of Selected Topic Author",
                                                        Body = "Body of Third Post of Selected Topic",
                                                        Id = 33,
                                                        PublishedDate =
                                                            DateTime.Today.Subtract(new TimeSpan(20, 0, 0, 0)).ToString()
                                                    }
                                            },
                                Title = "Title of Selected Article"
                            };
            return View(topic);
        }

        //
        // GET: /Topic/Create?ForumId=123

        public ActionResult Create(int forumId)
        {
            ViewData["Forum"] = "The forum in the current context";
            var topic = new TopicInput
                            {
                                ForumId = forumId
                            };
            return View(topic);
        }

        //
        // POST: /Topic/Create

        [HttpPost]
        public ActionResult Create(TopicInput input)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Details", new {Id = 123});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Topic/Edit/5

        public ActionResult Edit(int id)
        {
            ViewData["Forum"] = "This is the forum for the current context";
            var topic = new TopicInput
                            {
                                ForumId = 321,
                                Body = "This is the body of text to edit for the selected topic",
                                IsSticky = false,
                                Title = "Title of the topic"
                            };
            return View(topic);
        }

        //
        // POST: /Topic/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, TopicInput input)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Details", new {Id = id});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Topic/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Topic/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}