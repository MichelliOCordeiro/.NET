using Microsoft.EntityFrameworkCore;
using Predio.src.entidades;
using Predio.src.modelos;
using Predio.src.dtos;

namespace Predio.src.data
{
    public class PredioContexto : DbContext
    {
        public DbSet<Morador> Morador { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Condominio> Condominio { get; set; }
        public PredioContexto(DbContextOptions<PredioContexto> opt) : base(opt)
        {  
        }
    }
}