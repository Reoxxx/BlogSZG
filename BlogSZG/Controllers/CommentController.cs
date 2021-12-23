using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;

namespace BlogSZG.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager();
        public ActionResult CommentList(int id)
        {
            var commentList = cm.GetCommentListByBlog(id);
            return View(commentList);
        }


        public PartialViewResult CreateComment()
        {
            return PartialView();
        }
    }
}
