using dndAPI.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var result = _userService.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var result = _userService.GetUserById(id);
            if (result == null) return NotFound("Usuario não encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser([FromBody]User user)
        {
            var result = _userService.AddUser(user);
            if (result == null) return BadRequest("Não foi possível criar o usuário");
            return Ok(result);
        }

        [HttpPatch("{id}")]
        public async Task <ActionResult<User>> UpdateUser([FromBody]User user, int id)
        {
            var result = _userService.UpdateUser(user, id);
            if (result == null) return BadRequest("Usuário não pode ser atualizado");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var result = _userService.DeleteUser(id);
            if (result == null) return BadRequest("Não foi possível remover o usuário");
            return Ok(result);
        }
    }
}
