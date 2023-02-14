using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        // CREAR PRODUCTO //

        [HttpPost]
        public void InsertarProducto(Producto producto)
        {                            
           ProductoHandler.InsertarProducto(producto);
        }



        // MODIFICAR PRODUCTO

        [HttpPut]
        public void ModificarProducto(Producto producto)
        {
            ProductoHandler.ModificarProducto(producto);
        }



        // ELIMINAR PRODUCTO

        [HttpDelete("{id}")]

        public string EliminarProducto(long id)
        {
            return ProductoHandler.DeleteProducto(id) == 1 ? "Producto Eliminado" : "No se pudo eliminar";
        }

        
        
    }
}
