using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Persistencia
{
    public class RepositorioCategoria
    {
        string cadena = "Server = .\\SQLEXPRESS;Database=EconomiaPersonal;Trusted_Connection=True";
        SqlConnection conexion = null;
        public RepositorioCategoria()
        {
            conexion = new SqlConnection(cadena);
        }
        public string AbrirConexion()
        {
            try
            {
                conexion.Open();
                return conexion.State.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Categoria> SeleccionarRegistros()
        {
            string ssql = "SELECT * FROM Categorias";
            List<Categoria> listaCategorias = new List<Categoria>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCategorias.Add(Mapper(reader));
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

            return listaCategorias;
        }

        private Categoria Mapper(SqlDataReader reader)
        {
            return new Categoria
            {
                Id_Categoria = reader.GetString(reader.GetOrdinal("Id_Categoria")),
                Nombre_Categoria = reader.GetString(reader.GetOrdinal("NombreCategoria")),
                CedulaUsuario = reader.GetString(reader.GetOrdinal("Cedula"))
            };
        }

        public bool InsertarCategoria(Categoria categoria)
        {
            try
            {
                string ssql = "INSERT INTO [dbo].[Categorias]([Id_Categoria],[NombreCategoria],[Cedula])" +
                    $"VALUES('{categoria.Id_Categoria}','{categoria.Nombre_Categoria}','{categoria.CedulaUsuario}')";

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
        public Categoria BuscarCategoria(string id)
        {
            try
            {
                return SeleccionarRegistros().Find(categoriaAConsultar => categoriaAConsultar.Id_Categoria == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Categoria BuscarCategoriaNombre(string nombre)
        {
            try
            {
                return SeleccionarRegistros().Find(categoriaAConsultar => categoriaAConsultar.Nombre_Categoria == nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool EliminarCategoria(string id)
        {
            try
            {
                string sqql = "DELETE FROM [dbo].[Categorias]" +
                    $"WHERE Id_Categoria = {id}";
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
    }
}
