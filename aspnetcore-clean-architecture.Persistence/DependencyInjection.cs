using aspnetcore_clean_architecture.Persistence.Repositories;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcore_clean_architecture.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectPersistenceDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
