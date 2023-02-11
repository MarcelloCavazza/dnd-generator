using dndAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User> {
            new User
            {
                Id = 1,
                nickName = "John Doe",
                email = "John@gmail.com",
                password = "12345",
                deleted= false,
            },
            new User
            {
                Id = 2,
                nickName = "Sylas",
                email = "sylas@gmail.com",
                password = "31231",
                deleted= false,
            }
    };
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var userSelect = users.Find(user => user.Id == id);
            if(userSelect is null) return NotFound("Sorry, we did not found the user you are looking for.");

            return Ok(userSelect);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser([FromBody]User user)
        {
            users.Add(user);
            if (user.Id == 1 || user.Id == 2) return BadRequest("Não se pode repetir Ids!");
            return Ok(users);
        }
    }
}
