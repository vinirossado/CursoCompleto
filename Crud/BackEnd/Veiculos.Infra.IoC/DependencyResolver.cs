using Microsoft.Extensions.DependencyInjection;
using Veiculos.App;
using Veiculos.App.Interface;
using Veiculos.Infra.Data;
using Veiculos.Interfaces.Repos;
using Veiculos.Interfaces.Services;
using Veiculos.Services;

namespace Veiculos.Infra.IoC
{
    public static class DependencyResolver
    {

        public static void AddInjectionContainer(this IServiceCollection services)
        {
            AddApplicationContainer(services);
            AddServicesContainer(services);
            AddRepositoriesContainer(services);
        }

        private static void AddApplicationContainer(IServiceCollection services)
        {
            services.AddTransient<IVeiculoApp, VeiculoApp>();
        }

        private static void AddServicesContainer(IServiceCollection services)
        {
            services.AddTransient<IVeiculoService, VeiculoService>();
        }

        private static void AddRepositoriesContainer(IServiceCollection services)
        {
            services.AddTransient<IVeiculoRepo, VeiculoRepo>();
        }

    }
}
