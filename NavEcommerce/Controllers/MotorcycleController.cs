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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepo<Motorcycle> _motorcycleRepoContext;
        public MotorcycleController(IGenericRepo<Motorcycle> motorcycleRepoContext,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _motorcycleRepoContext = motorcycleRepoContext;
        }

        public ActionResult Index()
        {
            var queryGetAll = _motorcycleRepoContext.GetAll();
            return View(queryGetAll);
        }

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
            if(loadMotorcycles == null)
              throw new ArgumentNullException();
           
            var motorcycle = _unitOfWork.MotorcycleRepository
                .Find(m => m.MotorcycleId == loadMotorcycles.motorcycleModel.MotorcycleId)
                .FirstOrDefault();

            if(motorcycle != null)
            {
                motorcycle.Model = loadMotorcycles.motorcycleModel.Model;
                motorcycle.Price = loadMotorcycles.motorcycleModel.Price;
                motorcycle.Brand = loadMotorcycles.motorcycleModel.Brand;

                _unitOfWork.MotorcycleRepository.Update(motorcycle);
            }
            else
            {
                motorcycle = new Motorcycle
                {
                    MotorcycleId = loadMotorcycles.motorcycleModel.MotorcycleId,
                    Model = loadMotorcycles.motorcycleModel.Model,
                    Price = loadMotorcycles.motorcycleModel.Price,
                    Brand = loadMotorcycles.motorcycleModel.Brand
                };
            }
         
            _unitOfWork.MotorcycleRepository.SaveChanges();

            //_motorcycleRepoContext.Add(loadMotorcycles);
            //_motorcycleRepoContext.SaveChanges();

            return View("Index");
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
