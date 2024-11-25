using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICRUDSERVICIOINGRESOS
    {
        string RegistrarIngreso(Ingreso ingreso);
        bool EliminarIngreso(string idIngreso);
        Ingreso BuscarIngreso(string idIngreso);
        List<Ingreso> ObtenerIngresos();
    }
}
