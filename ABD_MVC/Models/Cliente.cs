using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABD_MVC.Models;

[Table("tb_cliente")]
public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(150)]
    public string Nome { get; set; }

    public string Email{ get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; }
}
