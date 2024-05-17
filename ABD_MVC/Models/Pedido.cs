using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABD_MVC.Models;

[Table("tb_pedidos")]
public class Pedido
{
    [Key]
    public int Id { get; set; }

    public decimal Valor { get; set; }

    public string Nome { get; set; }

}   
