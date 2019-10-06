using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    [Table("Skills")]
    public class Skill : StatesRelation<User, SkillState>
    {
        [Key]
        public int SkillID { get; set; }

        [MaxLength(75)]
        public string Title { get; set; }

    }

    [Table("SkillsStates")]
    public class SkillState : BaseRelation<Skill>
    {
        [Key]
        public int SkillStateID { get; set; }

        public string Title { get; set; }
        public string Position { get; set; }
        public int Percent { get; set; }
    }
}
