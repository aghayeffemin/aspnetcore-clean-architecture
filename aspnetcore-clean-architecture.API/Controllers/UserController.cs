using aspnetcore_clean_architecture.Application.Features.Users.Commands;
using aspnetcore_clean_architecture.Application.Features.Users.Queries;
using aspnetcore_clean_architecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_clean_architecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetList()
        {
            var userList = await _mediator.Send(new GetUserListQuery.Query());
            return Ok(userList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(Guid id)
        {
            var user = await _mediator.Send(new GetUserByIdQuery.Query { Id = id });
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> Add(AddUserCommand.Command command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateUserCommand.Command command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteUserCommand.Command { Id = id });
            return Ok();
        }
    }
}
