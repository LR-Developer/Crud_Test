using CrudTest.Models;
using System.Data.Entity;

namespace CrudTest.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}