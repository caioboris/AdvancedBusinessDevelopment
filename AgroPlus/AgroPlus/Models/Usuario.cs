using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_USUARIOS")]
    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public Vendedor Vendedor { get; set; } = null!;

        [Required, MaxLength]
        public string Senha {  get; set; }

    }
}
