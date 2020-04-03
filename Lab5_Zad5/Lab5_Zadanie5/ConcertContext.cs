using Lab5_Zadanie5.Configurations;
using Lab5_Zadanie5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5
{
    public class ConcertContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TV2A7L8\\SQL;Initial Catalog = Concert; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Band>()
            //    .HasOne(x => x.Address)
            //    .WithOne(x => x.Band)
            //    .HasPrincipalKey<Band>(x => x.ID)
            //    .HasForeignKey<Address>(x => x.ID);
            //modelBuilder.Entity<Address>()
            //    .HasKey(x => x.ID);



            //modelBuilder.ApplyConfiguration(new BandConfiguration());
            //modelBuilder.ApplyConfiguration(new CityConfiguration());
            //modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
