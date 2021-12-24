using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        [StringLength(200)]
        public string ProfileImg { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
