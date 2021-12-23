using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AuthorBlogs()
        {
            return PartialView();
        }

        public PartialViewResult AuthorAbout()
        {
            return PartialView();
        }
    }
}
