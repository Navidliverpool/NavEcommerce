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
        private readonly IDataCombiner _context;
        private readonly IGenericRepo<Motorcycle> _motorcycleRepoContext;
        public MotorcycleController(IGenericRepo<Motorcycle> motorcycleRepoContext)
        {
            _motorcycleRepoContext = motorcycleRepoContext;
        }

        // GETAll: MotorcycleController
        public ActionResult Index()
        {
            var queryGetAll = _motorcycleRepoContext.GetAll();
            return View(queryGetAll);
        }

        //public ActionResult SearchById()
        //{
        //    return View();
        //}

        //[HttpPost]
        public ActionResult SearchById(int id)
        {
            var querySearchById = _motorcycleRepoContext.GetItemForSearchById(id);
            return View(querySearchById);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, Motorcycle motorcycle)
        {
            var GetMotorcycleDeletion = _motorcycleRepoContext.Get(id);
            _motorcycleRepoContext.Delete(GetMotorcycleDeletion);
            _motorcycleRepoContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
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



    }
}
