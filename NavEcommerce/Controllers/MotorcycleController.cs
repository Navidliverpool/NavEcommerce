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
using NavEcommerce.ViewModels;

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
            var queryGetAll = _motorcycleRepoContext.GetAll();

            return View(queryGetAll);
        }

        public ActionResult SearchById(int id)
        {
            var querySearchById = _motorcycleRepoContext.Get(id);
            return View(querySearchById);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Motorcycle motorcycle)
        {
            _motorcycleRepoContext.Delete(motorcycle);
            _motorcycleRepoContext.SaveChanges();
            return RedirectToAction("Index");
        }


        //public ActionResult SearchByName(string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //    {
        //        return BadRequest("The input is null.");
        //    }

        //    var queryName = _motorcycleRepoContext.GetByName(id);
        //    return View(queryName);
        //}



        //public ActionResult Search(LoadMotorcycles loadMotorcycles)
        //{
        //    var motor = _motorcycleRepoContext.
        //        Find(m => m.Model == loadMotorcycles.motorcycleModel.Model).
        //        FirstOrDefault();
        //    if(motor != null)
        //    {
        //        //motor.Price == loadMotorcycles.motorcycleModel.Price;

        //    }
        //    return View();
        //}



        //[HttpPost]
        //public ActionResult Search(int? id)
        //{
        //    //var search = _motorcycleRepoContext.Get(id);
        //    ////ViewBag.SearchKey = search;
        //    //return View(search.Model);

        //}


    }
}
