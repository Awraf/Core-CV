using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationState> EducationsStates { get; set; }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExperienceState> ExperiencesStates { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillState> SkillsStates { get; set; }


    }
}
