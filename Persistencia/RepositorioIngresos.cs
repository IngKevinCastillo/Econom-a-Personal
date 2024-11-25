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
    public class RepositorioIngresos
    {
        RepositorioUsuarios usuarios_BD = new RepositorioUsuarios();
        string cadena = "Server = .\\SQLEXPRESS;Database=EconomiaPersonal;Trusted_Connection=True";
        SqlConnection conexion = null;
        public RepositorioIngresos()
        {
            conexion = new SqlConnection(cadena);
        }
        public List<Ingreso> SeleccionarRegistros()
        {
            string ssql = "SELECT * FROM Ingresos";
            List<Ingreso> listaIngresos = new List<Ingreso>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaIngresos.Add(Mapper(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en obtener Datos: " + ex.ToString());
            }
            finally
            {
                conexion.Close();
            }

            return listaIngresos;
        }

        private Ingreso Mapper(SqlDataReader reader)
        {
            return new Ingreso
            {
                Usuario_Ingreso = usuarios_BD.BuscarUsuario(reader.GetString(reader.GetOrdinal("Cedula"))),
                IdIngreso = reader.GetString(reader.GetOrdinal("Id_Ingreso")),
                DescripcionIngreso = reader.GetString(reader.GetOrdinal("Descripcion_Ingreso")),
                FechaIngreso = reader.GetDateTime(reader.GetOrdinal("Fecha_Ingreso")),
                Monto = (double)reader.GetDecimal(reader.GetOrdinal("Monto"))
            };
        }


        public bool InsertarIngreso(Ingreso ingreso)
        {
            try
            {
                string ssql = "INSERT INTO [dbo].[Ingresos]([Id_Ingreso],[Descripcion_Ingreso],[Fecha_Ingreso],[Monto],[Cedula])" +
                    $"VALUES('{ingreso.IdIngreso}','{ingreso.DescripcionIngreso}',CAST('{ingreso.FechaIngreso.ToString("yyyy-MM-dd")}' AS DATE),'{ingreso.Monto}','{ingreso.Usuario_Ingreso.Cedula}')";

                SqlCommand cmd = new SqlCommand(ssql, conexion);
                conexion.Open();
                var FilasAfectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (FilasAfectadas > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Ingreso BuscarIngreso(string id)
        {
            try
            {
                return SeleccionarRegistros().Find(IngresoAConsultar => IngresoAConsultar.IdIngreso == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool EliminarIngreso(string id)
        {
            try
            {
                string sqql = "DELETE FROM [dbo].[Ingresos]" +
                    $"WHERE Id_Ingreso = {id};";
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
        public bool EditarIngreso(Ingreso ingreso)
        {
            try
            {
                string sqql = "UPDATE [dbo].[Ingresos]" +
                    $"SET [Descripcion_Ingreso] = '{ingreso.DescripcionIngreso}'," +
                    $"[Fecha_Ingreso] = '{ingreso.FechaIngreso.ToString("yyyy-MM-dd")}'," +
                    $"[Monto] = '{ingreso.Monto}'" +
                    $"WHERE Id_Ingreso = '{ingreso.IdIngreso}'";
                SqlCommand cmd = new SqlCommand(sqql, conexion);
                conexion.Open();
                var FliaAfectada = cmd.ExecuteNonQuery();
                conexion.Close();
                if (FliaAfectada > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
