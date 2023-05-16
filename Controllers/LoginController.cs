using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;

namespace ScladCRUD.Controllers
{
    
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginController(IConfiguration config,SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _config = config;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            var user = Authenticate(login.UserName, login.Password);
            if (user.Result != null)
            {
                var token = GenerateToken(login.UserName);
                return Ok(token);
            }
            return BadRequest("Login Failed");
        }
        private async Task <IdentityUser?> Authenticate (string userName, string Password)
        {
            var result = await _signInManager.PasswordSignInAsync(userName,Password,false,lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var currentUser = await _userManager.FindByNameAsync(userName);
                if (currentUser != null)
                {
                    return currentUser;
                }
            }
            return null;
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
