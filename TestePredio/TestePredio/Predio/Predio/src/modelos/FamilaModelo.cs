using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.modelos
{
    [Table("tb_Familia")]
    public class FamiliaModelo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [ForeignKey("Fk_condominio")]
        public CondominioModelo Condominio { get; set; }  
        
        [Required]    
        public int Apto { get; set; }
        [Required]
        public decimal AreaApto { get; set; }
        [Required]
        public decimal IPTUprop { get; set; }
    }
}