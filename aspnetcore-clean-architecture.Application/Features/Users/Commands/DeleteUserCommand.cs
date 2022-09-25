using aspnetcore_clean_architecture.Domain.Entities;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;
using MediatR;

namespace aspnetcore_clean_architecture.Application.Features.Users.Commands
{
    public class DeleteUserCommand
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = new User
                {
                    Id = request.Id,
                };

                await _userRepository.Delete(user);

                return Unit.Value;
            }
        }
    }
}
