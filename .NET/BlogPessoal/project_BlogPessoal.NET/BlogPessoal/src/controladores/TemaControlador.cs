using BlogPessoal.src.dtos;
using Microsoft.AspNetCore.Mvc;
using BlogPessoal.src.repositorios;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BlogPessoal.src.modelos;

namespace BlogPessoal.src.controladores
{
    [ApiController]
    [Route("api/Temas")]
    [Produces("application/json")]
    public class TemaControlador : ControllerBase
    {
        #region Atributos
        private readonly ITema _repositorio;

        #endregion Atributos

        #region Construtores
        public TemaControlador(ITema repositorio)
        {
            _repositorio = repositorio;
        }
        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Pegar todos temas
        /// </summary>
        /// <returns>ActionResult</returns>
        /// <response code="200">Lista de temas</response>
        /// <response code="204">Lista vazia</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> PegarTodosTemasAsync()
        {
            var lista = await _repositorio.PegarTodosTemasAsync();

            if (lista.Count < 1) return NoContent();
            
            return Ok(lista);
        }

        /// <summary>
        /// Pegar Tema pelo Id
        /// </summary>
        /// <param name="idTema">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Retorna o Tema</response>
        /// <response code="404">Tema não existe</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("id/{idTema}")]
        [Authorize]
        public async Task<ActionResult> PegarTemaPeloIdAsync([FromRoute] int idTema)
        {
            var tema = await _repositorio.PegarTemaPeloIdAsync(idTema);

            if (tema == null) return NotFound();
            return Ok(tema);
        }
        /// <summary>
        /// Pegar tema pela descrição
        /// </summary>
        /// <param name="descricaoTema">string</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Retorna o tema</response>
        /// <response code="404">Descrição não existente</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet("pesquisa")]
        [Authorize]
        public async Task<ActionResult> PegarTemaPelaDescricaoAsync([FromQuery] string descricaoTema)
        {
            var temas = await _repositorio.PegarTemaPelaDescricaoAsync(descricaoTema);
            if (temas.Count < 1) return NoContent();
            return Ok(temas);
        }

        /// <summary>
        /// Criar novo tema
        /// </summary>
        /// <param name="tema">NovoTemaDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     POST /api/Temas
        ///     {
        ///        "descricao": "Visual Studio",
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna tema criado</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> NovoTemaAsync([FromBody] NovoTemaDTO tema)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _repositorio.NovoTemaAsync(tema);
            return Created($"api/Temas/{tema.Descricao}", tema);
        }

        /// <summary>
        /// Atualizar Tema
        /// </summary>
        /// <param name="tema">AtualizarTemaDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     PUT /api/Temas
        ///     {
        ///        "id": 1,    
        ///        "descricao": "Visual Studio",
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Retorna tema atualizado</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Authorize(Roles = "ADMINISTRADOR")]
        public async Task<ActionResult> AtualizarTemaAsync([FromBody] AtualizarTemaDTO tema)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _repositorio.AtualizarTemaAsync(tema);
            return Ok(tema);
        }

        /// <summary>
        /// Deletar Tema pelo Id
        /// </summary>
        /// <param name="idTema">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="204">Tema deletado</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("deletar/{idTema}")]
        [Authorize(Roles = "ADMINISTRADOR")]
        public async Task<ActionResult> DeletarTemaAsync([FromRoute] int idTema)
        {
            await _repositorio.DeletarTemaAsync(idTema);
            return NoContent();
        }

        #endregion Métodos
    }
}