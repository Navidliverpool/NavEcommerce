using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.Models;
using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.infrastructures.Repositories;

namespace NavEcommerce.Controllers
{
    public class MotorcycleController : Controller
    {
        //private readonly NavEcommerceDbContext _context;
        private readonly IDataCombiner _context;
        private readonly IGenericRepo<Motorcycle> _context2;
        public MotorcycleController(IDataCombiner context,
            IGenericRepo<Motorcycle> context2)
        {
            //_unitOfWork = unitOfWork;
            _context = context;
            _context2 = context2;
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {
            //var data = new DataCombiner();

            //var first = _context.CombineMotorBrandData();

            var second = _context2.GetAll();

            //var queryMotor = from a in _context.Motorcycles
            //                 join b in _context.Brands
            //                 on a.Brand.BrandId equals b.BrandId
            //                 select new Motorcycle
            //                 {
            //                     MotorcycleId = a.MotorcycleId,
            //                     Model = a.Model,
            //                     Price = a.Price,
            //                     Brand = new Brand
            //                     {
            //                         BrandId = b.BrandId,
            //                         Name = b.Name
            //                     }
            //                 };



            return View(second);
        }
    }
}
