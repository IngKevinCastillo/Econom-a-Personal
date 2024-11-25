using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingreso
    {
        public Ingreso() { }
        public Ingreso(Usuario usuario, string idIngreso, string descripcionIngreso, DateTime fechaIngreso, double monto)
        {
            this.Usuario_Ingreso = usuario;
            IdIngreso = idIngreso;
            DescripcionIngreso = descripcionIngreso;
            FechaIngreso = fechaIngreso;
            Monto = monto;
        }
        public Usuario Usuario_Ingreso { get; set; }
        public string IdIngreso { get; set; }
        public string DescripcionIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double Monto { get; set; } = 0;
        public override string ToString()
        {
            return $"{Usuario_Ingreso.NombreUsuario};{IdIngreso};{DescripcionIngreso};{FechaIngreso.ToString("yyyy-MM-dd")};{Monto}";
        }
    }
}
