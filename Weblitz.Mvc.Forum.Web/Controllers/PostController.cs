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
    public class PostController : Controller
    {
        [HttpPost]
        public ActionResult Create(PostInput input)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ForumEntities())
                {
                    var post = Post.CreatePost(0, input.TopicId, input.Body, input.Author, DateTime.Now);

                    context.Posts.AddObject(post);

                    context.SaveChanges();
                }
            }
            return RedirectToAction("Details", "Topic", new {Id = input.TopicId});
        }

        //
        // GET: /Post/Edit/5

        public ActionResult Edit(int id)
        {
            using (var context = new ForumEntities())
            {
                var post = context.Posts.SingleOrDefault(p => p.Id == id);

                var input = Mapper.Map<Post, PostInput>(post);

                return View(input);
            }
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(PostInput input)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ForumEntities())
                {
                    var post = context.Posts.SingleOrDefault(p => p.Id == input.Id);

                    post.Author = input.Author;
                    post.Body = input.Body;
                    post.TopicId = input.TopicId;

                    context.SaveChanges();
                }
            }
            return RedirectToAction("Details", "Topic", new {Id = input.TopicId});
        }

        //
        // GET: /Post/Delete/5

        public ActionResult Delete(int id)
        {
            using (var context = new ForumEntities())
            {
                var post = context.Posts.SingleOrDefault(p => p.Id == id);

                var display = Mapper.Map<Post, DeleteItem>(post);

                display.CancelNavigation = new CancelNavigation("Details", "Topic", new {id = post.TopicId});

                return View(display);
            }
        }

        //
        // POST: /Post/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            using (var context = new ForumEntities())
            {
                var post = context.Posts.SingleOrDefault(p => p.Id == id);

                context.DeleteObject(post);

                context.SaveChanges();

                return RedirectToAction("Details", "Topic", new {Id = post.TopicId});
            }
        }

        //
        // POST: /Post/Flag/5

        [HttpPost]
        public ActionResult Flag(int id)
        {
            try
            {
                return RedirectToAction("Details", "Topic", new {Id = 8989});
            }
            catch
            {
                return View();
            }
        }
    }
}