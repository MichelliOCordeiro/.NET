using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteSofa.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe para adicionar um novo usuario</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class NovoUsuarioDTO    
    {
        [Required(ErrorMessage = "Informe o nome do usuario")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o email do usuario")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuario")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe se o perfil é de inspetor")]
        public bool Inspetor { get; set; }
    }
}