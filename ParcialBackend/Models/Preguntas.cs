using System.ComponentModel.DataAnnotations;

namespace ParcialBackend.Models
{
    public class Preguntas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Enunciado { get; set; }

        [Required]
        public required string Categoria { get; set; }

        public string Estado { get; set; } = "Sin resolver";
    }
}
