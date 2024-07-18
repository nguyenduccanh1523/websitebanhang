using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitebanhang.Models;
using websitebanhang.Models.EF;

namespace websitebanhang.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Posts
        public ActionResult Index(int? page)
        {

            var pageSize = 10;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Posts> items = db.Posts.Where(x => x.IsActive).OrderByDescending(x => x.Id);
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }

        public ActionResult Detail(int id)
        {
            var item = db.Posts.Find(id);
            return View(item);
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}