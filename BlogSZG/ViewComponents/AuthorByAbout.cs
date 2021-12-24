using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class AuthorByAbout : ViewComponent
    {
        AuthorManager authorManager = new AuthorManager();
        public IViewComponentResult Invoke(int id)
        {
            return View(authorManager.GetAuthorById(id));
        }
    }
}
