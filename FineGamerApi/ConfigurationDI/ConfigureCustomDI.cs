using Core.Contracts.Repositories;

using EF.Contexts;
using EF.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Api.ConfigurationDI
{
    internal static class ConfigureCustomDI
    {
        public static void AddDI(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IAdministradorRepository, AdministradorRepository>();
            builder.Services.AddScoped<IDescontoRepository, DescontoRepository>();
            builder.AddDataDI(configuration);
        }

        public static void AddDataDI(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            var teste = configuration.GetConnectionString("FineGamerDB");
            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FineGamerDB")));
        }
    }
}