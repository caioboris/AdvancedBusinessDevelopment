using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_VENDEDORES")]
    public class Vendedor
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public List<Regiao> Regiao { get; set; } = [];

        [Required]
        public List<HistoricoVenda> HistoricoVenda { get; } = [];

        [Required, MaxLength(60)]
        public string Nome { get; set; }

        [Required, MaxLength(60)]
        public string Contato { get; set; }


    }
}
