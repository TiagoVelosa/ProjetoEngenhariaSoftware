using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Models;


namespace Projeto.Data
{
    public class BDContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = projeto");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasBaseType<Person>();
            modelBuilder.Entity<Doctor>().HasBaseType<Person>();
            
            


        }

        public DbSet<Person> Persons { set; get; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<User> Users { get; set; }



    }
}