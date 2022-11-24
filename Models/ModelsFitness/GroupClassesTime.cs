using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class GroupClassesTime
    {
        [Key]
        public int Id { get; set; }

        public int GroupClassesId { get; set; }

        public GroupClasses? GroupClasses { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}
