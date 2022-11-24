using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class TrainerVisitRegistration
    {
        [Key]
        public int Id { get; set; }

        public int AbonementId { get; set; }

        public int TrainerId { get; set; }

        public Trainer? Trainer { get; set; }

        public DateTime VisitStart { get; set; }

        public DateTime VisitEnd { get; set; }
    }
}
