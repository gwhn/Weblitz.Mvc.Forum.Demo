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
            return View();
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, PostInput input)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Details", "Topic");
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
            return View();
        }

        //
        // POST: /Post/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Details", "Topic");
            }
            catch
            {
                return View();
            }
        }
    }
}