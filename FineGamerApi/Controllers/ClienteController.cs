using Core.Contracts.Repositories;
using Core.Entity;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/cliente")]
    public class ClienteController : Controller
    {

        [HttpGet("id")]
        public async Task<ClienteEntity> GetById(int id, [FromServices] IClienteRepository repository)
        {
            return await repository.GetById(id);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] ClienteEntity cliente, [FromServices] IClienteRepository repository)
        {
            var post = await repository.PostAsync(cliente);
            return post;
        }  
    }
}
