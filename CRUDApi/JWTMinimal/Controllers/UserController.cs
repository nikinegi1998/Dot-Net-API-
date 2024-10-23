using JWTCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JWTCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Sellers")]
        [Authorize(Roles ="Seller")]
        public IActionResult SellersEndpoint()
        {
            var currentUser = GetCurrentUser();
            return Ok($"Hi {currentUser.Givenname}, you are a {currentUser.Role}");
        }

        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if(identity != null)
            {
                var userclaim = identity.Claims;

                return new UserModel
                {
                    Username = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    Email = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    Givenname = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.GivenName)?.Value,
                    Surname = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.Surname)?.Value,
                    Role = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }

        [HttpGet("AdminandSeller")]
        [Authorize(Roles = "Seller, Administrator")]
        public IActionResult AdminandSellerEndpoints()
        {
            var currentUser = GetCurrentUser();
            return Ok($"Hi {currentUser.Givenname}, you are a {currentUser.Role}");
        }
    }
}
