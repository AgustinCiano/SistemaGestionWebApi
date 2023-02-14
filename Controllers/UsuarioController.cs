using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //[HttpGet("{usuario}/{contraseña}")]
        //public Usuario Login(string usuario, string contraseña)
        //{
        //    return UsuarioHandler.Login(usuario, contraseña);

        //}


        //[HttpPost]
        //public void CrearUsuario(Usuario usuario)
        //{
        //    UsuarioHandler.InsertarUsuario(usuario);
        //}



        // MODIFICAR USUARIO

        [HttpPut]

        public void ModificarUsuario(Usuario usuario)
        {
            UsuarioHandler.ModificarUsuario(usuario);
        }
    }
}
