using aspnetcore_clean_architecture.Domain.Entities;

namespace aspnetcore_clean_architecture.Persistence.Repositories.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
