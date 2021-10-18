using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public interface IGenericRepo<T>
    {
        T Add(T entity);
        IEnumerable<T> Get(int? id);
        //IEnumerable<T> GetByName(string name);
        IEnumerable<T> GetAll();
        T Update(T entity);
        T Delete(T entity);
        void SaveChanges();
    }
}
