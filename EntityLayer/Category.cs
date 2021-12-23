using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
