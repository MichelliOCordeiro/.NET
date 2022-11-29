using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.dtos
{
    public class NovoCondominioDTO    
    {
        [Required(ErrorMessage = "Informe o nome do condomínio")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o bairro do condomínio")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a área total do condomínio")]
        public  decimal AreaTotal { get; set; }
       
        [Required(ErrorMessage = "Informe o valor do IPTU")]
        [Range(0.01, 9999999.00, ErrorMessage = "O valor do IPTU deve estar entre R${1} e R${2}")]
        public decimal ValorIPTU  { get; set; }
    }
}