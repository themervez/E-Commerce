using E_Commerce.DAL.Abstract;
using E_Commerce.DAL.Concrete.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private ECommerceDbContext _context;
        public GenericRepository(ECommerceDbContext context)
        {
            _context = context;
        }
        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }


    }
}
