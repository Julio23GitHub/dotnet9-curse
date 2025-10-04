using Curso_dotnet_9.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Curso_dotnet_9.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            return new List<Autor>
            {

                new Autor { Id = 1, Nombre = "Gabriel", Apellido = "García Márquez", FechaNacimiento = new DateTime(1927, 3, 6) },
                new Autor { Id = 2, Nombre = "Marta", Apellido = "García Márquez", FechaNacimiento = new DateTime(1927, 3, 6) },

            };
        }

    }
}
