using Microsoft.EntityFrameworkCore;
using ParcialBackend.Data;
using ParcialBackend.DTOs;
using ParcialBackend.Interfaces;
using ParcialBackend.Models;

namespace ParcialBackend.Services
{
    public class RespuestaService : IRespuestaService
    {
        private readonly ParcialDbContext _context;

        public RespuestaService(ParcialDbContext context)
        {
            _context = context;
        }

        public async Task<Respuestas> CrearRespuesta(CreateRespuestaDTO dto)
        {
            var pregunta = await _context.Preguntas.FindAsync(dto.PreguntaId);

            if (pregunta == null)
                throw new KeyNotFoundException($"No se encontró la pregunta con Id {dto.PreguntaId}");

            var respuesta = new Respuestas
            {
                Contenido = dto.Contenido,
                PreguntaId = dto.PreguntaId
            };

            _context.Respuestas.Add(respuesta);

            MarcarPreguntaComoResuelta(pregunta);

            await _context.SaveChangesAsync();

            return respuesta;
        }

        private void MarcarPreguntaComoResuelta(Preguntas pregunta)
        {
            pregunta.Estado = "Resuelta";
        }
    }
}
