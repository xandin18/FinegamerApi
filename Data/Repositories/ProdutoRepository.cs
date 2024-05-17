using Core.Contracts.Repositories;
using Core.Entity;
using EF.Contexts;
using Microsoft.Extensions.Logging;

namespace EF.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ILogger<ProdutoRepository> _logger;
        private readonly Context _context;
        public ProdutoRepository(ILogger<ProdutoRepository> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<bool> PostAsync(ProdutoEntity model)
        {
            try
            {
                _logger.LogInformation($"Inserindo o produto {model.Nome} no banco de dados");
                _context.Produto.Add(model);
                _context.SaveChanges();
                _logger.LogInformation("Inserção foi consluída com sucesso");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Algo de errado na hora de inserir o produto: \n Error: {ex.Message}", ex);
                return false;
            }
        }

        public async Task<IEnumerable<ProdutoEntity>> GetAll()
        {
            try
            {
                _logger.LogInformation($"Buscando todos os produtos");
                var todosProdutos = _context.Produto.ToList();
                _logger.LogInformation($"Busca realizada com sucesso {todosProdutos}");
                return todosProdutos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return Enumerable.Empty<ProdutoEntity>();
            }
        } 

        public async Task<ProdutoEntity> GetById(int id)
        {
            try
            {
                _logger.LogInformation($"Buscando produto de id {id}");
                var produto = _context.Produto.FindAsync(id);
                _logger.LogInformation($"Busca realizada com sucesso");
                return await produto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return null;
            }
        }
    }
}
