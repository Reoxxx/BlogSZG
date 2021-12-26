using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }

        public Author GetAuthorById(int id)
        {
            Author author = repoauthor.List().Where(p => p.AuthorId == id).FirstOrDefault();
            return author;
        }
        public int DeleteAuthor(int id)
        {
            Author Author = repoauthor.Find(p => p.AuthorId == id);
            return repoauthor.Delete(Author);
        }

        public int UpdateAuthor(Author u)
        {
            Author Author = repoauthor.Find(p => p.AuthorId == u.AuthorId);
            Author.Name = u.Name;
            Author.Surname = u.Surname;
            Author.AuthorImg = u.AuthorImg;
            return repoauthor.Update(Author);

        }
    }
}
