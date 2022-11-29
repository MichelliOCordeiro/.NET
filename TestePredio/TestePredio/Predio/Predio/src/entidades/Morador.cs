using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.entidades
{
    [Table("tb_Morador")]
    public class Morador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}