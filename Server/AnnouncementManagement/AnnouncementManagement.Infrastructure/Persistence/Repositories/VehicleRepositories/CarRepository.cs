using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Infrastructure.Persistence.Repositories.VehicleRepositories
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        private readonly IMapper _mapper;

        public CarRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Mark)
               .ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(string carId)
        {
            return await FindByCondition(x => x.Id.Equals(carId))
                .FirstOrDefaultAsync();
        }

        public async Task<CarResponse> CreateCar(CarRequest request)
        {

            //Car car = _mapper.Map<Car>(request);
            //car.Id = Guid.NewGuid().ToString();

             Car car = new Car
             {
                 Id = Guid.NewGuid().ToString(),
                 Mark = request.Mark,
                 Model = request.Model,
                 Year = request.Year,
                 Body = request.Body,
                 ColorBody = request.ColorBody,
                 Km = request.Km,
                 HP = request.HP,
                 FuelType = request.FuelType,
                 Cm3 = request.Cm3,
                 Gearbox = request.Gearbox,
                 Speeds = request.Speeds,
                 Cylinders = request.Cylinders,
                 Traction = request.Traction,
                 Paint = request.Paint,
                 NumberDoors = request.NumberDoors,
                 NumberSeats = request.NumberSeats,
                 Weight = request.Weight
             };

            Create(car);

            await _context.SaveChangesAsync();

            return _mapper.Map<CarResponse>(car);


        //test
        /* Car res = new Car
         {
             Id = Guid.NewGuid().ToString(),
             Mark = "xxxx",
             Model = "xxxxx",
             Year = 1111,
             Body = "xxxx",
             ColorBody = "xxxxx",
             Km = 1111,
             HP = 1111,
             FuelType = "xxxx",
             Cm3 = 1111,
             Gearbox = "xxxx",
             Speeds = 1111,
             Cylinders = 1111,
             Traction = "xxxx",
             Paint = "xxxx",
             NumberDoors = 1111,
             NumberSeats = 1111,
             Weight = 1111
         };
         Create(res);
         await _context.SaveChangesAsync();
         return _mapper.Map<CarResponse>(res); */
        }

        public void UpdateCar(Car car)
        {
            UpdateCar(car);
        }

        public void DeleteCar(Car car)
        {
            DeleteCar(car);
        }
    }
}
