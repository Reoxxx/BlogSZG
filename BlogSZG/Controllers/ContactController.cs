using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult SendMessage(Contact contact) 
        {
            cm.AddContact(contact);
            return RedirectToAction("Index","Contact");
        }
    }
}
