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

        [HttpGet("{nome}")]
        public async Task<ProdutoEntity> GetById(string nome, [FromServices] IProdutoRepository repository)
        {
            var getbyname = await repository.GetById(nome);
            return getbyname;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoEntity produto, [FromServices] IProdutoRepository repository)
        {
            var post = await repository.PostAsync(produto);
            return Ok(post);
        }
    }
}
