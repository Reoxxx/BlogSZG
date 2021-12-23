using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;
namespace BlogSZG.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager();
        public IActionResult Index(int page = 1)
        {
            var bloglist = bm.GetAll().ToPagedList(page,3);
            return View(bloglist);
        }

        public ActionResult Post(int id)
        {
            return View(bm.GetBlogById(id));
        }
        public PartialViewResult SearchForm()
        {
            return PartialView();
        }
        public PartialViewResult BlogList()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
        public PartialViewResult Paging()
        {
            return PartialView();
        }

        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogContent()
        {
            return PartialView();
        }

        public PartialViewResult Tags()
        {
            return PartialView();
        }
    }
}
