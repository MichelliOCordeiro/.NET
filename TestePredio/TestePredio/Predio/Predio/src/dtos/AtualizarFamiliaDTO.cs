using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.dtos
{
    public class AtualizarFamiliaDTO    
    {
        [Required(ErrorMessage = "Informe o identificador do condomínio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do condomínio")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o numero do apartamento")]
        public int Apto { get; set; }
    }
}