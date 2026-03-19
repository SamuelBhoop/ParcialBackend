using Microsoft.AspNetCore.Mvc;
using ParcialBackend.DTOs;
using ParcialBackend.Interfaces;

namespace ParcialBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestasController : ControllerBase
    {
        private readonly IRespuestaService _respuestaService;

        public RespuestasController(IRespuestaService respuestaService)
        {
            _respuestaService = respuestaService;
        }

        [HttpPost]
        public async Task<IActionResult> CrearRespuesta([FromBody] CreateRespuestaDTO dto)
        {
            try
            {
                var respuesta = await _respuestaService.CrearRespuesta(dto);
                return CreatedAtAction(null, new { id = respuesta.Id }, respuesta);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
