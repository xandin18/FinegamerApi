using Core.Contracts.Repositories;
using Core.Entity;

using EF.Contexts;

using Microsoft.Extensions.Logging;

namespace EF.Repositories
{
    public class DescontoRepository : IDescontoRepository
    {
        private readonly Context _context;
        private readonly ILogger<DescontoRepository> _logger;
        public DescontoRepository(Context context, ILogger<DescontoRepository> logger) 
        {                         
            _context = context;
            _logger = logger;
        }

        public async Task<DescontoEntity> GetById(int id)
        {
            try
            {
                _logger.LogInformation($"Buscando desconto de id {id}");
                var desconto = _context.Desconto.FindAsync(id);
                _logger.LogInformation($"Busca realizada com sucesso");
                return await desconto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return null;
            }
        }
    }
}
