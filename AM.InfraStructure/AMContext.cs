using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.InfraStructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AM.InfraStructure
{
    public class AMContext:DbContext
    {
        //1-DBSET
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        //2-Chaine de config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
                Initial Catalog=AirportManagementDB;Integrated Security=true");
                    base.OnConfiguring(optionsBuilder);
        }
        //Model Creation
        //Fluent API 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //1ere methode (Avec Classe de configuration)
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //2eme methode (Sans Classe de configuration)
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
            //modelBuilder.Entity<Plane>().ToTable("MyPlanes");
            //modelBuilder.Entity<Plane>().Property(p => p.Capacity).HasColumnName("PlaneCapacity");
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
        }
        //4- Configure Convention
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateTime>().HaveColumnType("DateTime");
            //configurationBuilder.Properties<String>().HaveMaxLength(100);

        }
    }
}
