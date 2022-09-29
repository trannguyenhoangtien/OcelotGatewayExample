using UserAPI.Models;

namespace UserAPI.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUserList();
        public User GetUserById(int id);
        public User AddUser(User user);
        public User UpdateUser(User user);
        public bool DeleteUser(int id);
    }
}
