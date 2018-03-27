using Lab5.EFMapping;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CabinMapping(modelBuilder.Entity<Cabin>());
            new PassengerMapping(modelBuilder.Entity<Passenger>());
        }
    }
}
