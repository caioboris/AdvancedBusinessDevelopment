using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_TIPOS_CULTIVOS")]
    public class TipoCultivo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public List<Cliente> Cliente { get; set; } = [];

        [Required, MaxLength(60)]
        public string NomeCultivo { get; set; }
    }
}
