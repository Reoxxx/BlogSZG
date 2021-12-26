using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public string AuthorImg { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }

    }
}
