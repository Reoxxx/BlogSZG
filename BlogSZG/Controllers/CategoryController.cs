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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        
        public IActionResult Index()
        {
            return View(cm.GetAll());
        }

        public ActionResult AdminCategoryList()
        {
            var categoryList = cm.GetAll().ToPagedList(1, 7);
            return View(categoryList);
        }
        public ActionResult AddCategory(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewCategory(Category category)
        {
            cm.AddCategory(category);
            return RedirectToAction("AdminCategoryList", "Category");
        }
        public ActionResult DeleteCategory(int id)
        {
            cm.DeleteCategory(id);
            return RedirectToAction("AdminCategoryList","Category");
        }
        public ActionResult UpdateCategory(int id)
        {
            return View(cm.GetCategoryById(id));
        }
        [HttpPost]
        public ActionResult _UpdateCategory(Category category)
        {
            cm.UpdateCategory(category);
            return RedirectToAction("AdminCategoryList", "Category");
        }
    }
}
