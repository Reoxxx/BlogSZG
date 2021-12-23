using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AboutCover()
        {
            return PartialView();
        }

        public PartialViewResult AboutContent()
        {
            return PartialView();
        }

        public PartialViewResult AboutAuthors()
        {
            return PartialView();
        }
    }
}
