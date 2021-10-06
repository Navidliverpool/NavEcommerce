using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.infrastructures.DbContextInstances;

namespace NavEcommerce.infrastructures.Repositories
{
    public class GenericRepo<T> where T : class , IGenericRepo<T>
    {
        private NavEcommerceDbContext _context;
        public GenericRepo(NavEcommerceDbContext context)
        {
           _context = context;
        }

        public virtual T Add(T entity)
        {
            if (entity == null)
            {
                 throw new ArgumentNullException();
            }

            return _context.Add(entity).Entity;
        }

        public virtual T Get(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            return _context.Find<T>(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            return _context.Update(entity).Entity;
        }

        public virtual T Delete(T entity)
        {
            return _context.Remove(entity).Entity;
             
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
