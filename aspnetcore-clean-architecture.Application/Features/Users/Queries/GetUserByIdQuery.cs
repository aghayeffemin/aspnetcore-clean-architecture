using aspnetcore_clean_architecture.Domain.Entities;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;
using MediatR;

namespace aspnetcore_clean_architecture.Application.Features.Users.Queries
{
    public class GetUserByIdQuery
    {
        public class Query : IRequest<User>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, User>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<User> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(user => user.Id == request.Id);

                if (user is null)
                    throw new KeyNotFoundException($"User record for key {request.Id} not found.");

                return user;
            }
        }
    }
}
