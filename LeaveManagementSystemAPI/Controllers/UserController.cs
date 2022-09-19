using LeaveManagementSystemAPI.Data.Models;
using LeaveManagementSystemAPI.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LeaveManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);
            return Ok();
        }

        [HttpPut]
        [Route("EditUser")]
        public IActionResult EditUser(User user)
        {
            _userRepository.EditUser(user);
            return Ok();
        }

        [HttpGet]
        [Route("GetUserById")]
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}
