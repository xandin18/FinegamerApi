using Core.Contracts.Repositories;
using Core.Entity;
using Core.Models;
using EF.Contexts;

using Microsoft.Extensions.Logging;

namespace EF.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Context _context;
        private readonly ILogger<ClienteRepository> _logger;
        public ClienteRepository(Context context, ILogger<ClienteRepository> logger) 
        { 
            _context = context;
            _logger = logger;
        }
        public async Task<TipoDeLogin> GetById(string email, string password)
        {
            try
            {
                _logger.LogInformation($"Buscando cliente de id {email}");
                var cliente = _context.Cliente
                      .Where(x => x.Email == email && x.Senha == password)
                      .FirstOrDefault();
                _logger.LogInformation($"Busca realizada com sucesso");
                if(cliente != null)
                 return TipoDeLogin.Cliente;
                else
                 return TipoDeLogin.Desconhecido;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}", ex);
                return TipoDeLogin.Desconhecido;
            }
        }
        public async Task<bool> PostAsync(ClienteEntity model)
        {
            try
            {
                _logger.LogInformation($"Inserindo o cliente {model.Email} no banco de dados");
                _context.Cliente.Add(model);
                _context.SaveChanges();
                _logger.LogInformation("Inserção foi consluída com sucesso");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Algo de errado na hora de inserir o cliente: \n Error: {ex.Message}", ex);
                return false;
            }
        }
    }
}
