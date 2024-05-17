
using Core.Entity;

namespace Core.Contracts.Repositories
{
    public interface IClienteRepository
    {
        Task<ClienteEntity> GetById(int id);
        Task<bool> PostAsync(ClienteEntity model);
    }
}
