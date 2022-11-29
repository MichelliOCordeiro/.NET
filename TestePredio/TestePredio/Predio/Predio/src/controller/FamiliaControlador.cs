using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.repositorios;
using Predio.src.service;
using System;

namespace Predio.src.controller
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class FamiliaController : ControllerBase
    {
        #region Atributos
        private readonly IFamiliaService _familiaService;
        #endregion Atributos

        #region Construtores
        public FamiliaController(IFamiliaService familiaService)
        {
            _familiaService = familiaService;
        }
        #endregion Construtores

        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] NovaFamiliaDTO novaFamilia)
        {
            try
            {
                await _familiaService.NovaFamiliaAsync(novaFamilia);
                return StatusCode(201, "Familia cadastrada com sucesso");
            }
            catch (Exception erro)
            {
                return StatusCode(500, "Não foi possível cadastrar a familia");
            }
        }

        [HttpGet("id/{idFamilia}")]
        public async Task<ActionResult> ListarFamiliasIdAsync()
        {
            return null;
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarFamiliaAsync([FromBody] AtualizarFamiliaDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _familiaService.AtualizarFamiliaAsync(dto);
            return Ok(dto);
        }


        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeletarFamiliaAsync([FromRoute] int idFamilia)
        {
            await _familiaService.DeletarFamiliaAsync(idFamilia);
            return NoContent();
        }
    }
}