using E_Commerce.DAL.Concrete.DbContexts;
using E_Commerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_Commerce.DAL.Concrete.EF
{
    public static class SeedData
    {
        private static readonly IConfiguration _configuration;//!
        //development phase
        public static void Seed()
        {
            var context = new ECommerceDbContext(_configuration);//!

            if (context.Database.GetPendingMigrations().Count() == 0)//If there is no pending migration, reflect the test data to the database
            {
                if (context.Categories.Count() == 0)//If the database does not already have category data
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)//If the database does not already have category data
                {
                    context.Products.AddRange(Products);
                    context.AddRange(CategoryProduct);
                }
                context.SaveChanges();
            }
        }

        //Features
        private static Category[] Categories =
        {
            new Category() { Name="Phone"},
            new Category() { Name="Computer"},
            new Category() { Name="Electronics"},
        };

        private static Product[] Products =
{
            new Product() { Name="iPhone 14 Pro", Price=15000, ImageUrl="a1.jpg",Description="Production date:2023"},
            new Product() { Name="iPhone 14 Pro Max", Price=16000, ImageUrl="a2.jpg",Description="Production date:2022"},
            new Product() { Name="iPhone 11 Pro", Price=13000, ImageUrl="a3.jpg",Description="Production date:2021"},
            new Product() { Name="iPhone 11 Pro Max", Price=14000, ImageUrl="a4.jpg",Description="Production date:2020"},
        };

        private static CategoryProduct[] CategoryProduct =
        {
            new CategoryProduct (){ Product=Products[0],Category=Categories[0]},
            new CategoryProduct (){ Product=Products[0],Category=Categories[2]},
            new CategoryProduct (){ Product=Products[1],Category=Categories[0]},
            new CategoryProduct (){ Product=Products[1],Category=Categories[2]},
            new CategoryProduct (){ Product=Products[2],Category=Categories[0]},
            new CategoryProduct (){ Product=Products[2],Category=Categories[2]},
            new CategoryProduct (){ Product=Products[3],Category=Categories[0]},
            new CategoryProduct (){ Product=Products[3],Category=Categories[2]},
        };
    }
}
