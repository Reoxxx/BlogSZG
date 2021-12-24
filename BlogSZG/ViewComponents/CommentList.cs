using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSZG.ViewComponents
{
    public class CommentList: ViewComponent
    {
        CommentManager cm = new CommentManager();
        public IViewComponentResult Invoke(int id)
        {
            var commentList = cm.GetCommentListByBlog(id);
            return View(commentList);
        }
    }
}
