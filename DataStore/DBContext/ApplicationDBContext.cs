using DataStore.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataStore.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        private readonly string _connectionString = "Server=DESKTOP-I9UMVDV;Database=ConceptDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
