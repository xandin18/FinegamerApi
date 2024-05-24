using Core.Contracts.Repositories;
using Core.Entity;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/cliente")]
    public class ClienteController : Controller
    {

        [HttpGet("name/{email}/password/{password}")]
        public async Task<bool> GetById(string email, string password, [FromServices] IClienteRepository repository)
        {
            return await repository.GetById(email, password);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] ClienteEntity cliente, [FromServices] IClienteRepository repository)
        {
            var post = await repository.PostAsync(cliente);
            return post;
        }  
    }
}
