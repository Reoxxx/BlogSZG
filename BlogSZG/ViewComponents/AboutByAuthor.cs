using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class AboutByAuthor : ViewComponent
    {
        AboutManager aboutManager = new AboutManager();
        public IViewComponentResult Invoke(int id)
        {
            return View(aboutManager.GetAboutById(id));
        }
    }
}
