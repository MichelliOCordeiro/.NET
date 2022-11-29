using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.entidades
{
    [Table("tb_Condominio")]
    public class Condominio
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Bairro { get; set; }

        public decimal AreaTotal { get; set; }
        
        public decimal ValorIPTU { get; set; }
    }
}

