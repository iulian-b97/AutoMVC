using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMVC.Models;
using AutoMVC.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AutoMVC.Controllers
{
    [Authorize]
    public class AddNewAdController : Controller
    {
        private readonly CarRepository _carRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AddNewAdController(CarRepository carRepository, IWebHostEnvironment webHostEnvironment)
        {
            _carRepository = carRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public ViewResult AddNewAd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAd(CarModel carModel)
        {
            if(ModelState.IsValid)
            { 
                if(carModel.ImageFile != null)
                {
                    string folder = "cars/cover";
                    folder += Guid.NewGuid().ToString() +"_"+ carModel.ImageFile.FileName;
                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    carModel.ImageFileUrl = folder;

                    await carModel.ImageFile.CopyToAsync(new FileStream(serverFolder, FileMode.Create)); 
                }

                int id = await _carRepository.AddNewCar(carModel);
                if (id > 0)  
                {
                    return RedirectToAction(nameof(AddNewAd), new { isSuccess = true, bookId = id });
                }
            }
            return View();
        }
    }
}
