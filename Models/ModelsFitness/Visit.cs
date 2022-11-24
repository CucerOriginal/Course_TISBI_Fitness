using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }

        public DateTime VisitStart { get; set; }

        public DateTime VisitEnd { get; set; }
    }
}
