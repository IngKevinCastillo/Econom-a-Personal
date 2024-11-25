using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosCategoria : ICRUDSERVICIOCATEGORIA
    {
        public RepositorioCategoria repositorioCategoria;
        public ServiciosCategoria()
        {
            repositorioCategoria = new RepositorioCategoria();
        }

        public Categoria BuscarCategoria(string id)
        {
            return repositorioCategoria.BuscarCategoria(id);
        }
        public Categoria BuscarCategoriaNombre(string nombre)
        {
            return repositorioCategoria.BuscarCategoriaNombre(nombre);
        }

        public bool EliminarCategoria(string categoria)
        {
            return repositorioCategoria.EliminarCategoria(categoria);
        }

        public List<Categoria> ObtenerCategorias()
        {
            return repositorioCategoria.SeleccionarRegistros();
        }

        public string RegistrarCategoria(Categoria categoria)
        {
            var categoriasExistentes = ObtenerCategorias();
            string nuevoId;

            if (categoriasExistentes == null || !categoriasExistentes.Any())
            {
                nuevoId = "1";
            }
            else
            {
                int maxId = categoriasExistentes.Max(c => int.Parse(c.Id_Categoria));
                nuevoId = (maxId + 1).ToString();
            }

            categoria.Id_Categoria = nuevoId;
            var proceso = repositorioCategoria.InsertarCategoria(categoria);

            return proceso ? "Registro de Categoria Completado." : "Error al Registrar Categoria";
        }

    }
}
