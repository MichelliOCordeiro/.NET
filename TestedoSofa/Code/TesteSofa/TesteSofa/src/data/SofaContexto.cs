using Microsoft.EntityFrameworkCore;
using TesteSofa.src.models;

namespace TesteSofa.src.data
{
    /// <summary>
    /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets</para>
    /// <para>Criado por: Michelli Oliveira </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 30/08/2022</para>
    /// </summary> 
    public class SofaContexto : DbContext
    {
        public DbSet<SofaModelo> Sofa { get; set; }
        public DbSet<UsuarioModelo> Usuario { get; set; }
        public SofaContexto(DbContextOptions<SofaContexto> opt) : base(opt)
        {  

        }
    }
}