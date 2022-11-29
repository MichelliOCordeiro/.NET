using System.Collections.Generic;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.dtos.Laudos;
using TesteSofa.src.models;

namespace TesteSofa.src.service
{
    /// <summary>
    /// <para>Criação de interface de Sofa Service</para>
    /// <para>By: Michelli Cordeiro</para>
    /// <para>v 1.0</para>
    /// <para>01.09.2022</para>
    /// </summary>
    public interface ISofaService
    {
        Task RegistrarSofaAsync(NovoSofaDTO dto);
        Task AtualizarSofaAsync(AtualizarSofaDTO dto);
        Task DeletarSofaAsync(int id);
        Task<ConsultarSofaDTO> PegarSofapeloIdAsync(int id);
        Task<List<ConsultarSofaDTO>> PegarTodosSofas();
        Task AvaliarSofa(CriarLaudoDTO dto);
        Task <int> TotalDeAvaliacoesAsync();
        Task <int> TotalSofaCadastradosAsync();
    }
}
