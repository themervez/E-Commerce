using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.DbContexts;
using E_Commerce.DAL.Concrete.Repository;
using E_Commerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Concrete.EF
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        private readonly ECommerceDbContext _context;

        public EFProductDAL(ECommerceDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetPopularProducts()
        {
            var values = _context.Products.Where(x => x.Price > 14000).ToList();
            return values;
        }
        public Product GetProductDetails(int id)
        {
            return _context.Products.Where(x => x.ID == id)
                                    .Include(x => x.CategoryProducts)//for eager loading
                                    .ThenInclude(x => x.Category)//for eager loading
                                    .FirstOrDefault();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            var products = _context.Products.AsQueryable();//for controlling the query:AsQueryable
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                         .Include(x => x.CategoryProducts)
                         .ThenInclude(x => x.Category)
                         .Where(x => x.CategoryProducts.Any(x => x.Category.Name.ToLower() == category.ToLower()));
            }
            return products.ToList();
        }
    }
}
