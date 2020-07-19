using AutoMVC.Data;
using AutoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMVC.Repository
{
    public class CarRepository
    {
        private readonly AutoStoreContext _context = null;

        public CarRepository(AutoStoreContext context)
        {
            _context = context;
        }

        public int AddNewCar(CarModel model)
        {
            var newCar = new Cars()
            {
                Id = model.Id,
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
                Describe = model.Describe
            };


            _context.Cars.Add(newCar);
            _context.SaveChanges();

            return newCar.Id;
        }
    }
}
