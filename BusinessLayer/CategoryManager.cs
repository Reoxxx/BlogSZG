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

        public int AddCategory(Category c)
        {
            return repocategory.Insert(c);
        }

        public int UpdateCategory(Category c)
        {
            Category category = repocategory.Find(p => p.CategoryId == c.CategoryId);
            category.CategoryId = c.CategoryId;
            category.CategoryName = c.CategoryName;
            category.CategoryColor = c.CategoryColor;
            category.CategoryImg = c.CategoryImg;
            return repocategory.Update(category);
        }

        public int DeleteCategory(int id)
        {
            Category category = repocategory.Find(p => p.CategoryId == id);
            return repocategory.Delete(category);
        }
    }
}
