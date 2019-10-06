using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    [Table("Experiences")]
    public class Experience: StatesRelation<User, ExperienceState>
    {
        [Key]
        public int ExperienceID { get; set; }
    }

    [Table("ExperiencesStates")]
    public class ExperienceState : StateRelation<Experience>
    {
        [Key]
        public int ExperienceStateID { get; set; }
    }
}
