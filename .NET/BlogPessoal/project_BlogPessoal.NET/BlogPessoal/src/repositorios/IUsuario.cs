using System.Collections.Generic;
using System.Threading.Tasks;
using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;

namespace BlogPessoal.src.repositorios   
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de usuario</para>
    /// <para>Criado por: Michelli Cordeiro </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface IUsuario
    {
        Task NovoUsuarioAsync(NovoUsuarioDTO usuario);                
        Task AtualizarUsuarioAsync(AtualizarUsuarioDTO Id);
        Task DeletarUsuarioAsync(int Id);
        Task<UsuarioModelo> PegarUsuarioPeloIdAsync (int Id);
        Task<UsuarioModelo> PegarUsuarioPeloEmailAsync(string email);                
        Task<List<UsuarioModelo>> PegarUsuarioPeloNomeAsync(string nome);
    }
}