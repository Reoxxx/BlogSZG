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
        public ActionResult AdminMessageList()
        {
            return View(cm.GetAll().ToPagedList(1, 7));
        }
        public ActionResult DeleteMessage(int id)
        {
            cm.DeleteContact(id);
            return RedirectToAction("AdminMessageList", "Contact");
        }
        public ActionResult Message(int id)
        {
            return View(cm.GetMessage(id));
        }
    }
}
