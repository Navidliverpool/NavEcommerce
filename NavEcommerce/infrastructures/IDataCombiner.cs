using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public interface IDataCombiner
    {
        IQueryable<Motorcycle> CombineMotorBrandData();
    }
}
