using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Predio.src.dtos;
using Predio.src.repositorios;
using Predio.src.service;

namespace Predio.src.controller
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class MoradorController : ControllerBase
    {
        #region Atributos
        private readonly IMoradorService _moradorService;
        #endregion Atributos

        #region Construtores
        public MoradorController(IMoradorService moradorService)
        {
            _moradorService = moradorService;
        }
        #endregion Constructores

        #region Metodos 
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]NovoMoradorDTO novoMorador)
        {
            try
            {
                await _moradorService.NovoMoradorAsync(novoMorador);
                return StatusCode(201, "Morador cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                return StatusCode(500, "Não foi possível cadastrar o morador");
            }
        }

        [HttpGet]
        public async Task<ActionResult> ListarMoradoresIdAsync()
        {            
            return null;
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarMoradorAsync([FromBody] AtualizarMoradorDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _moradorService.AtualizarMoradorAsync(dto);
            return Ok(dto);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeletarMoradorAsync([FromRoute] int idMorador)
        {
           await _moradorService.DeletarMoradorAsync(idMorador);
           return NoContent();
        }
        #endregion Metodos
    }
}