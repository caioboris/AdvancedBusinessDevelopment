using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_REGIAO")]
    public class Regiao
    {
        [Key]
        public long Id { get; set; }

        [Required]
        private List<InfoRegiao> InfoRegiaos { get; } = [];

        [Required]
        private List<Vendedor> Vendedor { get; set; } = [];

        [Required, MaxLength(60)]
        public string NomeRegiao { get; set; } 
    }
}
