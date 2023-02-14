using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {


        // ELIMINAR PRODUCTO



        [HttpDelete("{idProducto}")]

        public string EliminarProducto(long idProducto)
        {
            return ProductoVendidoHandler.DeleteProductoVendido(idProducto) == 1 ? "Producto Eliminado" : "No se pudo eliminar";
        }
        
    }
}
