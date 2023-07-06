using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.DbContexts;
using E_Commerce.DAL.Concrete.Repository;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Concrete.EF
{
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDAL(ECommerceDbContext context) : base(context)
        {
        }
    }
}
