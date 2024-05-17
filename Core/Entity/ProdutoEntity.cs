using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class ProdutoEntity
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Cd_Produto { get; set; }
        public int? Cd_Registrante { get; set; }
        public int? Cd_Desconto { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public byte[]? Imagem { get; set; }
    }
}
