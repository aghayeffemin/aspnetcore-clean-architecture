using aspnetcore_clean_architecture.Domain.Entities;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;
using MediatR;

namespace aspnetcore_clean_architecture.Application.Features.Users.Commands
{
    public class AddUserCommand
    {
        public class Command : IRequest
        {
            public string Name { get; set; }
            public string Surname { get; set; }
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
                    Name = request.Name,
                    Surname = request.Surname,
                    DateCreated = DateTime.Now,
                };

                await _userRepository.Add(user);

                return Unit.Value;
            }
        }
    }
}
