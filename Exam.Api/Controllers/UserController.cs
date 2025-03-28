using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.User;
using Exam.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Exam.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]

        public IActionResult AddUser(AddUserDto request)
        {
            User user = new User() {
                Name=request.Name, 
                FullName=request.FullName, 
                Password=request.Password, 
                Email=request.Email, 
                Role=request.Role, 
                CreateDate=DateTime.Now
            };
            _userService.AddAsync(user);
            return Ok("Success add User");
        }

        [HttpDelete]
        public IActionResult RemoveUser(RemoveUserDto request) 
        { 
            var user = _userService.GetByIdAsync(request.id).Result; 
            if (user == null)
            {

                return NotFound("User not found");
            }
            _userService.Delete(request.id); 
            return Ok("User deleted successfully");
        }

        [HttpPut]
        public IActionResult UpdateUser(UpdateUserDto request) {

            var user = _userService.GetByIdAsync(request.id).Result;
            if (user == null)
            {
                return NotFound("User not found");
            }
            user.Name = request.Name;
            user.FullName = request.FullName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.Role = request.Role;

            _userService.Update(user);
            return Ok("User updated successfully");

        }


    }


}

