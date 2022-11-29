using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using BlogPessoal.src.repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogPessoalVS.src.controladores
{
    [ApiController]
    [Route("api/Postagens")]
    [Produces("application/json")]
    public class PostagemControlador : ControllerBase
    {
        #region Atributos
        private readonly IPostagem _repositorio;

        #endregion Atributos


        #region Construtores
        public PostagemControlador(IPostagem repositorio)
        {
            _repositorio = repositorio;
        }
        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Pegar postagem pelo Id
        /// </summary>
        /// <param name="idPostagem">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Retorna a postagem</response>
        /// <response code="404">Postagem não existente</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioModelo))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("id/{idPostagem}")]
        [Authorize]
        public async Task<ActionResult> PegarPostagemPeloIdAsync([FromRoute] int idPostagem)
        {
            var postagem = await _repositorio.PegarPostagemPeloIdAsync(idPostagem);

            if (postagem == null) return NotFound();
            return Ok(postagem);
        }

        /// <summary>
        /// Pegar todas postagens
        /// </summary>
        /// <returns>ActionResult</returns>
        /// <response code="200">Lista de postagens</response>
        /// <response code="204">Lista vazia</response>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> PegarTodasPostagensAsync()
        {
            var lista = await _repositorio.PegarTodasPostagensAsync();

            if (lista.Count < 1) return NoContent();
            
            return Ok(lista);
        }

        /// <summary>
        /// Pegar postagens por pesquisa
        /// </summary>
        /// <param name="titulo">string</param>
        /// <param name="descricaoTema">string</param>
        /// <param name="nomeCriador">string</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Mostra as postagens</response>
        /// <response code="204">Não há postagens</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet("pesquisa")]
        [Authorize]
        public async Task<ActionResult> PegarPostagensPorPesquisaAsync(
            [FromQuery] string titulo,
            [FromQuery] string descricaoTema,
            [FromQuery] string nomeCriador)
        {
            var postagens = await _repositorio.PegarPostagensPorPesquisaAsync(titulo, descricaoTema, nomeCriador);
            
            if (postagens.Count < 1) return NoContent();
            
            return Ok(postagens);
        }

        /// <summary>
        /// Criar nova postagem
        /// </summary>
        /// <param name="postagem">NovoPostagemDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     POST /api/Usuarios
        ///     {
        ///        "titulo": "Como fazer ...",
        ///        "descricao": "Descubra como fazer...",
        ///        "foto": "foto",
        ///        "emailCriador": "mi@gmail.com",
        ///        "descricaoTema": "Curiosidade"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna postagem criada</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(PostagemModelo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> NovaPostagemAsync([FromBody] NovaPostagemDTO postagem)
        {
            if(!ModelState.IsValid) return BadRequest();

            await _repositorio.NovaPostagemAsync(postagem);
            
            return Created($"api/Postagens", postagem);
        }

        /// <summary>
        /// Atualizar Postagem
        /// </summary>
        /// <param name="postagem">AtualizarPostagemDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     PUT /api/Usuarios
        ///     {
        ///        "id": 1,
        ///        "titulo": "Como fazer arroz",    
        ///        "descricao": "Faça arroz...",
        ///        "foto": "foto",
        ///        "descricaoTema": "Culinária"
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Retorna postagem atualizada</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Authorize]
        public async Task<ActionResult> AtualizarPostagemAsync([FromBody] AtualizarPostagemDTO postagem)
        {
            if(!ModelState.IsValid) return BadRequest();

            await _repositorio.AtualizarPostagemAsync(postagem);
            
            return Ok(postagem);
        }

        /// <summary>
        /// Deletar postagem pelo Id
        /// </summary>
        /// <param name="idPostagem">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="204">Postagem deletada</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]   
        [HttpDelete("deletar/{idPostagem}")]
        [Authorize]
        public async Task<ActionResult> DeletarPostagemAsync([FromRoute] int idPostagem)
        {
            await _repositorio.DeletarPostagemAsync(idPostagem);
            return NoContent();
        }

        #endregion
    }
}