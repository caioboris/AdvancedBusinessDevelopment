using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_HISTORICO_VENDAS")]
    public class HistoricoVenda
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public Vendedor Vendedor { get; set; } = new();

        [Required]
        public Cliente Cliente { get; set; } = new();

        [Required]
        public DateTime Data {  get; set; }
        
        [Required]
        public int Quantidade { get; set; }

        [Required]
        public int ValorTotal {  get; set; }

    }
}
