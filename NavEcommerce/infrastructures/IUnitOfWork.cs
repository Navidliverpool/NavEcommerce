using NavEcommerce.infrastructures.Repositories;
using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public interface IUnitOfWork
    {
        IGenericRepo<Motorcycle> MotorcycleRepository { get; }
        IGenericRepo<Brand> BrandRepository { get; }
    }
}
