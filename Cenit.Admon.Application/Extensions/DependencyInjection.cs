using AutoMapper;
using Cenit.Admon.Application.Configuration;
using Cenit.Admon.Domain.Services.Interfaces;
using Cenit.Admon.Infraestructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Cenit.Admon.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<ICustomerService, CustomerRepository>();
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());

            });

            return services;
        }
    }
}
