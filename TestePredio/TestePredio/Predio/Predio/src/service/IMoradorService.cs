using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.modelos;

namespace Predio.src.service
{
    public interface IMoradorService
    {
        Task NovoMoradorAsync(NovoMoradorDTO novoMorador);
        Task AtualizarMoradorAsync(AtualizarMoradorDTO morador);
        Task DeletarMoradorAsync(int id);
        Task<FamiliaModelo> ListarMoradoresIdAsync();
    }
}