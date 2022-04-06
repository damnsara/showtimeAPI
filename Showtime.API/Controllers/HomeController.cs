using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Showtime.Domain.Entities;
using Showtime.Infra.Data.Repositories;
using Showtime.Service;
using System;
using System.Threading.Tasks;

namespace Showtime.API.Controllers
{
    [Route("v1/account")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "anonymous";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Authenticated - {0}", User.Identity.Name);

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Employee() => "Administrator";
    }
}
