using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength(100)]
        public string BlogTitle { get; set; }
        [StringLength(250)]
        public string BlogImg { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
