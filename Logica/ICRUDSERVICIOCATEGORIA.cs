using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICRUDSERVICIOCATEGORIA
    {
        string RegistrarCategoria(Categoria categoria);
        bool EliminarCategoria(string categoria);
        Categoria BuscarCategoria(string id);
        List<Categoria> ObtenerCategorias();
    }
}
