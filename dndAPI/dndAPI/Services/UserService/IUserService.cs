using dndAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Services.UserService
{
    public interface IUserService
    {
        List<User>? GetAllUsers();
        User GetUserById(int id);
        List<User>? AddUser(User user);
        User UpdateUser(User user, int id);
        User DeleteUser(int id);
    }
}
