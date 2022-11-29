using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.modelos;

namespace Predio.src.service
{
    public interface ICondominioService
    {
        Task NovoCondominioAsync(NovoCondominioDTO novoCondominio);
        Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio);
        Task DeletarCondominioAsync(int id);
        Task<List<CondominioModelo>> ListarCondominiosIdAsync();
    }
}