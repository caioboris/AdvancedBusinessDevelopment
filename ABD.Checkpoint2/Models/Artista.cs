using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABD.Checkpoint2.Models;

[Table("TB_ARTISTA")]
public class Artista
{
    [Key]
    public Guid Id { get; set; }
    [Required, MaxLength(200)]
    public string? Nome { get; set; }
    public string? Nacionalidade { get; set; }
    public int Idade { get; set; }
    public List<Musica> Musicas { get; set; }

}
