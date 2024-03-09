using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TestJWT.Models;

namespace TestJWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class LoginController : ControllerBase
    {
      
        private readonly JwtSettings _jwtSettings;
        public LoginController(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            string username = "ejemplo_usuario";
            int userId = 123;


            // creamos las afirmaciones para el token JWT
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            };

            // Crear el token JWT

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecreyKey)),
                    SecurityAlgorithms.HmacSha256)
                
                );

            // codigicamos el token en una cadena

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            // devolver el token al cliente

            return Ok(new { Token = tokenString });


        }


    }
}
