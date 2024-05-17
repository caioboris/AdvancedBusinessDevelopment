using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroPlus.Models
{
    [Table("T_INFO_REGIAO")]
    public class InfoRegiao
    {
        [Key]
        public long Id {  get; set; }

        [Required]
        public Regiao IdRegiao { get; set; } = new();

        [Required]
        public Regiao Regiao { get; set; } = new();

        [Required]
        public int Temperatura { get; set; }

        [Required]
        public int Umidade { get; set; }

        [Required]
        public int Precipitacao { get; set; }
        [Required]
        public DateTime DataInfo {  get; set; }
    }
}
