using CleanArchitectureCQRS.Application.Context;
using CleanArchitectureCQRS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureCQRS.Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CourtDbContext>(options =>

            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICourtDbContext>(option =>
            {
                return option.GetService<CourtDbContext>();
            });
        }
    }
}