using Microsoft.EntityFrameworkCore;
using ParcialBackend.Models;

namespace ParcialBackend.Data
{
    public class ParcialDbContext : DbContext
    {
        public ParcialDbContext(DbContextOptions<ParcialDbContext> options) : base(options)
        {
        }

        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }
    }
}
