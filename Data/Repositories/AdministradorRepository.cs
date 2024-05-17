using Core.Contracts.Repositories;
using Core.Entity;

using EF.Contexts;

using Microsoft.Extensions.Logging;

namespace EF.Repositories
{
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly Context _context;
        private readonly ILogger<AdministradorRepository> _logger;
        public AdministradorRepository(Context context, ILogger<AdministradorRepository> logger) 
        {
            _context = context;
            _logger = logger;
        }

        public async Task<AdministradorEntity> GetById(int id)
        {
            try
            {
                _logger.LogInformation($"Buscando desconto de id {id}");
                var administrador = _context.Administrador.FindAsync(id);
                _logger.LogInformation($"Busca realizada com sucesso");
                return await administrador;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return null;
            }
        }
    }
}
