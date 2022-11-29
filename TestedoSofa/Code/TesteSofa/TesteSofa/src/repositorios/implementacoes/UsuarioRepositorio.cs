using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TesteSofa.src.data;
using TesteSofa.src.repositorios;
using TesteSofa.src.dtos;
using TesteSofa.src.models;
using System;

namespace TesteSofa.src.repositorios.implementacoes
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por implementar IUsuario</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary>  

    public class UsuarioRepositorio : IUsuario
    {
        #region Atributos
        private readonly SofaContexto _contexto;
        #endregion Atributos

        #region Construtores
        public UsuarioRepositorio(SofaContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        #region Metodos

        /// <summary>
        /// <para>Resumo: Método assíncrono para adicionar um usuario</para>
        /// </summary>
        /// <param name="usuario">NovoUsuarioDTO</param>
        public async Task NovoUsuarioAsync(NovoUsuarioDTO usuario)
        {
            await _contexto.Usuario.AddAsync(new UsuarioModelo
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha, 
                Inspetor = usuario.Inspetor       
            });
           await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para atualizar um usuario</para>
        /// </summary>
        /// <param name="usuario">AtualizarUsuarioDTO</param>
        public async Task AtualizarUsuarioAsync(AtualizarUsuarioDTO usuario)
        {
            var usuarioModelo = await PegarUsuariopeloIdAsync(usuario.Id);
            usuarioModelo.Nome = usuario.Nome;
            usuarioModelo.Senha = usuario.Senha;
            _contexto.Usuario.Update(usuarioModelo);
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para deletar um usuario</para>
        /// </summary>
        /// <param name="id"></param>
        public async Task DeletarUsuarioAsync(int id)
        {
            _contexto.Usuario.Remove(await PegarUsuariopeloIdAsync(id));
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar um usuario pelo Id</para>
        /// </summary>
        /// <param name="id"></param>
        public async Task<UsuarioModelo> PegarUsuariopeloIdAsync(int id)
        {
            return await _contexto.Usuario
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        #endregion Metodos
    }
}