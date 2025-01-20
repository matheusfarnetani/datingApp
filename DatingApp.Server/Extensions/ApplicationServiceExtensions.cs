using DatingApp.Server.Data;
using DatingApp.Server.Interfaces;
using DatingApp.Server.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Server.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // Add services to the container.

            services.AddControllers();
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            // CORS
            services.AddCors();

            // Token Service
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
