using E_Commerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Concrete.DbContexts
{
    public class ECommerceDbContext:DbContext
    {
        private IConfiguration _configuration;

        public ECommerceDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = _configuration.GetConnectionString("ConStr");//From appsettings.json file
            //base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));

            //ArgumentNullException: Value cannot be null. Parameter name: connectionString error!
            optionsBuilder.UseSqlServer("Server =.;Database=ECommerceDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProduct>()
                .HasKey(b => new { b.CategoryId, b.ProductId });
        }
    }
}
