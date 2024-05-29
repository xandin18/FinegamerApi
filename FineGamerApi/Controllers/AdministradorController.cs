using Core.Contracts.Repositories;
using Core.Entity;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/administrador")]
    public class AdministradorController : Controller
    {
        [HttpGet("/aplicattion/v1/login/{email}/password/{password}")]
        public async Task<TipoDeLogin> GetById(string email, string password, [FromServices] IAdministradorRepository repository)
        {
            return await repository.GetById(email, password);
        }
    }
}
