﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public interface IGenericRepo<T>
    {
        T Add(T entity);
        T Get(T id);
        IEnumerable<T> GetAll();
        T Update(T entity);
        T Delete(T entity);
        void SaveChanges();
    }
}