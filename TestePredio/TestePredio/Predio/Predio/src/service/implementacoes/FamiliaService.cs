using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.entidades;
using Predio.src.modelos;
using Predio.src.repositorios;

namespace Predio.src.service.implementacoes
{
    public class FamiliaService : IFamiliaService
    {
        #region Atributos
        private readonly IFamiliaRepositorio _familiaRepositorio;
        #endregion Atributos

        #region Construtores
        public FamiliaService(IFamiliaRepositorio familiaRepositorio)
        {
            _familiaRepositorio = familiaRepositorio;
        }
        #endregion Construtores

        #region Metodos
        public async Task NovaFamiliaAsync(NovaFamiliaDTO novafamilia)
        {
            Familia familia = new Familia();
            familia.Nome = novafamilia.Nome;
            familia.Apto = novafamilia.Apto;
            familia.AreaApto = novafamilia.AreaApto;
            familia.IPTUprop = novafamilia.IPTUprop;
            await _familiaRepositorio.NovoCadastroAsync(familia);
        }
        public async Task AtualizarFamiliaAsync(AtualizarFamiliaDTO atualizarFamilia)
        {
            Familia familia = new Familia();
            familia.Id = atualizarFamilia.Id;
            familia.Nome = atualizarFamilia.Nome;
            familia.Apto = atualizarFamilia.Apto;
            await _familiaRepositorio.AtualizarCadastroAsync(familia);
        }

        public Task DeletarFamiliaAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> ListarFamiliasIdAsync()
        {
            throw new System.NotImplementedException();
        }
        #endregion Metodos      
    }
}