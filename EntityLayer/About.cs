using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutContent { get; set; }
        [StringLength(300)]
        public string AboutImg { get; set; }
        public string AboutContent1 { get; set; }
        public string AboutContent2 { get; set; }
        [StringLength(150)]
        public string AboutShort { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
