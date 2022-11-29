using System;
using System.Threading.Tasks;
using Predio.src.data;
using Predio.src.dtos;
using Predio.src.repositorios;
using Predio.src.modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Predio.src.entidades;

namespace Predio.src.repositorios.implementacoes
{
    public class MoradorRepositorio : IMoradorRepositorio
    {
        #region Atributos
        private readonly PredioContexto _contexto;
        #endregion Atributos

        #region Construtores
        public MoradorRepositorio(PredioContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        #region Metodos 
        public async Task NovoCadastroAsync(Morador modelo)
        {
           await _contexto.Morador.AddAsync(modelo);
           await _contexto.SaveChangesAsync();
        }

        public async Task AtualizarCadastroAsync(Morador morador)
        {
            _contexto.Morador.Update(morador);
            await _contexto.SaveChangesAsync();
        }

        public async Task DeletarCadastroAsync(int id)
        {
            _contexto.Remove(id);
            await _contexto.SaveChangesAsync();
        }

        public async Task<List<Morador>> ListarCadastrosAsync()
        {
            return await _contexto.Morador.ToListAsync();
        }

        public async Task<Morador> ListarCadastrosPorIdAsync(int id)
        {
           return await _contexto.Morador.FindAsync(id);
        }
        #endregion Metodos
    }
}