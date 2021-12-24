using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager();
        public IActionResult Index()
        {
            return View(aboutManager.GetAboutById(1));
        }
    }
}
