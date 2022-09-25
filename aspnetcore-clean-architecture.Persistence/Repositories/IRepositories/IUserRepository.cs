using aspnetcore_clean_architecture.Domain.Entities;

namespace aspnetcore_clean_architecture.Persistence.Repositories.IRepositories
{
    internal interface IUserRepository : IGenericRepository<User>
    {
    }
}
