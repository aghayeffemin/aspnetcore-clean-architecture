using aspnetcore_clean_architecture.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcore_clean_architecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectApplicationDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.InjectPersistenceDependencies(Configuration);

            return services;
        }
    }
}
