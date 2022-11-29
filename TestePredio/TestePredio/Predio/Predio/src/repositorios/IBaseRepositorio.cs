using System.Collections.Generic;
using System.Threading.Tasks;

namespace Predio.src.repositorios
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        Task NovoCadastroAsync(TEntity entity);
        Task AtualizarCadastroAsync(TEntity entity);
        Task DeletarCadastroAsync(int id);
        Task<TEntity> ListarCadastrosPorIdAsync(int id);
        Task<List<TEntity>> ListarCadastrosAsync();
    }
}