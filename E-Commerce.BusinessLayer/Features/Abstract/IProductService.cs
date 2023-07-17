using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Features.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetPopularProducts();
        public Product TGetProductDetails(int id);
    }
}
