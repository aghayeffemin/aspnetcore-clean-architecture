using aspnetcore_clean_architecture.Domain.Entities;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;

namespace aspnetcore_clean_architecture.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
