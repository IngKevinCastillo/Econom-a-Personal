using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICRUDSERVICIOGASTOS
    {
        string RegistrarGasto(Gasto gasto);
        bool EliminarGasto(string idGasto);
        Gasto BuscarGasto(string idGasto);
        List<Gasto> ObtenerGastos();
    }
}
