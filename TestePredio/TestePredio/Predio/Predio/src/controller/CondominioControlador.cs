using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Predio.src.dtos;
using Predio.src.repositorios;
using Predio.src.modelos;
using Predio.src.service;
using System;

namespace Predio.src.controller
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]    
    public class CondominioController : ControllerBase
    {
        #region Atributos
        private readonly ICondominioService _condominioService;
        #endregion Atributos

        #region Construtores
        public CondominioController(ICondominioService condominioService)
        {
            _condominioService = condominioService;
        }
        #endregion Construtores

        #region Metodos
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NovoCondominioDTO novoCondominio)
        {
            try
            {
                await _condominioService.NovoCondominioAsync(novoCondominio);
                return StatusCode(201, "Condominio cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                return StatusCode(500, "Não foi possível cadastrar o condominio");
            }
        }

        [HttpGet]
        public async Task<ActionResult> ListarCondominiosAsync()
        {            
            return null;
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarCondominioAsync([FromBody] AtualizarCondominioDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _condominioService.AtualizarCondominioAsync(dto);
            return Ok(dto);
        }


        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeletarCondominioAsync([FromRoute] int idCondominio)
        {
            await _condominioService.DeletarCondominioAsync(idCondominio);
            return NoContent();
        }
        #endregion Metodos
    }
}