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
            if (ModelState.IsValid)
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
            return RedirectToAction("Details", "Forum", new {Id = input.ForumId});
        }

        //
        // GET: /Topic/Edit/5

        public ActionResult Edit(int id)
        {
            using (var context = new ForumEntities())
            {
                var topic = context.Topics.Include("Forum").SingleOrDefault(f => f.Id == id);

                var input = Mapper.Map<Topic, TopicInput>(topic);

                input.Forums = new SelectList(context.Forums.OrderBy(f => f.Name).ToList(), "Id", "Name");

                return View(input);
            }
        }

        //
        // POST: /Topic/Edit/5

        [HttpPost]
        public ActionResult Edit(TopicInput input)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ForumEntities())
                {
                    var topic = context.Topics.SingleOrDefault(t => t.Id == input.Id);

                    topic.ForumId = input.ForumId;
                    topic.Title = input.Title;
                    topic.Body = input.Body;
                    topic.Sticky = input.IsSticky;

                    context.SaveChanges();

                    return RedirectToAction("Details", new {topic.Id});
                }
            }
            return View(input);
        }

        //
        // GET: /Topic/Delete/5

        public ActionResult Delete(int id)
        {
            using (var context = new ForumEntities())
            {
                var topic = context.Topics.SingleOrDefault(t => t.Id == id);

                var display = Mapper.Map<Topic, DeleteItem>(topic);

                display.CancelNavigation = new CancelNavigation("Details",
                                                                RouteData.Values["Controller"] as string,
                                                                new {id});

                return View(display);
            }
        }

        //
        // POST: /Topic/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            using (var context = new ForumEntities())
            {
                var topic = context.Topics.SingleOrDefault(t => t.Id == id);

                context.DeleteObject(topic);

                context.SaveChanges();

                return RedirectToAction("Details", "Forum", new {Id = topic.ForumId});
            }
        }
    }
}