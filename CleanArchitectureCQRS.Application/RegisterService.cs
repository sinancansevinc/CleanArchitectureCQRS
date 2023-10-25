using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitectureCQRS.Application
{
    public static class RegisterService
    {
        public static void ConfigureApplication(this IServiceCollection services,IConfiguration configuration)
        {
            var assembly = typeof(RegisterService).Assembly;
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


        }
    }
}