using Core.Entity;

namespace Core.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoEntity>> GetAll();
        Task<ProdutoEntity> GetById(string nome);
        Task<bool> PostAsync(ProdutoEntity model);
    }
}
