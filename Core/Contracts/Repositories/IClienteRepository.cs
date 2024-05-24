
using Core.Entity;
using Core.Models;

namespace Core.Contracts.Repositories
{
    public interface IClienteRepository
    {
        Task<TipoDeLogin> GetById(string email, string password);
        Task<bool> PostAsync(ClienteEntity model);
    }
}
