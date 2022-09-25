using aspnetcore_clean_architecture.Persistence;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace aspnetcore_clean_architecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectApplicationDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.InjectPersistenceDependencies(Configuration);

            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
