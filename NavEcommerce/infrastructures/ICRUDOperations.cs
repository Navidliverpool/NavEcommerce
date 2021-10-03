using NavEcommerce.Models.MotorcyclesFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public interface ICRUDOperations<T>
    {
        void Add(T t);
        void Remove(int id);

    }
}
