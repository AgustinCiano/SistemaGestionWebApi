using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionWebApi.Modelos
{
    internal static class UsuarioHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



        // MODIFICAR USUARIO
        public static int ModificarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("UPDATE Usuario SET Nombre = @nombre, Apellido = @apellido, NombreUsuario = @nombreUsuario, Contraseña = @contraseña, Mail = @mail WHERE Id = @id", conn);

                SqlParameter idParam = new SqlParameter("id", usuario.Id);
                SqlParameter nombreParam = new SqlParameter("nombre", usuario.Nombre);
                SqlParameter apellidoParam = new SqlParameter("apellido", usuario.Apellido);
                SqlParameter nombreUsuarioParam = new SqlParameter("nombreUsuario", usuario.NombreUsuario);
                SqlParameter contraseñaParam = new SqlParameter("contraseña", usuario.Contraseña);
                SqlParameter mailParam = new SqlParameter("mail", usuario.Mail);

                comando.Parameters.Add(idParam);
                comando.Parameters.Add(nombreParam);
                comando.Parameters.Add(apellidoParam);
                comando.Parameters.Add(nombreUsuarioParam);
                comando.Parameters.Add(contraseñaParam);
                comando.Parameters.Add(mailParam);

                conn.Open();
                return comando.ExecuteNonQuery();
            }
        }







        //public static int InsertarUsuario(Usuario usuario)
        //{
        //    using (SqlConnection conn = new SqlConnection(cadenaConexion))
        //    {
        //        SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
        //            "VALUES (@nombre, @apellido, @nombreUsuario, @contrasena, @mail)", conn);


        //        SqlParameter nombreParam = new SqlParameter("nombre", usuario.Nombre);
        //        SqlParameter apellidoParam = new SqlParameter("apellido", usuario.Apellido);
        //        SqlParameter nombreUsuParam = new SqlParameter("nombreUsuario", usuario.NombreUsuario);
        //        SqlParameter passwParam = new SqlParameter("contrasena", usuario.Contraseña);
        //        SqlParameter mailParam = new SqlParameter("mail", usuario.Mail);

        //        cmd.Parameters.Add(nombreParam);
        //        cmd.Parameters.Add(apellidoParam);
        //        cmd.Parameters.Add(nombreUsuParam);
        //        cmd.Parameters.Add(passwParam);
        //        cmd.Parameters.Add(mailParam);

        //        conn.Open();
        //        return cmd.ExecuteNonQuery();
        //    }
        //}

        //public static Usuario Login(string usuario, string contraseña)
        //{
        //    using (SqlConnection conn = new SqlConnection(cadenaConexion))
        //    {
        //        SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE NombreUsuario = @usuario AND Contraseña = @contraseña", conn);

                
        //        SqlParameter parameterUsuario = new SqlParameter();
        //        parameterUsuario.ParameterName = "usuario";
        //        parameterUsuario.SqlValue = SqlDbType.VarChar;
        //        parameterUsuario.Value = usuario;

        //        SqlParameter parameterContraseña = new SqlParameter();
        //        parameterContraseña.ParameterName = "contraseña";
        //        parameterContraseña.SqlValue = SqlDbType.VarChar;
        //        parameterContraseña.Value = contraseña;

                
        //        command.Parameters.Add(parameterUsuario);
        //        command.Parameters.Add(parameterContraseña);

        //        conn.Open();

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            if (reader.HasRows)
        //            {
        //                Usuario usuarioEncontrado = new Usuario();
        //                reader.Read();
        //                usuarioEncontrado.Nombre = reader.GetString(1);
        //                usuarioEncontrado.Apellido = reader.GetString(2);
        //                usuarioEncontrado.NombreUsuario = reader.GetString(3);
        //                usuarioEncontrado.Mail = reader.GetString(5);

                                                

        //                return usuarioEncontrado;
                        
        //            }
        //        }
        //        return null;
        //    }
        //}



    }
}


