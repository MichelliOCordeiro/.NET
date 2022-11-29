using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteSofa.src.data;
using TesteSofa.src.repositorios;
using TesteSofa.src.dtos;
using TesteSofa.src.models;
using TesteSofa.src.dtos.Laudos;

namespace TesteSofa.src.repositorios.implementacoes
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por implementar ISofa</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class SofaRepositorio : ISofa
    {
        #region Atributos
        private readonly SofaContexto _contexto;
        #endregion Atributos

        #region Construtores
        public SofaRepositorio(SofaContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        #region Metodos    
        public async Task CadastrarNovoSofaAsync(SofaModelo sofa)
        {
            await _contexto.Sofa.AddAsync(sofa);         
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para atualizar um sofa</para>
        /// </summary>
        public async Task AtualizarSofaAsync(SofaModelo sofa)
        {
            _contexto.Entry(sofa).State = EntityState.Added;
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para deletar um sofa</para>
        /// </summary>
        public async Task DeletarSofaAsync(SofaModelo sofa)
        {
            _contexto.Sofa.Remove(sofa);
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar um sofa pelo Id</para>
        /// </summary>
        public async Task<SofaModelo> PegarSofapeloIdAsync(int id)
        {
            return await _contexto.Sofa.FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar todos os sofas</para>
        /// </summary>
        public async Task<List<SofaModelo>> PegarTodosSofas()
        {
            return await _contexto.Sofa.ToListAsync();            
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar o total de avaliações</para>
        /// </summary>
        public async Task<int> TotalDeAvaliacoesAsync()
        {
            return await _contexto.Sofa.CountAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar o total de sofas cadastrados</para>
        /// </summary>
        public async Task<int> TotalSofaCadastradosAsync()
        {
            return await _contexto.Sofa.CountAsync();           
        }
        #endregion Metodos
    }
}