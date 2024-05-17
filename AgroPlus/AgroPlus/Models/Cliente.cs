using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_CLIENTES")]
    public class Cliente
    {
        [Key]
        public long Id {  get; set; }

        [Required]
        public List<TipoCultivo> TipoCultivo { get; set; } = [];

        [Required]
        public List<HistoricoVenda> HistoricoVenda { get; } = [];

        [Required, MaxLength(60)]
        public string Nome { get; set; }
    }
}
