using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public enum TipoDeLogin
    {
        [Description("Cliente")]
        Cliente = 1,
        [Description("Admin")]
        Admin = 2,
        [Description("Desconhecido")]
        Desconhecido = 3
    }
}
