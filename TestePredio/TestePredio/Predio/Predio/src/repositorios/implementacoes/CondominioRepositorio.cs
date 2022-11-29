using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Predio.src.repositorios;
using Predio.src.dtos;
using Predio.src.modelos;
using Predio.src.data;
using Predio.src.entidades;

namespace Predio.src.repositorios.implementacoes
{
    public class CondominioRepositorio : ICondominioRepositorio
    {
        #region Atributos
        private readonly PredioContexto _contexto;
        #endregion Atributos

        #region Construtores
        public CondominioRepositorio(PredioContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        #region Metodos
        public async Task NovoCadastroAsync(Condominio modelo)
        {
            await _contexto.Condominio.AddAsync(modelo);
            await _contexto.SaveChangesAsync();
        }
    
        public async Task AtualizarCadastroAsync(Condominio condominio)
        {
            _contexto.Condominio.Update(condominio);
            await _contexto.SaveChangesAsync();
        }
        public async Task DeletarCadastroAsync(int id)
        {
            _contexto.Remove(id);
            await _contexto.SaveChangesAsync();
        }

        public async Task<List<Condominio>> ListarCadastrosAsync()
        {
            return await _contexto.Condominio.ToListAsync();
        }

        public async Task<Condominio> ListarCadastrosPorIdAsync(int id)
        {
            return await _contexto.Condominio.FindAsync(id);
        }
        #endregion Metodos
    }
}