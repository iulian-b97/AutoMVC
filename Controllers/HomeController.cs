using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMVC.Models;
using AutoMVC.Repository;

namespace AutoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly CarRepository _carRepository = null;

        public HomeController(ILogger<HomeController> logger, CarRepository carRepository)
        {
            _logger = logger;

            _carRepository = carRepository;
        }

        public async Task<ViewResult> Index()
        {
            var data = await _carRepository.GetAllCars();

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       /* public async Task<ViewResult> GetAllCars()
        {
            var data = await _carRepository.GetAllCars();

            return View(data);
        } */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
