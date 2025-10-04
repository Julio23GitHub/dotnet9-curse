using System.ComponentModel.DataAnnotations;

namespace Curso_dotnet_9.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
