using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class VisitRegistration
    {
        [Key]
        public int Id { get; set; }

        public int AbonementId { get; set; }

        public int VisitId { get; set; }

        public Visit? Visit { get; set; }
    }
}
