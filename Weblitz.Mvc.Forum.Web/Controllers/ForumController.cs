using System.Collections.Generic;
using System.Web.Mvc;
using Weblitz.Mvc.Forum.Db;
using Weblitz.Mvc.Forum.Web.Models;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class ForumController : Controller
    {
//        private readonly ForumEntities context = new ForumEntities();

        //
        // GET: /Forum/

        public ViewResult Index()
        {
            using (var context = new ForumEntities())
            {
                var forums = context.Forums.Include("Topics");
                foreach (var forum in forums)
                {
                    foreach (var topic in forum.Topics)
                    {
                        if (!topic.Posts.IsLoaded)
                        {
                            topic.Posts.Load();
                        }
                    }
                }
                var summaries = AutoMapper.Mapper.Map<IEnumerable<Db.Forum>, IEnumerable<ForumSummary>>(forums);
                return View(summaries);                
            }
        }

        //
        // GET: /Forum/Details/5

        public ViewResult Details(int id)
        {
            var forum = new ForumDetail
                            {
                                Id = id,
                                Name = "Selected forum",
                                Topics = new[]
                                             {
                                                 new TopicSummary
                                                     {
                                                         Id = 11,
                                                         IsSticky = true,
                                                         PostCount = 43,
                                                         Title = "First Topic in Selected Forum"
                                                     },
                                                 new TopicSummary
                                                     {
                                                         Id = 12,
                                                         IsSticky = false,
                                                         PostCount = 25,
                                                         Title = "Second Topic in Selected Forum"
                                                     },
                                                 new TopicSummary
                                                     {
                                                         Id = 13,
                                                         IsSticky = false,
                                                         PostCount = 0,
                                                         Title = "Third Topic in Selected Forum"
                                                     }
                                             }
                            };
            return View(forum);
        }

        //
        // GET: /Forum/Create

        public ViewResult Create()
        {
            return View(new ForumInput());
        }

        //
        // POST: /Forum/Create

        [HttpPost]
        public ActionResult Create(ForumInput input)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Details", new{Id = 123});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Forum/Edit/5

        public ViewResult Edit(int id)
        {
            var forum = new ForumInput {Name = "Some name to edit"};
            return View(forum);
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ForumInput input)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Details", new{Id = id});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Forum/Delete/5

        public ViewResult Delete(int id)
        {
            ViewData["CancelId"] = id;
            ViewData["CancelAction"] = "Details";
            ViewData["CancelController"] = RouteData.Values["Controller"];
            var item = new DeleteItem
                           {
                               Id = id,
                               Description = "Forum item selected for deletion"
                           };
            return View(item);
        }

        //
        // POST: /Forum/Delete/5

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