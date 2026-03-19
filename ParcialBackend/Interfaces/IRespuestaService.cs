using ParcialBackend.DTOs;
using ParcialBackend.Models;

namespace ParcialBackend.Interfaces
{
    public interface IRespuestaService
    {
        Task<Respuestas> CrearRespuesta(CreateRespuestaDTO dto);
    }
}
