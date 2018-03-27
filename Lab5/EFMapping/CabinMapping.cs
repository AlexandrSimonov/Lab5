using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.EFMapping
{
    public class CabinMapping
    {
        public CabinMapping(EntityTypeBuilder<Cabin> entityBuilder)
        {
            entityBuilder.HasKey("Id");
            entityBuilder.ToTable("Cabins");

            entityBuilder.HasMany(p => p.Passengers).WithOne(c => c.Cabin).HasForeignKey(c => c.CabinId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
