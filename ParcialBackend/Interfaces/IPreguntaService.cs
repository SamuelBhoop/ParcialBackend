using ParcialBackend.DTOs;
using ParcialBackend.Models;

namespace ParcialBackend.Interfaces
{
    public interface IPreguntaService
    {
        Task<Preguntas> CrearPregunta(CreatePreguntaDTO dto);
        Task<List<Preguntas>> ObtenerPreguntasPorEstado(string estado);
    }
}
