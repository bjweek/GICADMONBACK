using Cenit.Admon.Domain.Services.Interfaces;
using Cenit.Admon.Infraestructure.DataBase;
using Cenit.Admon.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cenit.Admon.Infraestructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DatabaseService>(options =>
            options.UseSqlServer(configuration["sqlconnectionstrings"]));
            services.AddScoped<ICustomerService,CustomerRepository>();

            return services;

        }
    }
}
