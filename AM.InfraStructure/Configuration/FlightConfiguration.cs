using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.InfraStructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.Passengers)
                .WithMany(f => f.Flights)
                .UsingEntity(t => t.ToTable("FP")); //rename table associative and its only access is from the association manytomany
            builder.HasOne(f => f.Plane)
                .WithMany(f => f.Flights)
                .HasForeignKey(fk => fk.PlaneFk)// [ForeignKey]
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
