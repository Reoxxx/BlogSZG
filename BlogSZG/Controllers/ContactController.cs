using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult ContactForm()
        {
            return PartialView();
        }

        public PartialViewResult ContactUs()
        {
            return PartialView();
        }
    }
}
