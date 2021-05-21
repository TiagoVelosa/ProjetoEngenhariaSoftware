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
            modelBuilder.Entity<Utente>()
                .Property(e => e.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Utente>()
                .HasKey(e => e.ID);
        }

        public DbSet<Utente> Utentes { set; get; }
    }
}