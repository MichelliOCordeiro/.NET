using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.entidades;
using Predio.src.modelos;
using Predio.src.repositorios;

namespace Predio.src.service.implementacoes
{
    public class MoradorService : IMoradorService
    {
        #region Atributos
        private readonly IMoradorRepositorio _moradorRepositorio;
        #endregion Atributos

        #region Construtores
        public MoradorService(IMoradorRepositorio moradorRepositorio)
        {
            _moradorRepositorio = moradorRepositorio;
        }
        #endregion Construtores

        #region Metodos
         public async Task NovoMoradorAsync(NovoMoradorDTO novoMorador)
        {
            Morador morador = new Morador();
            morador.Nome = novoMorador.Nome;
            morador.Idade = novoMorador.Idade;
            await _moradorRepositorio.NovoCadastroAsync(morador);
        }
        public async Task AtualizarMoradorAsync(AtualizarMoradorDTO atualizarMorador)
        {
            Morador morador = new Morador();
            morador.Id = morador.Id;
            morador.Nome = morador.Nome;
            morador.Idade = morador.Idade;
            await _moradorRepositorio.AtualizarCadastroAsync(morador);
        }

        public Task DeletarMoradorAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> ListarMoradoresIdAsync()
        {
            throw new System.NotImplementedException();
        }
        #endregion Metodos  
    }
}