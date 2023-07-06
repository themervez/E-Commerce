using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.EF;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Features.Concrete
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TInsert(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.GetList();
        }
    }
}
