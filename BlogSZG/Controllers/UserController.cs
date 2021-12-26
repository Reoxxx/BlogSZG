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
    public class UserController : Controller
    {
        UserManager um = new UserManager();
        public IActionResult Index(int id)
        {
            um.GetUserById(id);
            return View(id);
        }

        public ActionResult AdminUserList()
        {
            return View(um.GetAll().ToPagedList(1, 7));
        }

        public ActionResult DeleteUser(int id)
        {
            um.DeleteUser(id);
            return RedirectToAction("AdminUserList", "User");
        }

        public ActionResult UpdateUser(int id)
        {
            
            return View(um.GetUserById(id));
        }
        [HttpPost]
        public ActionResult _UpdateUser(User user)
        {
            um.UpdateUser(user);
            return RedirectToAction("AdminUserList","User");
        }
    }
}
