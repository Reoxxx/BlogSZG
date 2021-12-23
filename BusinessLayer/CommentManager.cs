using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        public List<Comment> GetAll()
        {
            return repocomment.List();
        }

        public List<Comment> GetCommentListByBlog(int id)
        {
            return repocomment.List().Where(p => p.BlogId == id).ToList();
        }
    }
}
