using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.Models;

namespace NavEcommerce.infrastructures.Repositories
{
    //In error ro gerefte bodam: The type 'type1' cannot be used as type parameter 'T' in the generic type or method '<name>'. There is no implicit reference conversion from 'type1' to 'type2'.
    //When a constraint is applied to a generic type parameter, an implicit identity or reference conversion must exist from the concrete argument to the type of the constraint.
    //Hala chejuri hal shod moshkel: oonja ke neveshtam where T : class ro ghabl az IGenericRepo<T> neveshte budam dar hali ke bayad badesh neveshe mishod.
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected NavEcommerceDbContext _context;
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

        public virtual IEnumerable<T> Get(int? id)
        {
            return _context.Find<IEnumerable<T>>(id);
        }

        //public virtual IEnumerable<T> GetByName(string name)
        //{
        //    return _context.Find<IEnumerable<T>>(name);
        //}

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
