using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        public string? SecondName { get; set; }

        public string? Name { get; set; }

        public string? MiddleName { get; set; }

        public string? PhoneNumber { get; set; }

        public int Cost { get; set; }
    }
}
