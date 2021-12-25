using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class UserById : ViewComponent
    {
        UserManager um = new UserManager();
        public IViewComponentResult Invoke(int id)
        {
            User user = um.GetUserById(id);
            return View(user);
        }
    }
}
