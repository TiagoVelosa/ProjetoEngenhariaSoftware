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
            modelBuilder.Entity<Prescription>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<TherapySession>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Prescription>().HasOne(e => e.Client).WithMany(e => e.PrescriptionsList).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Prescription>().HasOne(e => e.Doctor).WithMany(e => e.PrescriptionsList).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Item>().HasOne(e => e.Prescription).WithMany(e => e.Items).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Treatment>().HasOne(e => e.Session).WithMany(e => e.Treatments).OnDelete(DeleteBehavior.ClientCascade);

        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Prescription> Prescricoes { get; set; }

        public DbSet<Medicamento> Meds { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<TherapySession> TherapySessions { get; set; }

    }
}
