using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.modelos
{
    [Table("tb_Morador")]
    public class MoradorModelo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [ForeignKey("Fk_Familia")]
        public int FK_familia { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
