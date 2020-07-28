using AutoMVC.Data;
using AutoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMVC.Repository
{
    public class CarRepository
    {
        private readonly AutoStoreContext _context = null;
        public bool stat;

        public CarRepository(AutoStoreContext context)
        {
            _context = context;
            stat = true;
        }

        public async Task<int> AddNewCar(CarModel model)
        {
            var newCar = new CarModel()
            {
                ID = model.ID,
                nameAd = model.nameAd,
                Country = model.Country,
                City = model.City,
                Address = model.Address,
                Mobile = model.Mobile,
                Mark = model.Mark,
                Model = model.Model,
                Fuel = model.Fuel,
                Body = model.Body,
                Year = model.Year,
                Km = model.Km,
                Price = model.Price,
                Describe = model.Describe,
                ImageFileUrl = model.ImageFileUrl
            };  


            await _context.Cars.AddAsync(newCar);
            await _context.SaveChangesAsync();

            return newCar.ID;
        }

        public async Task<List<CarModel>> GetAllCars()
        {
            var cars = new List<CarModel>();
            var allcars = await _context.Cars.ToListAsync();
            if (allcars?.Any() == true)
            {
                foreach (var car in allcars)
                {
                    cars.Add(new CarModel
                    { 
                        nameAd = car.nameAd,
                        Country = car.Country,
                        City = car.City,
                        Address = car.Address,
                        Mobile = car.Mobile,
                        Mark = car.Mark,
                        Model = car.Model,
                        Fuel = car.Fuel,
                        Body = car.Body,
                        Year = car.Year,
                        Km = car.Km,
                        Price = car.Price,
                        Describe = car.Describe,
                        ImageFileUrl = car.ImageFileUrl
                    });
                }
            }
            return cars;
        }
    }
}
