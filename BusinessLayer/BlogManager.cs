using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BlogManager
    {

        Repository<Blog> repoblog = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repoblog.List();
        }

        public Blog GetBlogById(int id)
        {
            Blog post = repoblog.List().Where(p => p.BlogId == id).FirstOrDefault();
            return post;
        }
    }
}
