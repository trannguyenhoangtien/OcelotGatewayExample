using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Services;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> UserList()
        {
           return _userService.GetUserList();
        }

        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public User AddUser(User user)
        {
            return _userService.AddUser(user);
        }

        [HttpPut]
        public User UpdateUser(User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public bool DeleteUser(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
