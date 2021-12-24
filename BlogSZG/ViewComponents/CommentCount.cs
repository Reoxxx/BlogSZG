using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class CommentCount : ViewComponent
    {
        CommentManager cm = new CommentManager();
        public IViewComponentResult Invoke(int id)
        {
            return View(cm.GetCommentCount(id));
        }
    }
}
