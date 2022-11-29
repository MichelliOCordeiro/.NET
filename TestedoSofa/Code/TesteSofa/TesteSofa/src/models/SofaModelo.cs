using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteSofa.src.models
{
    /// <summary>
    /// <para>Classe responsavel por representar tb_sofa no banco</para>
    /// <para>By: Michelli Cordeiro</para>
    /// <para>v 1.0</para>
    /// <para>30/08/2022</para>
    /// </summary>
    [Table("tb_Sofa")]
    public class SofaModelo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(50)]
        public string Foto { get; set; }

        [Required]
        public double QtdeLugares { get; set; }

        [Required]
        public double Comprimento { get; set; }

        [Required]
        public double Largura { get; set; }

        [Required]
        public double Profundidade { get; set; }
        
        public bool Avaliacao { get; set; }
        
        public int AvaliadoPor { get; set; }
        
        public DateTime DataAvaliacao { get; set; }

    }
}