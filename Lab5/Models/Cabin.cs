using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Cabin : BaseEntity
    {
        public int Number { get; set; }

        public int CountBeds { get; set; }

        public string Location { get; set; }

        public List<Passenger> Passengers { get; set; }
    }
}
