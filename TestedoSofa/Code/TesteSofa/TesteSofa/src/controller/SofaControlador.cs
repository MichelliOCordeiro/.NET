using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.repositorios;
using TesteSofa.src.service;

namespace TesteSofa.src.controller
{
    [ApiController]
    [Route("api/Sofa")]
    [Produces("application/json")]
    public class SofaControlador : ControllerBase
    {
        #region Atributos
        private readonly ISofaService service;

        public SofaControlador(ISofaService service)
        {
            this.service = service;
        }
        #endregion

        #region Construtores

        #endregion

        #region Métodos

        /// <summary>
        /// Registrar novo sofa
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public async Task<ActionResult> RegistrarSofaAsync([FromBody] NovoSofaDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                await service.RegistrarSofaAsync(dto);
                return Ok(dto);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);               
            }
        }

        /// <summary>
        /// Atualizar sofa
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpPut]
        public async Task<ActionResult> AtualizarSofaAsync([FromBody] AtualizarSofaDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                await service.AtualizarSofaAsync(dto);
                return Ok(dto);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        /// <summary>
        /// Deletar postagem pelo Id
        /// </summary>
        /// <param name="idSofa">int</param>
        /// <returns>ActionResult</returns>
        [HttpDelete("delete/{idSofa}")]
        public async Task<ActionResult> DeletarSofaAsync([FromRoute] int idSofa)
        {
            try
            {
                await service.DeletarSofaAsync(idSofa);
                return NoContent();
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        /// <summary>
        /// Pegar sofá pelo Id
        /// </summary>
        /// <param name="idSofa">int</param>
        /// <returns>ActionResult</returns>
        [HttpGet("id/{idSofa}")]
        public async Task<ActionResult> PegarSofapeloIdAsync([FromRoute]int idSofa)
        {
            try
            {
                var sofa = await service.PegarSofapeloIdAsync(idSofa);

                if (sofa == null) return NotFound();
                return Ok(sofa);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        /// <summary>
        /// Pegar todos os sofás
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet]
        public async Task<ActionResult> PegarTodosSofas()
        {
            try
            {
                var lista = await service.PegarTodosSofas();
                if (lista.Count < 1) return NoContent();
                return Ok(lista);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        /// <summary>
        /// Pegar total de avaliações realizadas
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet]
        public async Task<ActionResult> TotaldeAvaliacoes()
        {
            try
            {
                var total = await service.TotalDeAvaliacoesAsync();
                if (total < 1) return NoContent();
                return Ok(total);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }

        }

        /// <summary>
        /// Pegar total de sofas que estão cadasstrados
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet]
        public async Task<ActionResult> TotalSofaCadastrados()
        {

            try
            {
                var total = await service.TotalSofaCadastradosAsync();
                
                if (total < 1) return NoContent();

                return Ok(total);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }

        }
        #endregion
    }
}