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
        private readonly IGenericRepo<Motorcycle> _motorcycleRepoContext;
        public MotorcycleController(IDataCombiner context,
            IGenericRepo<Motorcycle> motorcycleRepoContext)
        {
            //_unitOfWork = unitOfWork;
            _context = context;
            _motorcycleRepoContext = motorcycleRepoContext;
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {
            var second = _motorcycleRepoContext.GetAll();

            return View(second);
        }
    }
}
