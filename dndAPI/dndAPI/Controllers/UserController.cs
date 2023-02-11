using dndAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<User>> GetUserById()
        {
            var actualUser = new User
            {
                Id = 1,
                nickName = "John Doe",
                email = "teste@gmail.com",
                password = "12345",
                deleted= false,
            };
            return Ok(actualUser);
        }
    }
}
