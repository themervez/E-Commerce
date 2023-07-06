using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.BusinessLayer.Features.Concrete;
using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Configuration.DIContainer
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDAL, EFProductDAL>();

            services.AddScoped<ICategoryDAL, EFCategoryDAL>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
