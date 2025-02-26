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
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            //[Key]
            builder.HasKey(p => p.PlaneId);
            //Rename table
            builder.ToTable("MyPlanes");
            //Change column name Capacity -> PlaneCapacity
            builder.Property(c => c.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
