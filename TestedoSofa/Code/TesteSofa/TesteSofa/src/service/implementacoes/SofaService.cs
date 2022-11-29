using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.dtos.Laudos;
using TesteSofa.src.models;
using TesteSofa.src.repositorios;
using TesteSofa.src.repositorios.implementacoes;

namespace TesteSofa.src.service.implementacoes
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por implementar ISofaService</para>
    /// <para>Criado por: Michelli Cordeiro</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/09/2022</para>
    /// </summary> 
    public class SofaService : ISofaService
    {
        private readonly ISofa _sofarepositorio;
        private readonly IUsuario _usuarioRepositorio;

        public SofaService(ISofa sofarepositorio, IUsuario usuarioRepositorio)
        {
            _sofarepositorio = sofarepositorio;
            _usuarioRepositorio = usuarioRepositorio;
        }

        /// <summary>
        /// <para>Resumo: Método responsável por atualizar um sofa</para>
        /// </summary>
        public async Task AtualizarSofaAsync(AtualizarSofaDTO dto)
        {
            SofaModelo sofa = new SofaModelo();
            sofa.Id = dto.Id;
            sofa.Nome = dto.Nome;
            sofa.Foto = dto.Foto;
            sofa.QtdeLugares = dto.QtdeLugares;
            sofa.Comprimento = dto.Comprimento;
            sofa.Largura = dto.Largura;
            sofa.Profundidade = dto.Profundidade;
            sofa.Avaliacao = dto.Avaliacao;
            sofa.AvaliadoPor = dto.AvaliadoPor;
            sofa.DataAvaliacao = dto.DataAvaliacao;

            await _sofarepositorio.AtualizarSofaAsync(sofa);
        }

        /// <summary>
        /// <para>Resumo: Método responsável por avaliar um sofa</para>
        /// </summary>
        public async Task AvaliarSofa(CriarLaudoDTO dto)
        {
            var usuario = await _usuarioRepositorio.PegarUsuariopeloIdAsync(dto.UsuarioId);

            if (!usuario.Inspetor)
            {
                throw new Exception("Usuario não tem permissão para fazer avaliação");
            }

            var sofadto = await _sofarepositorio.PegarSofapeloIdAsync(dto.SofaId);
            SofaModelo sofa = new SofaModelo();
            sofa.Id = sofadto.Id;


            if (dto.Aprovado.ToUpper() == "SIM")
            {
                sofa.Avaliacao = true;
            }
            else
            {
                sofa.Avaliacao = false;
            }

            sofa.AvaliadoPor = usuario.Id;
            sofa.DataAvaliacao = DateTime.Now;

            await _sofarepositorio.AtualizarSofaAsync(sofa);
        }

        /// <summary>
        /// <para>Resumo: Método responsável por deletar um sofa</para>
        /// </summary>
        public async Task DeletarSofaAsync(int id)
        {
            var sofa = await _sofarepositorio.PegarSofapeloIdAsync(id);
            await _sofarepositorio.DeletarSofaAsync(sofa);
        }

        /// <summary>
        /// <para>Resumo: Método responsável por pegar um sofa pelo Id</para>
        /// </summary>
        public async Task<ConsultarSofaDTO> PegarSofapeloIdAsync(int id)
        {

            var s = await _sofarepositorio.PegarSofapeloIdAsync(id);
            var dto = new ConsultarSofaDTO();

            dto.Id = s.Id;
            dto.Nome = s.Nome;
            dto.Foto = s.Foto;
            dto.QtdeLugares = s.QtdeLugares;
            dto.Comprimento = s.Comprimento;
            dto.Largura = s.Largura;
            dto.Profundidade = s.Profundidade;
            dto.Avaliacao = s.Avaliacao;
            dto.AvaliadoPor = s.AvaliadoPor;
            dto.DataAvaliacao = s.DataAvaliacao;

            return dto;

        }

        /// <summary>
        /// <para>Resumo: Método responsável por pegar todos os sofas</para>
        /// </summary>
        public async Task<List<ConsultarSofaDTO>> PegarTodosSofas()
        {
            var lista = new List<ConsultarSofaDTO>();
            var sofas = await _sofarepositorio.PegarTodosSofas();

            foreach (var item in sofas)
            {
                var dto = new ConsultarSofaDTO();

                dto.Id = item.Id;
                dto.Nome = item.Nome;
                dto.Foto = item.Foto;
                dto.QtdeLugares = item.QtdeLugares;
                dto.Comprimento = item.Comprimento;
                dto.Largura = item.Largura;
                dto.Profundidade = item.Profundidade;
                dto.Avaliacao = item.Avaliacao;
                dto.AvaliadoPor = item.AvaliadoPor;
                dto.DataAvaliacao = item.DataAvaliacao;

                lista.Add(dto);
            }

            return lista;
        }

        /// <summary>
        /// <para>Resumo: Método responsável por registar um sofa</para>
        /// </summary>
        public async Task RegistrarSofaAsync(NovoSofaDTO dto)
        {
            SofaModelo sofa = new SofaModelo();
            sofa.Nome = dto.Nome;
            sofa.Foto = dto.Foto;
            sofa.QtdeLugares = dto.QtdeLugares;
            sofa.Comprimento = dto.Comprimento;
            sofa.Largura = dto.Largura;
            sofa.Profundidade = dto.Profundidade;
            sofa.Avaliacao = dto.Avaliacao;
            sofa.AvaliadoPor = dto.AvaliadoPor;
            sofa.DataAvaliacao = dto.DataAvaliacao;

            await _sofarepositorio.CadastrarNovoSofaAsync(sofa);
        }

        /// <summary>
        /// <para>Resumo: Método responsável por passar o total de avaliações</para>
        /// </summary>
        public Task<int> TotalDeAvaliacoesAsync()
        {
            return _sofarepositorio.TotalDeAvaliacoesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método responsável por passar o total de sofas cadastrados</para>
        /// </summary>
        public Task<int> TotalSofaCadastradosAsync()
        {
            return _sofarepositorio.TotalSofaCadastradosAsync();
        }
    }
}
