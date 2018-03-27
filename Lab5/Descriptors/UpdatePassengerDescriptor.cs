using System;

namespace Lab5.Descriptors
{
    public class UpdatePassengerDescriptor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CabinId { get; set; }
    }
}
