using Microsoft.EntityFrameworkCore;
using ParcialBackend.Data;
using ParcialBackend.DTOs;
using ParcialBackend.Interfaces;
using ParcialBackend.Models;

namespace ParcialBackend.Services
{
    public class PreguntaService : IPreguntaService
    {
        private readonly ParcialDbContext _context;

        public PreguntaService(ParcialDbContext context)
        {
            _context = context;
        }

        public async Task<Preguntas> CrearPregunta(CreatePreguntaDTO dto)
        {
            var pregunta = new Preguntas
            {
                Enunciado = dto.Enunciado,
                Categoria = dto.Categoria
            };

            _context.Preguntas.Add(pregunta);
            await _context.SaveChangesAsync();

            return pregunta;
        }

        public async Task<List<Preguntas>> ObtenerPreguntasPorEstado(string estado)
        {
            return await _context.Preguntas
                .Where(p => p.Estado == estado)
                .ToListAsync();
        }
    }
}
