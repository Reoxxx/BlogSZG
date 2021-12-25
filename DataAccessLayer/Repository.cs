using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    

    public class Repository<T> : IRepository<T> where T : class
    {

        BlogContext context = new BlogContext();
        DbSet<T> _object;
        DbSet<EntityLayer.Comment> comments;
        public Repository()
        {
            _object = context.Set<T>();
       
        }
        public List<T> List()
        {
            return _object.ToList();
            
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();
        }

        public int Update(T p)
        {
            return context.SaveChanges();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _object.Where(where).ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }
    }
}
