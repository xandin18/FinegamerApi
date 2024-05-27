using Core.Contracts.Repositories;
using Core.Entity;
using Core.Models;
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

        public async Task<TipoDeLogin> GetById(string email, string password)
        {
            try
            {
                _logger.LogInformation($"Buscando desconto de id {email}");
                var administrador = _context.Administrador
                      .Where(x => x.Email == email && x.Senha == password)
                      .FirstOrDefault(); ;
                _logger.LogInformation($"Busca realizada com sucesso");
                if (administrador != null)
                    return TipoDeLogin.Admin;
                else
                    return TipoDeLogin.Desconhecido;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return TipoDeLogin.Desconhecido;
            }
        }
    }
}
