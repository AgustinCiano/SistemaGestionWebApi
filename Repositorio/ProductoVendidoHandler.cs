using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionWebApi.Modelos
{
    internal class ProductoVendidoHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



        // ELIMINAR PRODUCTO


        public static int DeleteProductoVendido(long idProducto)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("DELETE FROM ProductoVendido WHERE IdProducto = @idProducto", conn);
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    conn.Open();
                    return comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("" + ex.Message);
                    return -1;
                }


            }
        }



        // CREAR VENTA

        public static int CrearVenta(ProductoVendido productoVendido)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ProductoVendido(Stock, IdProducto, IdVenta) VALUES (@stock, @idProducto, @idVenta)", conn);

                comando.Parameters.AddWithValue("@stock", productoVendido.stock);
                comando.Parameters.AddWithValue("@idProducto", productoVendido.idProducto);
                comando.Parameters.AddWithValue("@idVenta", productoVendido.idVenta);

                conn.Open();
                return comando.ExecuteNonQuery();
            }
        }






        //public static List<ProductoVendido> ObtenerProductosVendidosIdVenta()
        //{
        //    List<ProductoVendido> productos = new List<ProductoVendido>();
        //    using (SqlConnection conn = new SqlConnection(cadenaConexion))
        //    {
        //        SqlCommand comando2 = new SqlCommand("SELECT * FROM ProductoVendido WHERE IdVenta=@idVenta", conn);
        //        comando2.Parameters.AddWithValue("@idVenta", 1);

        //        conn.Open();

        //        SqlDataReader reader = comando2.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                ProductoVendido productoTemporal = new ProductoVendido();
        //                productoTemporal.Id = reader.GetInt64(0);
        //                productoTemporal.Stock = reader.GetInt32(1);
        //                productoTemporal.IdProducto = reader.GetInt64(2);
        //                productoTemporal.IdVenta = reader.GetInt64(3);
                        

        //                productos.Add(productoTemporal);
        //            }
        //        }
        //        return productos;


        //    }

        //}
    }
}
