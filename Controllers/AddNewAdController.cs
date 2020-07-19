using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMVC.Models;
using AutoMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AutoMVC.Controllers
{
    public class AddNewAdController : Controller
    {
        private readonly CarRepository _carRepository = null;

        public AddNewAdController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public ViewResult AddNewAd()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewAd(CarModel carModel)
        {
            _carRepository.AddNewCar(carModel);
            return View();
        }
    }
}
