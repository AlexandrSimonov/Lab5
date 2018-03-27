using System;

namespace Lab5.Models
{
    public class Passenger : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CabinId { get; set; }
        public Cabin Cabin { get; set; }
    }
}
