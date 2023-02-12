using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Services.UserService
{
    public class UserService : IUserService
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
        public List<User> AddUser([FromBody] User user)
        {
            users.Add(user);
            if (user.Id == 1 || user.Id == 2) return null;
            return users;
        }

        public User DeleteUser(int id)
        {
            var userSeletec = users.Find(user => user.Id == id);
            if (userSeletec is null) return null;

            users.Remove(userSeletec);

            return userSeletec;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            var userSelect = users.Find(user => user.Id == id);
            if (userSelect is null) return null;

            return userSelect;
        }

        public User UpdateUser([FromBody] User user, int id)
        {
            if (id != user.Id) return null;

            var userSeletec = users.Find(user => user.Id == id);
            if (userSeletec is null) return null;

            userSeletec.nickName = user.nickName;
            userSeletec.email = user.email;
            userSeletec.deleted = user.deleted;
            userSeletec.password = user.password;

            users.Remove(user);
            users.Add(userSeletec);
            return userSeletec;
        }
    }
}
