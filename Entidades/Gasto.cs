using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gasto
    {
        public Gasto() { }
        public Gasto(Usuario usuario, string idGasto, string descripcionGasto, Categoria categoria, string prioridadGasto, DateTime fechaGasto, double monto)
        {
            this.Usuario = usuario;
            IdGasto = idGasto;
            DescripcionGasto = descripcionGasto;
            PrioridadGasto = prioridadGasto;
            Categoria_Gasto = categoria;
            FechaGasto = fechaGasto;
            Monto = monto;
        }
        public Usuario Usuario { get; set; }
        public string IdGasto { get; set; }
        public string DescripcionGasto { get; set; }
        public string PrioridadGasto { get; set; }
        public Categoria Categoria_Gasto { get; set; }
        public DateTime FechaGasto { get; set; }
        public double Monto { get; set; }
        public override string ToString()
        {
            return $"{Usuario.NombreUsuario};{IdGasto};{DescripcionGasto};{PrioridadGasto};{Categoria_Gasto.Nombre_Categoria};{FechaGasto.ToString("yyyy-MM-dd")};{Monto}";
        }
    }
}
