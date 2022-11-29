using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.dtos
{
    public class NovaFamiliaDTO    
    {
        [Required(ErrorMessage = "Informe o nome do condomínio")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Id do condomínio")]
        public int Id_Condominio { get; set; }

        [Required(ErrorMessage = "Informe o numero do apartamento")]
        public int Apto { get; set; }

        [Required(ErrorMessage = "Informe a área total do apartamento")]
        public decimal AreaApto { get; set; }

        [Required(ErrorMessage = "Informe o IPTU proporcional")]
        public  decimal IPTUprop{ get; set; }
    }
}