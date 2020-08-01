using Data.Repositories;
using Domain.Model.Interfaces.Repositories;
using Domain.Model.Interfaces.Services;
using Domain.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Crosscutting.IoC
{
    public class DependencyRegister
    {
        public static void RegisterDependencies(
            IServiceCollection services)
        {
            services.AddScoped<IBatataService, BatataService>();
            services.AddScoped<IBatataRepository, BatataRepository>();
        }
    }
}
