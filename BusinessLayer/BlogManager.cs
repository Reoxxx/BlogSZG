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

        public List<Blog> GetBlogsByCategory(int id)
        {
            return repoblog.List().Where(p => p.CategoryId == id).ToList();
        }
        public List<Blog> GetBlogsByAuthor(int id)
        {
            return repoblog.List().Where(p => p.AuthorId == id).ToList();
        }

        public int AddBlog(Blog b)
        {
            return repoblog.Insert(b);
        }

        public int DeleteBlog(int id)
        {
            Blog blog = repoblog.Find(p => p.BlogId == id);
            return repoblog.Delete(blog);
        }

        public int UpdateBlog(Blog b)
        {
            Blog blog=repoblog.Find(p => p.BlogId == b.BlogId);
            blog.BlogTitle = b.BlogTitle;
            blog.BlogContent = b.BlogContent;
            blog.BlogImg = b.BlogImg;
            blog.CategoryId = b.CategoryId;
            blog.BlogDate = b.BlogDate;

            return repoblog.Update(blog);
        }
    }
}
