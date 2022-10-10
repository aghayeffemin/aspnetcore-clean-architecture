using aspnetcore_clean_architecture.Application.Features.Users.Queries;
using aspnetcore_clean_architecture.Domain.Entities;
using aspnetcore_clean_architecture.Persistence.Repositories.IRepositories;
using Moq;
using System;
using System.Threading;
using Xunit;

namespace aspnetcore_clean_architecture.Test.Features.Users.Queries
{
    public class GetUserByIdQueryTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;

        private readonly GetUserByIdQuery.Query _query;
        private readonly User _user;

        private readonly Guid _userId;

        private readonly GetUserByIdQuery.Handler _sut;

        public GetUserByIdQueryTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();

            _userId = Guid.NewGuid();

            _user = new User
            {
                Id = _userId
            };

            _query = new GetUserByIdQuery.Query
            {
                Id = _userId
            };

            _mockUserRepository.Setup(x => x.Get(y => y.Id == _userId))
                .ReturnsAsync(_user);

            _sut = new GetUserByIdQuery.Handler(_mockUserRepository.Object);
        }

        [Fact]
        public void GetUserByIdQuery_ReturnsUser()
        {
            // Act
            var result = _sut.Handle(_query, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(_userId, _user.Id);
        }
    }
}
