
using Core.Entity;

namespace Core.Contracts.Repositories
{
    public interface IClienteRepository
    {
        Task<bool> GetById(string email, string password);
        Task<bool> PostAsync(ClienteEntity model);
    }
}
