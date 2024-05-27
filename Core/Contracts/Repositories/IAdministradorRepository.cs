using Core.Models;

namespace Core.Contracts.Repositories
{
    public interface IAdministradorRepository
    {
        Task<TipoDeLogin> GetById(string email, string password);
    }
}
