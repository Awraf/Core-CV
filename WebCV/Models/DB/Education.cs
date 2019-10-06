using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    [Table("Educations")]
    public class Education: StatesRelation<User, EducationState>
    {
        [Key]
        public int EducationID { get; set; }
    }

    [Table("EducationsStates")]
    public class EducationState : StateRelation<Education>
    {
        [Key]
        public int EducationStatesID { get; set; }
    }
}
