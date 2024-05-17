using Core.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repositories
{
    public interface IAdministradorRepository
    {
        Task<AdministradorEntity> GetById(int id);
    }
}
