using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class CategoryByBlog : ViewComponent
    {
        CategoryManager cm = new CategoryManager();
        public IViewComponentResult Invoke(int id)
        {
            return View(cm.GetCategoryById(id));
        }
    }
}
