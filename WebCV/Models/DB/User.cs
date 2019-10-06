using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [MaxLength(200)]
        public string WorkPosition { get; set; }

        [MaxLength(75)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string Website { get; set; }

        public int Age { get; set; }

        [MaxLength(250)]
        public string ShortDescription { get; set; }

        public DateTime DateBirdth { get; set; }
    }
}
