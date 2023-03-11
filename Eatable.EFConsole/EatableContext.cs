using Microsoft.EntityFrameworkCore;
using Eatable.Data.General;
using Eatable.Data.Product;

namespace Eatable.EFConsole
{
    public class EatableContext : DbContext
    {
        private readonly string _connectionString;

        public EatableContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public EatableContext()
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Translation> Translation { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Store> Store { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>();
            modelBuilder.Entity<Address>();
            modelBuilder.Entity<ContactInformation>();
            modelBuilder.Entity<Store>();
        }
    }
        
}
