using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.models;

namespace TesteSofa.src.repositorios
{
    /// <summary>
    /// <para>Criação de interface de Usuario</para>
    /// <para>By: Michelli Cordeiro</para>
    /// <para>v 1.0</para>
    /// <para>30.08.2022</para>
    /// </summary>
    public interface IUsuario
    {
        Task NovoUsuarioAsync(NovoUsuarioDTO usuario);
        Task AtualizarUsuarioAsync(AtualizarUsuarioDTO usuario);
        Task DeletarUsuarioAsync(int id);
        Task<UsuarioModelo> PegarUsuariopeloIdAsync(int id);     
    }
}