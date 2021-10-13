using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.Models;
using NavEcommerce.infrastructures.DbContextInstances;

namespace NavEcommerce.Controllers
{
    public class MotorcycleController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly NavEcommerceDbContext _context;
        public MotorcycleController(NavEcommerceDbContext context)
        {
            //_unitOfWork = unitOfWork;
            _context = context;
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {

            var queryMotor = from a in _context.Motorcycles
                             join b in _context.Brands
                             on a.Brand.BrandId equals b.BrandId
                             select new Motorcycle
                             {
                                  MotorcycleId = a.MotorcycleId,
                                  Model = a.Model,
                                  Price = a.Price,
                                  Brand = new Brand
                                  {
                                      BrandId = b.BrandId,
                                      Name = b.Name
                                  }
                             };

            return View(queryMotor);
        }


    }
}
