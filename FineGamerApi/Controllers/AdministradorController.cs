using Core.Contracts.Repositories;
using Core.Entity;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/administrador")]
    public class AdministradorController : Controller
    {
        [HttpGet("id")]
        public async Task<AdministradorEntity> GetById(int id, [FromServices] IAdministradorRepository repository)
        {
            return await repository.GetById(id);
        }
    }
}
