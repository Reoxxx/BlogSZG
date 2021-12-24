using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [StringLength(50)]
        public string CommentSubject { get; set; }
        [StringLength(200)]
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogId { get; set; }
        public Blog Blogs { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
