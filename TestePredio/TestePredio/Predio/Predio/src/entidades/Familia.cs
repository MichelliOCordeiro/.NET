using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predio.src.entidades
{
    [Table("tb_Familia")]
    public class Familia
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Id_Condominio { get; set; }

        public int Apto { get; set; }

        public int AreaApto { get; set; }

        public double IPTUprop { get; set; }
    }
}