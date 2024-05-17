using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABD.Checkpoint2.Models
{
    [Table("TB_MUSICA")]
    public class Musica
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Artista Artista { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int AnoLancamento { get; set; }
    }
}