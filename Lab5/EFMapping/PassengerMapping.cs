using System.Runtime.InteropServices.ComTypes;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.EFMapping
{
    public class PassengerMapping
    {
        public PassengerMapping(EntityTypeBuilder<Passenger> entityBuilder)
        {
            entityBuilder.HasKey("Id");
            entityBuilder.ToTable("Passengers");
        }
    }
}
