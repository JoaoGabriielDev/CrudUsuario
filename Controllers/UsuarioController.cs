using CrudUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudUsuario.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>{
                new Usuario{Id = 1, Nome = "Joao", DataNascimento = new DateTime(1998, 10, 6)}
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }
    }
}