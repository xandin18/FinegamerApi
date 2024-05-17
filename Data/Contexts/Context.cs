
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace EF.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<AdministradorEntity> Administrador { get; set; }
        public DbSet<DescontoEntity> Desconto { get; set; }
    }
}
