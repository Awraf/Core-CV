using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    [Table("Contacts")]
    public class Contact: BaseRelation<User>
    {
        [Key]
        public int ContactID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Url { get; set; }
    }
}
