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
            Car car = _mapper.Map<Car>(request);
            car.Id = Guid.NewGuid().ToString();

            Create(car);
            await _context.SaveChangesAsync();

            return _mapper.Map<CarResponse>(car);
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
