using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager authorManager = new AuthorManager();
        public IActionResult Index(int id)
        {
            return View(authorManager.GetAuthorById(id));
        }
    }
}
