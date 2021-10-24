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
        //private readonly IDataCombiner _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepo<Motorcycle> _motorcycleRepoContext;
        public MotorcycleController(IGenericRepo<Motorcycle> motorcycleRepoContext,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        [HttpPost]
        public ActionResult Create(LoadMotorcycles loadMotorcycles)
        {
            var queryAddMotorcycle = _unitOfWork.MotorcycleRepository
                .Find(m => m.MotorcycleId == loadMotorcycles.motorcycleModel.MotorcycleId)
                .FirstOrDefault();

            queryAddMotorcycle.Model = loadMotorcycles.motorcycleModel.Model;
            queryAddMotorcycle.Price = loadMotorcycles.motorcycleModel.Price;
            queryAddMotorcycle.Brand = loadMotorcycles.motorcycleModel.Brand;

            _unitOfWork.MotorcycleRepository.Update(queryAddMotorcycle);

            _unitOfWork.MotorcycleRepository.SaveChanges();

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
