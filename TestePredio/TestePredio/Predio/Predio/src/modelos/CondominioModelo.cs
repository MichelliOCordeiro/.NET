using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.modelos
{
    [Table("tb_Condominio")]
    public class CondominioModelo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(50)]
        public string Bairro { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal ValorIPTU { get; set; }
    }
}
