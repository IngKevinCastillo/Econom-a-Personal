using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public string CedulaUsuario { get; set; }
        public string Id_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public Categoria() { }
        public Categoria(string id_Categoria, string nombreCategoria, string cedulaUsuario)
        {
            Id_Categoria = id_Categoria;
            Nombre_Categoria = nombreCategoria;
            CedulaUsuario = cedulaUsuario;
        }
        public override string ToString()
        {
            return $"Codigo Categoria: {Id_Categoria}\n Nombre Categoria: {Nombre_Categoria}\n Cedula Usuario: {CedulaUsuario}";
        }
    }
}
