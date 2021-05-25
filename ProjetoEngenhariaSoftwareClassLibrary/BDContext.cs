using Microsoft.EntityFrameworkCore;


namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class BDContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = projeto");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.Entity<Client>().HasBaseType<Person>();
                modelBuilder.Entity<Doctor>().HasBaseType<Person>();
                modelBuilder.Entity<Person>().Property(e => e.ID).ValueGeneratedOnAdd();

            }

            public DbSet<Person> Persons { set; get; }

            public DbSet<Doctor> Doctors { get; set; }

            public DbSet<Client> Users { get; set; }
        }
}