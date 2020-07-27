using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMVC.Models;
using AutoMVC.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoMVC.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> AddNewAd(CarModel carModel)
        {
            int id = await _carRepository.AddNewCar(carModel);
            if(id > 0)  
            {
                return RedirectToAction(nameof(AddNewAd), new { isSuccess = true, bookId = id });
            }
            return View();
        }
    }
}
