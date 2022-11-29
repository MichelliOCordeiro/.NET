using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteSofa.src.dtos.Laudos
{
    /// <summary>
    /// <para>Resumo: Classe para criar um novo laudo</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class CriarLaudoDTO
    {
        [Required(ErrorMessage = "Insira o Id do sofa")]
        public int SofaId { get; set; }

        [Required(ErrorMessage = "Insira se o sofá está aprovado ou não [sim / não] ")]
        public string Aprovado { get; set; }

        public int UsuarioId { get; set; }
    }
}
