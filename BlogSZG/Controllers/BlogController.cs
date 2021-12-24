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
        CategoryManager cm = new CategoryManager();
        AuthorManager authorManager = new AuthorManager();
        CommentManager com = new CommentManager();
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
        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public ActionResult BlogsByCategory(int id)
        {
            TempData["categoryName"] =cm.GetCategoryById(id).CategoryName;
            TempData["categoryId"] = id;
            var blogs = bm.GetBlogsByCategory(id).ToPagedList(1, 3);
            return View(blogs);
        }

        public ActionResult BlogsByAuthor(int id)
        {
            TempData["authorName"] = authorManager.GetAuthorById(id).Name + " " + authorManager.GetAuthorById(id).Surname;
            TempData["authorId"] = id;
            var blogs = bm.GetBlogsByAuthor(id).ToPagedList(1, 3);
            return View(blogs);
        }

        public int CommentCount(int id)
        {
            return com.GetCommentCount(id);
        }
    }
}
