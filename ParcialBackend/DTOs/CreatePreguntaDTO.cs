using System.ComponentModel.DataAnnotations;

namespace ParcialBackend.DTOs
{
    public class CreatePreguntaDTO
    {
        [Required]
        public required string Enunciado { get; set; }

        [Required]
        public required string Categoria { get; set; }
    }
}
