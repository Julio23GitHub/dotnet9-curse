using Curso_dotnet_9.Entities;
using Microsoft.EntityFrameworkCore;

namespace Curso_dotnet_9.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
