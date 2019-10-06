using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCV.Models
{
    public abstract class BaseRelation<T> where T: class
    {
        public virtual int BaseID { get; set; }

        [ForeignKey("BaseID")]
        public virtual T Base { get; set; }

    }
    public abstract class StatesRelation<T, TR> : BaseRelation<T> where T: class where TR: class
    {
        public StatesRelation()
        {
            States = new List<TR>();
        }

        public virtual ICollection<TR> States { get; set; }
    }

    public abstract class StateRelation<T>: BaseRelation<T> where T: class
    {
        [MaxLength(100)]
        public string Title { get; set; }
        public string Position { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public DateTime End { get; set; }
        public DateTime Start { get; set; }
    }
}
