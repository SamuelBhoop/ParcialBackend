using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcialBackend.Models
{
    public class Respuestas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Contenido { get; set; }

        [Required]
        [ForeignKey("Pregunta")]
        public int PreguntaId { get; set; }

        public Preguntas? Pregunta { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
