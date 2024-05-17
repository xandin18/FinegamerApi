using Core.Contracts.Repositories;
using Core.Entity;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/desconto")]
    public class DescontoController : Controller
    {
        [HttpGet("id")]
        public async Task<DescontoEntity> GetById(int id, [FromServices] IDescontoRepository repository)
        {
            return await repository.GetById(id);
        }
    }
}
