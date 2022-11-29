using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.repositorios;

namespace TesteSofa.src.controller
{
    [ApiController]
    [Route("api/Usuario")]
    [Produces("application/json")]
    public class UsuarioControlador : ControllerBase
    {
        #region Atributos
        private readonly IUsuario _repositorio;
        #endregion

        #region Construtores
        public UsuarioControlador(IUsuario repositorio)
        {
            _repositorio = repositorio;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Incluir novo usuario
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> NovoUsuarioAsync([FromBody] NovoUsuarioDTO usuario)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            try
            {
                await _repositorio.NovoUsuarioAsync(usuario);
                return Created($"api/Users", usuario);
            }
            catch(Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        /// <summary>
        /// Atualizar usuario
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpPut]
        public async Task<ActionResult> AtualizarUsuarioAsync([FromBody] AtualizarUsuarioDTO usuario)
        {
            if (!ModelState.IsValid) return BadRequest();

           await _repositorio.AtualizarUsuarioAsync(usuario);
                return Ok(usuario);
        }

        /// <summary>
        /// Deletar usuario
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpDelete("delete/{idUsuario}")]
        public async Task<ActionResult> DeletarUsuarioAsync([FromRoute] int idUsuario)
        {
           await _repositorio.DeletarUsuarioAsync(idUsuario);
            return NoContent();
        }

        /// <summary>
        /// Pegar usuario pelo Id
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet("id/{idUsuario}")]
        public async Task<ActionResult> PegarUsuariopeloIdAsync([FromRoute]int idUsuario)
        {
            try
            {
                var usuario = await _repositorio.PegarUsuariopeloIdAsync(idUsuario);

                if (usuario == null) return NotFound();
                return Ok(usuario);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }  
        #endregion
    }
}