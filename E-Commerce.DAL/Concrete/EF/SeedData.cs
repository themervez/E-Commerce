using E_Commerce.DAL.Concrete.DbContexts;
using E_Commerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_Commerce.DAL.Concrete.EF
{
    public static class SeedData
    {
        //development phase
        public static void Seed()
        {
            var context = new ECommerceDbContext();

            if (context.Database.GetPendingMigrations().Count() == 0)//If there is no pending migration, reflect the test data to the database
            {
                if (context.Categories.Count() == 0)//If the database does not already have category data
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)//If the database does not already have category data
                {
                    context.Products.AddRange(Products);
                }

                context.SaveChanges();
            }
        }

        //Features
        private static Category[] Categories =
        {
            new Category() { Name="Phone"},
            new Category() { Name="Computer"},
        };

        private static Product[] Products =
{
            new Product() { Name="iPhone 14 Pro", Price=15000, ImageUrl="a1.jpg"},
            new Product() { Name="iPhone 14 Pro Max", Price=16000, ImageUrl="a2.jpg"},
            new Product() { Name="iPhone 11 Pro", Price=16000, ImageUrl="a3.jpg"},
            new Product() { Name="iPhone 11 Pro Max", Price=16000, ImageUrl="a4.jpg"},
        };
    }
}
