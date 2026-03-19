using Microsoft.AspNetCore.Mvc;
using ParcialBackend.DTOs;
using ParcialBackend.Interfaces;

namespace ParcialBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : ControllerBase
    {
        private readonly IPreguntaService _preguntaService;

        public PreguntasController(IPreguntaService preguntaService)
        {
            _preguntaService = preguntaService;
        }

        [HttpPost]
        public async Task<IActionResult> CrearPregunta([FromBody] CreatePreguntaDTO dto)
        {
            var pregunta = await _preguntaService.CrearPregunta(dto);
            return CreatedAtAction(null, new { id = pregunta.Id }, pregunta);
        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> ObtenerPorEstado(string estado)
        {
            var preguntas = await _preguntaService.ObtenerPreguntasPorEstado(estado);
            return Ok(preguntas);
        }
    }
}
