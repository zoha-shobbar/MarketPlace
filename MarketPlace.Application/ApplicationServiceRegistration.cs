using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
namespace MarketPlace.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddMediatR(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
