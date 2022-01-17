using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Infrastructure.Persistence.Repositories;
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

            services.AddDbContext<AnnouncementContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("AnnouncementManagementConnectionString"));
            });

            return services;
        }
    }
}
