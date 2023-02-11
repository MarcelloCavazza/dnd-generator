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

        [HttpPatch("{id}")]
        public async Task <ActionResult<User>> UpdateUser([FromBody]User user, int id)
        {
            if (id != user.Id) return BadRequest("IDs não iguais!");

            var userSeletec = users.Find(user => user.Id == id);
            if (userSeletec is null) return NotFound("Não achei!");

            userSeletec.nickName = user.nickName;
            userSeletec.email = user.email;
            userSeletec.deleted = user.deleted;
            userSeletec.password = user.password;

            users.Remove(user);
            users.Add(userSeletec);
            return Ok(userSeletec);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var userSeletec = users.Find(user => user.Id == id);
            if (userSeletec is null) return NotFound("Não achei!");

            users.Remove(userSeletec);

            return Ok(userSeletec);
        }
    }
}
