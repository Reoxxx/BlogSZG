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

        public int AddComment(Comment c)
        {
            if (c.CommentSubject.Length <= 2 || c.CommentContent.Length > 200)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }

        public int GetCommentCount(int id)
        {
            int count = repocomment.List().Count(p => p.BlogId == id);
            return count;
        }

        public Comment GetCommentById(int id)
        {
            Comment c = repocomment.Find(p => p.CommentId == id);
            return c;
        }

        public int DeleteComment(int id)
        {

            return repocomment.Delete(repocomment.Find(p => p.CommentId == id));
        }
    }
}
