using System.ComponentModel.DataAnnotations;

namespace ParcialBackend.DTOs
{
    public class CreateRespuestaDTO
    {
        [Required]
        public required string Contenido { get; set; }

        [Required]
        public int PreguntaId { get; set; }
    }
}
