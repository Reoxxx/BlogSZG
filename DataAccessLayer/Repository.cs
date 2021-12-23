using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    

    public class Repository<T> : IRepository<T> where T : class
    {

        BlogContext context = new BlogContext();
        DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
       
        }
        public List<T> List()
        {
            return _object.ToList();
            
        }

        int IRepository<T>.Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();
        }

        int IRepository<T>.Update(T p)
        {
            return context.SaveChanges();
        }

        int IRepository<T>.Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        T IRepository<T>.GetById(int id)
        {
            return _object.Find(id);
        }
    }
}
