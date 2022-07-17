using Application.User_login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    public class UserAuthController : ControllerBase
    {
        private readonly ILogin Ilogin_;
        public UserAuthController(ILogin login)
        {
            this.Ilogin_ = login;
        }

        [HttpPost]
        [Route("LoginUser/{username}/{password}")]
        public IActionResult Login(string username , string password)
        {
            var userlogin = Ilogin_.LoginUser(username, password);
            return Ok(userlogin);
        }

        [HttpPost]
        [Route("LoginUser/{username}/{password}")]
        public IActionResult SignUp()
        {
            return null;
        }



    }
}
