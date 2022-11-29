using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteSofa.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe para atualizar um sofa</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class AtualizarSofaDTO    
    {
        [Required(ErrorMessage = "Insira o Id do sofa")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do sofa")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira o link da foto do sofa")]
        [MinLength(2, ErrorMessage = "Minimo de {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de lugares do sofá")]
        public double QtdeLugares { get; set; }

        [Required(ErrorMessage = "Informe o comprimento do sofa")]
        public double Comprimento { get; set; }

        [Required(ErrorMessage = "Informe a largura do sofa")]
        public double Largura { get; set; }

        [Required(ErrorMessage = "Informe a profundidade do sofa")]
        public double Profundidade { get; set; }

        public bool Avaliacao { get; set; }

        public int AvaliadoPor { get; set; }

        public DateTime DataAvaliacao { get; set; }

        [Required(ErrorMessage = "Informe se você é inspetor")]
        public bool Inspetor { get; set; }
    }

}