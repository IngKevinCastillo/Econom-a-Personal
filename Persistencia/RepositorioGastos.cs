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
    public class RepositorioGastos
    {
        RepositorioUsuarios usuarios_BD = new RepositorioUsuarios();
        RepositorioCategoria categoria_BD = new RepositorioCategoria();
        string cadena = "Server = .\\SQLEXPRESS;Database=EconomiaPersonal;Trusted_Connection=True";
        SqlConnection conexion = null;
        public RepositorioGastos()
        {
            conexion = new SqlConnection(cadena);
        }
        public List<Gasto> SeleccionarRegistros()
        {
            string ssql = "SELECT * FROM Egresos";
            List<Gasto> listaGastos = new List<Gasto>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaGastos.Add(Mapper(reader));
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

            return listaGastos;
        }

        private Gasto Mapper(SqlDataReader reader)
        {
            return new Gasto
            {
                Usuario = usuarios_BD.BuscarUsuario(reader.GetString(reader.GetOrdinal("Cedula"))),
                IdGasto = reader.GetString(reader.GetOrdinal("Id_Egreso")),
                DescripcionGasto = reader.GetString(reader.GetOrdinal("Descripcion_Egreso")),
                PrioridadGasto = reader.GetString(reader.GetOrdinal("Prioridad_Egreso")),
                Categoria_Gasto = categoria_BD.BuscarCategoria(reader.GetString(reader.GetOrdinal("Id_Categoria"))),
                FechaGasto = reader.GetDateTime(reader.GetOrdinal("Fecha_Egreso")),
                Monto = (double)reader.GetDecimal(reader.GetOrdinal("Monto"))
            };
        }


        public bool InsertarGasto(Gasto gasto)
        {
            try
            {
                string ssql = "INSERT INTO [dbo].[Egresos]([Id_Egreso],[Descripcion_Egreso],[Prioridad_Egreso],[Fecha_Egreso],[Monto],[Id_Categoria],[Cedula])" +
                    $"VALUES('{gasto.IdGasto}','{gasto.DescripcionGasto}','{gasto.PrioridadGasto}',CAST('{gasto.FechaGasto.ToString("yyyy-MM-dd")}' AS DATE),'{gasto.Monto}','{gasto.Categoria_Gasto.Id_Categoria}','{gasto.Usuario.Cedula}')";

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
        public Gasto BuscarGasto(string id)
        {
            try
            {
                return SeleccionarRegistros().Find(GastoAConsultar => GastoAConsultar.IdGasto == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool EliminarGasto(string id)
        {
            try
            {
                string sqql = "DELETE FROM [dbo].[Egresos]" +
                    $"WHERE Id_Egreso = {id}";
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
        public bool EditarGasto(Gasto gasto)
        {
            try
            {
                string sqql = "UPDATE [dbo].[Egresos]" +
                    $"SET [Descripcion_Egreso] = '{gasto.DescripcionGasto}'," +
                    $"[Prioridad_Egreso] = '{gasto.PrioridadGasto}'," +
                    $"[Fecha_Egreso] = '{gasto.FechaGasto.ToString("yyyy-MM-dd")}'," +
                    $"[Monto] = '{gasto.Monto}'," +
                    $"[Id_Categoria] = '{gasto.Categoria_Gasto.Id_Categoria}'" +
                    $"WHERE Id_Egreso = '{gasto.IdGasto}'";
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
