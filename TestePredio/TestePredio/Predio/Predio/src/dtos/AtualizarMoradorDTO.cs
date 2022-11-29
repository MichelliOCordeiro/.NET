using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.dtos
{
    public class AtualizarMoradorDTO    
    {
        [Required(ErrorMessage = "Informe o identificador do morador")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do morador")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a idade do morador")]
        public int Idade { get; set; }
    }
}