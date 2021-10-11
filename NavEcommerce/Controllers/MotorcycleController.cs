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
        private readonly IGenericRepo<Motorcycle> _motorcycleContext;
        private readonly IGenericRepo<Brand> _brandContext;
      
        public MotorcycleController(IGenericRepo<Motorcycle> motorcycleContext, 
            IGenericRepo<Brand> brandContext)
        {
            _motorcycleContext = motorcycleContext;
            _brandContext = brandContext;
           
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {
            var quer = _brandContext.GetAll().ToList();
           

            return View(quer);
        }


    }
}
