using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        
        public IActionResult Index()
        {
            return View(cm.GetAll());
        }

        public ActionResult Category()
        {
            return View();
        }


    }
}
