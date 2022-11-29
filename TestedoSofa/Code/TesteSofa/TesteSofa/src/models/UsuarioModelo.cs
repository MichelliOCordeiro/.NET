using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteSofa.src.models
{
    /// <summary>
    /// <para>Classe responsavel por representar tb_usuario no banco</para>
    /// <para>By: Michelli Cordeiro</para>
    /// <para>v 1.0</para>
    /// <para>30/08/2022</para>
    /// </summary>
    [Table("tb_Usuario")]
    public class UsuarioModelo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        public bool Inspetor { get; set; }
    }
}