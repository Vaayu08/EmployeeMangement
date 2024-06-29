using EmployeeMangement.Interface;
using EmployeeMangement.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;   
        }
        
        [HttpPost("login")]
        public string Login([FromBody]LoginRequest obj)
        {
            var token =_auth.Login (obj);
            return token;
        }

        [HttpPost("assignRole")]
        public bool AssignRoleToUser([FromBody]AddUserRole userRole)
        {
            var addeduser = _auth.AssignRoleToUser(userRole);
            return addeduser;   
        }

        
        [HttpPost("addUser")]
        public User AddUser ([FromBody] User user)
        {
          var addeduser= _auth.AddUser (user);
            return addeduser;
        }

        // PUT api/<AuthController>/5
        [HttpPost("")]
        public Role AddRole( [FromBody] Role role )
        {
            var addedRole = _auth.AddRole(role);
            return addedRole;
        }

        
    }
}
