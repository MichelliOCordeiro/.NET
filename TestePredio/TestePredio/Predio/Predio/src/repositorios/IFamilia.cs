using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.entidades;
using Predio.src.modelos;

namespace Predio.src.repositorios
{
    public interface IFamilia
    {
        Task NovaFamiliaAsync(Familia familia);

        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia);

        Task DeletarFamiliaAsync(int id);

        Task<FamiliaModelo> PegarFamiliaPeloIdAsync(int id);

        Task<List<FamiliaModelo>> ListarFamiliasIdAsync();
    }
}