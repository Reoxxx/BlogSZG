using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using EntityLayer;

namespace BlogSZG.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager();

        [HttpPost]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        public ActionResult CreateComment(Comment comment)
        {
            cm.AddComment(comment);
            return RedirectToAction("Post","Blog",new { id = comment.BlogId });
        }
        public ActionResult CommentById(int id)
        {
            return View(cm.GetCommentById(id));
        }

        public ActionResult DeleteComment(int id)
        {
            cm.DeleteComment(id);
            return RedirectToAction("AdminBlogList", "Blog");
        }
    }
}
