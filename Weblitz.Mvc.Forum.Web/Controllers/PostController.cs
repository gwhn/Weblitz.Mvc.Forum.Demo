using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Mvc.Forum.Web.ViewModels;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class PostController : Controller
    {
        [HttpPost]
        public ActionResult Create(PostInput input)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Details", "Topic", new {Id = input.TopicId});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Edit/5

        public ActionResult Edit(int id)
        {
            ViewData["Topic"] = "The topic title in the current context";
            var post = new PostInput
                           {
                               TopicId = 432,
                               Author = "Author of post",
                               Body = "this is the body of the post that is being edited"
                           };
            return View(post);
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, PostInput input)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Details", "Topic", new {Id = input.TopicId});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5

        public ActionResult Delete(int id)
        {
            var topicId = 312;
            ViewData["CancelId"] = topicId;
            ViewData["CancelAction"] = "Details";
            ViewData["CancelController"] = "Topic";
            var item = new DeleteItem
                           {
                               Id = id,
                               Description = "Post item selected for deletion"
                           };
            return View(item);
        }

        //
        // POST: /Post/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Details", "Topic", new {Id = 312});
            }
            catch
            {
                return View();
            }
        }
    }
}