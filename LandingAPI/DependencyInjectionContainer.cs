using Repositories.IRepository;
using Repositories.Repository;
using Services.IService;
using Services.Service;

namespace LandingAPI
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<ILandRepository, LandRepository>();
            services.AddScoped<ILandService, LandService>();

            return services;
        }
    }
}
