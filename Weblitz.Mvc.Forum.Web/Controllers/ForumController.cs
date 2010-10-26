using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Weblitz.Mvc.Forum.Db;
using Weblitz.Mvc.Forum.Web.Models;

namespace Weblitz.Mvc.Forum.Web.Controllers
{
    public class ForumController : Controller
    {
        //
        // GET: /Forum/

        public ViewResult Index()
        {
            using (var context = new ForumEntities())
            {
                var forums = GetForums(context);

                var summaries = Mapper.Map<IEnumerable<Db.Forum>, IEnumerable<ForumSummary>>(forums);

                return View(summaries);
            }
        }

        //
        // GET: /Forum/Details/5

        public ViewResult Details(int id)
        {
            using (var context = new ForumEntities())
            {
                var forum = GetForums(context).SingleOrDefault(f => f.Id == id);

                var detail = Mapper.Map<Db.Forum, ForumDetail>(forum);

                return View(detail);
            }
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
            if (ModelState.IsValid)
            {
                using (var context = new ForumEntities())
                {
                    var forum = Db.Forum.CreateForum(0, input.Name);

                    context.Forums.AddObject(forum);

                    context.SaveChanges();

                    return RedirectToAction("Details", new {forum.Id});
                }
            }
            return View(new ForumInput());
        }

        //
        // GET: /Forum/Edit/5

        public ViewResult Edit(int id)
        {
            using (var context = new ForumEntities())
            {
                var forum = context.Forums.SingleOrDefault(f => f.Id == id);

                var input = Mapper.Map<Db.Forum, ForumInput>(forum);

                return View(input);
            }
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        public ActionResult Edit(ForumInput input)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ForumEntities())
                {
                    var forum = context.Forums.SingleOrDefault(f => f.Id == input.Id);

                    forum = Mapper.Map<ForumInput, Db.Forum>(input);

                    context.SaveChanges();

                    return RedirectToAction("Details", new {forum.Id});
                }
            }
            return View(input);
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

        private static ObjectQuery<Db.Forum> GetForums(ForumEntities context)
        {
            var forums = context.Forums.Include("Topics");
            foreach (var topic in forums.SelectMany(f => f.Topics))
            {
                topic.Posts.Load();
            }
            return forums;
        }
    }
}