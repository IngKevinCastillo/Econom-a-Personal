using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class RepositorioUsuarios
    {
        string cadena = "Server = .\\SQLEXPRESS;Database=EconomiaPersonal;Trusted_Connection=True";
        SqlConnection conexion = null;
        public RepositorioUsuarios()
        {
            conexion = new SqlConnection(cadena);
        }
        public List<Usuario> SeleccionarRegistros()
        {
            string ssql = "SELECT * FROM Usuarios";
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUsuarios.Add(Mapper(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaUsuarios;
        }
        private Usuario Mapper(SqlDataReader reader)
        {
            return new Usuario
            {
                Cedula = reader.GetString(reader.GetOrdinal("Cedula")),
                P_Nombre = reader.GetString(reader.GetOrdinal("P_Nombre")),
                S_Nombre = reader.GetString(reader.GetOrdinal("S_Nombre")),
                P_Apellido = reader.GetString(reader.GetOrdinal("P_Apellido")),
                S_Apellido = reader.GetString(reader.GetOrdinal("S_Apellido")),
                CorreoPersona = reader.GetString(reader.GetOrdinal("CorreoElectronico")),
                NombreUsuario = reader.GetString(reader.GetOrdinal("Nombre_Usuario")),
                ContraseñaUsuario = reader.GetString(reader.GetOrdinal("Contraseña_Usuario"))
            };
        }
        public bool InsertarUsuario(Usuario usuario)
        {
            try
            {
                string ssql = "INSERT INTO [dbo].[Usuarios]([Cedula],[P_Nombre],[S_Nombre],[P_Apellido],[S_Apellido],[CorreoElectronico],[Nombre_Usuario],[Contraseña_Usuario])" +
                    $"VALUES('{usuario.Cedula}','{usuario.P_Nombre}','{usuario.S_Nombre}','{usuario.P_Apellido}','{usuario.S_Apellido}','{usuario.CorreoPersona}','{usuario.NombreUsuario}','{usuario.ContraseñaUsuario}')";

                SqlCommand cmd = new SqlCommand(ssql, conexion);
                conexion.Open();
                var FilasAfectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (FilasAfectadas > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public Usuario BuscarUsuario(string cedula)
        {
            try
            {
                return SeleccionarRegistros().Find(usuarioAConsultar => usuarioAConsultar.Cedula == cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Usuario BuscarUsuarioNombre(string nombre)
        {
            try
            {
                return SeleccionarRegistros().Find(usuarioAConsultar => usuarioAConsultar.NombreUsuario == nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool EditarUsuario(Usuario usuario)
        {
            try
            {
                string sqql = $"UPDATE [dbo].[Usuarios]" +
                    $"SET [Cedula] = '{usuario.Cedula}',[P_Nombre] = '{usuario.P_Nombre}',[S_Nombre] = '{usuario.S_Nombre}',[P_Apellido] = '{usuario.P_Apellido}'" +
                    $",[S_Apellido] = '{usuario.S_Apellido}',[CorreoElectronico] = '{usuario.CorreoPersona}',[Nombre_Usuario] = '{usuario.NombreUsuario}',[Contraseña_Usuario] = '{usuario.ContraseñaUsuario}" +
                    $"'WHERE Cedula = '{usuario.Cedula}'";
                SqlCommand cmd = new SqlCommand(sqql, conexion);
                conexion.Open();
                var FliaAfectada = cmd.ExecuteNonQuery();
                conexion.Close();
                if (FliaAfectada > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string EliminarUsuario(string cedula)
        {
            try
            {
                string sqql = $"DELETE FROM Usuarios WHERE Cedula = {cedula}";
                SqlCommand cmd = new SqlCommand(sqql, conexion);
                conexion.Open();
                var FliaAfectada = cmd.ExecuteNonQuery();
                conexion.Close();
                if (FliaAfectada > 0) return "Exito al Eliminar Usuario";
                return "Error al Eliminar Usuario";
            }
            catch (Exception ex)
            {
                return $"Error al Eliminar Usuario: {ex.Message}";
            }
        }
    }
}
