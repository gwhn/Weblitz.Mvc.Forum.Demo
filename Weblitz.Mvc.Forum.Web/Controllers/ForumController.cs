using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Mvc.Forum.Web.ViewModels;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class ForumController : Controller
    {
        //
        // GET: /Forum/

        public ActionResult Index()
        {
            var forums = new[]
                             {
                                 new ForumSummary
                                     {
                                         Id = 1,
                                         Name = "First forum",
                                         PostCount = 48,
                                         TopicCount = 32
                                     },
                                 new ForumSummary
                                     {
                                         Id = 2,
                                         Name = "Second forum",
                                         PostCount = 2,
                                         TopicCount = 1
                                     },
                                 new ForumSummary
                                     {
                                         Id = 3,
                                         Name = "Third forum",
                                         PostCount = 0,
                                         TopicCount = 5
                                     },
                             };
            return View(forums);
        }

        //
        // GET: /Forum/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Forum/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Forum/Create

        [HttpPost]
        public ActionResult Create(ForumInput input)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Forum/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ForumInput input)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Forum/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Forum/Destroy/5

        [HttpPost]
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

        //
        // POST: /Forum/Search/Query

        [HttpPost]
        public ActionResult Search(SearchQuery query)
        {
            try
            {
                // TODO: Add search logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}