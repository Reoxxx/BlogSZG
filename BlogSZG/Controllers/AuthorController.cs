using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;


namespace BlogSZG.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager authorManager = new AuthorManager();
        public IActionResult Index(int id)
        {
            return View(authorManager.GetAuthorById(id));
        }

        public ActionResult AdminAuthorList()
        {
            return View(authorManager.GetAll().ToPagedList(1, 7));
        }

        public ActionResult DeleteAuthor(int id)
        {
            authorManager.DeleteAuthor(id);
            return RedirectToAction("AdminAuthorList", "Author");
        }

        public ActionResult UpdateAuthor(int id)
        {

            return View(authorManager.GetAuthorById(id));
        }
        [HttpPost]
        public ActionResult _UpdateAuthor(Author author)
        {
            authorManager.UpdateAuthor(author);
            return RedirectToAction("AdminAuthorList", "Author");
        }
    }
}
