using ManchiEco.Application.Interfaces;
using ManchiEco.Application.Services;
using ManchiEco.Domain.Interfaces;
using ManchiEco.EntityFramework.Repositories;

namespace ManchiEco.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Base Genericos
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));            
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));

            services.AddScoped(typeof(ICuotaService), typeof(CuotasService));
            services.AddScoped(typeof(IIngresosService), typeof(IngresosService));
            services.AddScoped(typeof(IHomeDataService), typeof(HomeDataService));

            return services;
        }
    }
}
