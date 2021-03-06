using Microsoft.EntityFrameworkCore;

namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class BDContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EngSoftware");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Person>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Prescription>().Property(e => e.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Prescription>().HasOne(e => e.Pacient).WithMany(e => e.Prescriptions);
            modelBuilder.Entity<Prescription>().HasOne(e => e.Doctor).WithMany(e => e.Prescriptions);


        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }


    }
}