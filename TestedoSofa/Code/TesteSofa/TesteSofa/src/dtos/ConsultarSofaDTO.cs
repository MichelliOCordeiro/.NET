using System;

namespace TesteSofa.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe para consultar sofa</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class ConsultarSofaDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }

        public double QtdeLugares { get; set; }

        public double Comprimento { get; set; }

        public double Largura { get; set; }

        public double Profundidade { get; set; }

        public bool Avaliacao { get; set; }

        public int AvaliadoPor { get; set; }

        public DateTime DataAvaliacao { get; set; }

        public bool Inspetor { get; set; }
    }
}
