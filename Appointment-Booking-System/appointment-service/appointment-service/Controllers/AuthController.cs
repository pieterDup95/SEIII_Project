using appointment_service.Controllers.Models;
using appointment_service.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace appointment_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly List<ClientCredentials> _clients;
        private readonly FrontendSettings _frontendSettings;

        public AuthController(IConfiguration configuration, IOptionsSnapshot<List<ClientCredentials>> clients, FrontendSettings frontendSettings)
        {
            _configuration = configuration;
            _clients = clients.Value;
            _frontendSettings = frontendSettings;
        }

        [HttpPost("frontend-token")]
        [AllowAnonymous]
        public IActionResult GetFrontendToken()
        {
            var origin = Request.Headers.Origin.FirstOrDefault();
            var allowedOrigins = new[] { _frontendSettings.BaseUrl };

            if (origin == null || !allowedOrigins.Contains(origin))
            {
                return Unauthorized("Invalid origin");
            }

            var client = _clients.FirstOrDefault(c => c.ClientId == "frontend-app");
            if (client == null) return NotFound();

            return Ok(new
            {
                access_token = GenerateJwtToken(client),
                expires_in = _configuration.GetValue<int>("Jwt:TokenLifetimeMinutes", 480) * 60
            });
        }

        [AllowAnonymous]
        [HttpPost("token")]
        public IActionResult Token([FromForm] TokenRequest request)
        {
            var client = _clients.FirstOrDefault(c =>
                c.ClientId == request.ClientId &&
                c.ClientSecret == request.ClientSecret);

            if (client == null)
                return Unauthorized("Invalid client_id or client_secret");

            var token = GenerateJwtToken(client);
            return Ok(new
            {
                access_token = token,
                token_type = "Bearer",
                expires_in = _configuration.GetValue<int>("Jwt:TokenLifetimeMinutes", 480) * 60
            });
        }

        private string GenerateJwtToken(ClientCredentials client)
        {
            var key = _configuration["Jwt:Key"]!;
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, client.ClientId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            foreach (var role in client.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_configuration.GetValue<int>("Jwt:TokenLifetimeMinutes", 720)),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}