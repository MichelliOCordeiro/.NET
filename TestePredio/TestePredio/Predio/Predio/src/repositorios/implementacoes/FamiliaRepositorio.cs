using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Predio.src.repositorios;
using Predio.src.data;
using Predio.src.dtos;
using Predio.src.modelos;
using Predio.src.entidades;

namespace Predio.src.repositorios.implementacoes
{
    public class FamiliaRepositorio : IFamiliaRepositorio
    {
        #region Atributos
        private readonly PredioContexto _contexto;
        #endregion Atributos

        #region Construtores
        public FamiliaRepositorio(PredioContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        #region Metodos

        public async Task NovoCadastroAsync(Familia modelo)
        {
            await _contexto.Familia.AddAsync(modelo);
            await _contexto.SaveChangesAsync();
        }

        public async Task AtualizarCadastroAsync(Familia familia)
        {
            _contexto.Familia.Update(familia);
            await _contexto.SaveChangesAsync();
        }
        public async Task DeletarCadastroAsync(int id)
        {
            _contexto.Remove(id);
            await _contexto.SaveChangesAsync();
        }

        public async Task<List<Familia>> ListarCadastrosAsync()
        {
            return await _contexto.Familia
                .ToListAsync();
        }
        public async Task<Familia> ListarCadastrosPorIdAsync(int id)
        {
            return await _contexto.Familia.FindAsync(id);
        }
        #endregion Metodos
    }
}