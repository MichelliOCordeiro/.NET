using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteSofa.src.dtos;
using TesteSofa.src.dtos.Laudos;
using TesteSofa.src.service;

namespace TesteSofa.src.controller
{
    [ApiController]
    [Route("api/Laudos")]
    [Produces("application/json")]
    public class LaudoControlador : ControllerBase
    {
        private readonly ISofaService service;

        public LaudoControlador(ISofaService service)
        {
            this.service = service;
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
                return StatusCode(200, await service.PegarTodosSofas());
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        /// <summary>
        /// Avaliar sofa
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public async Task<ActionResult> AvaliarSofaAsync([FromBody] CriarLaudoDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                await service.AvaliarSofa(dto);
                return StatusCode(200, dto);
            }
            catch (Exception erro)
            {                
                return StatusCode(500, erro.Message);
            }
        }
    }
}
