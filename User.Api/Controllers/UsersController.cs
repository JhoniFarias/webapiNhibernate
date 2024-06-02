using Microsoft.AspNetCore.Mvc;
using User.Application.Commands;

namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create(CreateUserCommand command)
        {
            return CreatedAtAction(nameof(Create), new { Id = 0 });
        }

        [HttpPut]
        public IActionResult Update(UpdateUserCommand command)
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteUserCommand command)
        {
            return NoContent();
        }

    }
}
