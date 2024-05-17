using Core.Contracts.Repositories;
using Core.Entity;

using Microsoft.AspNetCore.Mvc;

namespace FineGamerApi.Controllers
{
    [ApiController]
    [Route("aplicattion/v1/produto")]
    public class ProdutoController : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<ProdutoEntity>> Get([FromServices] IProdutoRepository repository)
        {
            return await repository.GetAll();
        }

        [HttpGet("id")]
        public async Task<ProdutoEntity> GetById(int id, [FromServices] IProdutoRepository repository)
        {
            return await repository.GetById(id);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] ProdutoEntity produto, [FromServices] IProdutoRepository repository)
        {
            var post = await repository.PostAsync(produto);
            return post;
        }
    }
}
