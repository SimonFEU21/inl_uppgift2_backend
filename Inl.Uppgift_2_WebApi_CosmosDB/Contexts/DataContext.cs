using Inl.Uppgift_2_WebApi_CosmosDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Inl.Uppgift_2_WebApi_CosmosDB.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToContainer("Products").HasPartitionKey(x => x.PartitionKey);
        }
    }
}
