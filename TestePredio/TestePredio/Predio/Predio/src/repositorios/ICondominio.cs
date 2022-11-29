using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.entidades;

namespace Predio.src.repositorios
{
    public interface ICondominio
    {
        Task NovoCondominioAsync(Condominio condominio);
        Task AtualizarCondominioAsync(Condominio condominio);
        Task DeletarCondominioAsync(int id);
        Task<Condominio> ListarCondominiosAsync(int id);
        Task<List<Condominio>> ListarCondominiosAsync();
    }
}