using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace ScladCRUD.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login.UserName == "3" && login.Password =="2")
            {
                var token = GenerateToken(login.UserName);
                return Ok(token);
            }
            return BadRequest("Login Failed");
        }
        private string GenerateToken(string Username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
             new Claim(ClaimTypes.NameIdentifier, Username)
            };
            var token = new JwtSecurityToken(
                _config.GetSection("Jwt:Issuer").Value , _config.GetSection("Jwt:Audience").Value,
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Token ydacno sozdan");
        }
    }
}
