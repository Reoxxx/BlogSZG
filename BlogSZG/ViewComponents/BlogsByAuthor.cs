using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogSZG.ViewComponents
{
    public class BlogsByAuthor : ViewComponent
    {
        BlogManager bm = new BlogManager();
        AuthorManager authorManager = new AuthorManager();
        public IViewComponentResult Invoke(int id)
        {
            TempData["authorName"] = authorManager.GetAuthorById(id).Name + " " + authorManager.GetAuthorById(id).Surname;
            TempData["authorId"] = id;
            var blogs = bm.GetBlogsByAuthor(id).ToPagedList(1,3);
            return View(blogs);
        }
    }
}
