using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.Models;

namespace NavEcommerce.Controllers
{
    public class MotorcycleController : Controller
    {
        private readonly IGenericRepo<Motorcycle> _motorcycleContext;
        public MotorcycleController(IGenericRepo<Motorcycle> motorcycleContext)
        {
            _motorcycleContext = motorcycleContext;
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {
            var quer = _motorcycleContext.GetAll().ToList();

            return View(quer);
        }

    }
}
