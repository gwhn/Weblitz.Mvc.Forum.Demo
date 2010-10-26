using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Weblitz.Mvc.Forum.Db;
using Weblitz.Mvc.Forum.Web.Models;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class TopicController : Controller
    {
        //
        // GET: /Topic/Details/5

        public ActionResult Details(int id)
        {
            using (var context = new ForumEntities())
            {
                var topic = context.Topics
                    .Include("Forum")
                    .Include("Posts")
                    .SingleOrDefault(t => t.Id == id);

                var detail = Mapper.Map<Topic, TopicDetail>(topic);

                return View(detail);
            }
        }

        //
        // GET: /Topic/Create?ForumId=123

        public ActionResult Create(int forumId)
        {
            using (var context = new ForumEntities())
            {
                var input = new TopicInput
                                {
                                    Forums = new SelectList(context.Forums.OrderBy(f => f.Name).ToList(), "Id", "Name")
                                };

                return View(input);
            }
        }

        //
        // POST: /Topic/Create

        [HttpPost]
        public ActionResult Create(TopicInput input)
        {
            using (var context = new ForumEntities())
            {
                var topic = Topic.CreateTopic(0, input.ForumId, input.Title, input.Body, "tempuser", DateTime.Now,
                                              input.IsSticky);

                context.Topics.AddObject(topic);

                context.SaveChanges();

                return RedirectToAction("Details", new {topic.Id});
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
            ViewData["CancelId"] = id;
            ViewData["CancelAction"] = "Details";
            ViewData["CancelController"] = RouteData.Values["Controller"];
            var item = new DeleteItem
                           {
                               Id = id,
                               Description = "Topic item selected for deletion"
                           };
            return View(item);
        }

        //
        // POST: /Topic/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Details", "Forum", new {Id = 312});
            }
            catch
            {
                return View();
            }
        }
    }
}