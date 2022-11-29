using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.modelos;

namespace Predio.src.service
{
    public interface IFamiliaService
    {
        Task NovaFamiliaAsync(NovaFamiliaDTO novafamilia);
        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia);
        Task DeletarFamiliaAsync(int id);
        Task<FamiliaModelo> ListarFamiliasIdAsync();
    }
}
