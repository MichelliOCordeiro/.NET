using System.Collections.Generic;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.models;

namespace TesteSofa.src.repositorios
{
    /// <summary>
    /// <para>Criação de interface de Sofa</para>
    /// <para>By: Michelli Cordeiro</para>
    /// <para>v 1.0</para>
    /// <para>01.09.2022</para>
    /// </summary>
    public interface ISofa
    {
        Task CadastrarNovoSofaAsync(SofaModelo sofa);
        Task AtualizarSofaAsync(SofaModelo sofa);
        Task DeletarSofaAsync(SofaModelo sofa);   
        Task<SofaModelo> PegarSofapeloIdAsync(int id); 
        Task<List<SofaModelo>> PegarTodosSofas(); 
        Task <int> TotalDeAvaliacoesAsync();  
        Task <int> TotalSofaCadastradosAsync();
    }
} 
