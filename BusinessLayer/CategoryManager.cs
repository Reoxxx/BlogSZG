using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }

        public Category GetCategoryById(int id)
        {
            Category category = repocategory.List().Where(p => p.CategoryId == id).FirstOrDefault();
            return category;

        }
    }
}
