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

        // GETAll: MotorcycleController
        public ActionResult Index()
        {
            var getAll = _motorcycleRepoContext.GetAll();

            return View(getAll);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(int? id)
        {
            var search = _motorcycleRepoContext.Get(id);
            //ViewBag.SearchKey = search;
            return View(search);
        }


    }
}
