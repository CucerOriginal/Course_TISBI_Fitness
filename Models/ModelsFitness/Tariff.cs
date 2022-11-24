using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class Tariff
    {
        [Key]
        public int Id { get; set; }

        public string? TariffName { get; set; }

        public int Cost { get; set; }

        public string? TariffActionTime { get; set; }

        public string? Description { get; set; }
    }
}
