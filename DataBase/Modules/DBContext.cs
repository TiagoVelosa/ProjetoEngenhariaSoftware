using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Modules
{
    class DBContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClincaDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Prescription>().HasOne(e => e.Client).WithMany(e => e.PrescriptionsList).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Prescription>().HasOne(e => e.Doctor).WithMany(e => e.PrescriptionsList).OnDelete(DeleteBehavior.ClientCascade);

        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
    }
}
