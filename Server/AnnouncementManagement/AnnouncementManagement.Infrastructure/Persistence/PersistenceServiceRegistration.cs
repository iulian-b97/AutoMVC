using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Infrastructure.Persistence.Repositories;
using AnnouncementManagement.Infrastructure.Persistence.Repositories.VehicleRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AnnouncementManagement.Infrastructure.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IMotorcycleRepository, MotorcycleRepository>();
            services.AddScoped<ITruckRepository, TruckRepository>();
            services.AddScoped<IVanRepository, VanRepository>();
            services.AddScoped<ITrailerRepository, TrailerRepository>();

            services.AddDbContext<AnnouncementContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("AnnouncementManagementConnectionString"));
            });

            return services;
        }
    }
}
