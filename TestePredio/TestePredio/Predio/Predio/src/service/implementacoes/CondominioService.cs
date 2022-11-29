using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.service;
using Predio.src.modelos;
using Predio.src.data;
using Predio.src.entidades;
using Predio.src.repositorios;

namespace Predio.src.service.implementacoes
{
    public class CondominioService : ICondominioService
    {   
        #region Atributos
        private readonly ICondominioRepositorio _condominioRepositorio;
        #endregion Atributos

        #region Construtores
        public CondominioService(ICondominioRepositorio condominioRepositorio)
        {
            _condominioRepositorio = condominioRepositorio;
        }
        #endregion Construtores

        #region Metodos
        public async Task NovoCondominioAsync(NovoCondominioDTO novoCondominio)
        {
            Condominio condominio = new Condominio();
            condominio.Nome = novoCondominio.Nome;
            condominio.Bairro = novoCondominio.Bairro;
            condominio.AreaTotal = novoCondominio.AreaTotal;
            condominio.ValorIPTU = novoCondominio.ValorIPTU;
            await _condominioRepositorio.NovoCadastroAsync(condominio);
        }
        public async Task AtualizarCondominioAsync(AtualizarCondominioDTO atualizarCondominio)
        {
            Condominio condominio = new Condominio();
            condominio.Id = atualizarCondominio.Id;
            condominio.Nome = atualizarCondominio.Nome;
            condominio.Bairro = atualizarCondominio.Bairro;
            condominio.AreaTotal = atualizarCondominio.AreaTotal;
            condominio.ValorIPTU = atualizarCondominio.ValorIPTU;
            await _condominioRepositorio.AtualizarCadastroAsync(condominio);
        }

        public Task DeletarCondominioAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CondominioModelo>> ListarCondominiosIdAsync()
        {
            throw new System.NotImplementedException();
        }
        #endregion Metodos
    }
}
        