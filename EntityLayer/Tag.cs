using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tag
    {
        [Key]
        public int BlogId { get; set; }
        public string name { get; set; }
    }
}
