using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.BusinessLayer.Features.Concrete;
using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.EF;
using Microsoft.Extensions.DependencyInjection;

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
