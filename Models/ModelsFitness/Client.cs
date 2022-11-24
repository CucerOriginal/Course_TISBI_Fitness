using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsFitness
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string? SecondName { get; set; }

        public string? Name { get; set; }

        public string? MiddleName { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public DateOnly Birthday { get; set; }

        public DateOnly StartAbonement { get; set; }

        public DateOnly EndAbonement { get; set; }
    }
}
