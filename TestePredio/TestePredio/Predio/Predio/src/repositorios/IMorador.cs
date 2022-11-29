using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.entidades;
using Predio.src.modelos;

namespace Predio.src.repositorios
{
    public interface IMorador
    {
        Task NovoMoradorAsync(Morador morador);

        Task AtualizarMoradorAsync(Morador morador);

        Task DeletarMoradorAsync(int id);

        Task<MoradorModelo> PegarMoradorpeloIdAsync(int id);        
    }
}