using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.DAL.Abstract;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Features.Concrete
{
    public class ProductService : IProductService
    {

        private readonly IProductDAL _productDAL;

        public ProductService(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TInsert(Product t)
        {
            _productDAL.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }

        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetList();
        }

        public List<Product> TGetPopularProducts()
        {
            return _productDAL.GetPopularProducts();
        }
    }
}
