using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Abstract
{
    public interface IProductDAL:IGenericDAL<Product>
    {
        List<Product> GetPopularProducts();
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string category,int page, int pageSize);
        int GetCountByCategory(string category);
    }
}
