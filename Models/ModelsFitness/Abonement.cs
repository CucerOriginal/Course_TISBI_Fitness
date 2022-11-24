using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class Abonement
    {
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }

        public Client? Client { get; set; }

        public int TariffId { get; set; }

        public IList<TrainerVisitRegistration>? TrainerVisitRegistrations { get; set; }

        public IList<VisitRegistration>? VisitRegistration { get; set; }
    }
}
