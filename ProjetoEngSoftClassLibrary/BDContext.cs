using System;
using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftClassLibrary.Models;

namespace ProjetoEngSoftClassLibrary
{
    public class BDcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EngSoftware");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Prescription>().Property(e => e.ID).ValueGeneratedOnAdd();


        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }
    }
}
