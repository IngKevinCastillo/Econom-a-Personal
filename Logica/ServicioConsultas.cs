using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioConsultas
    {
        private RepositorioIngresos ingresos_BD;
        private RepositorioGastos gastos_BD;
        private Cuenta cuentaUsuario = new Cuenta();
        public ServicioConsultas()
        {
            gastos_BD = new RepositorioGastos();
            ingresos_BD = new RepositorioIngresos();
        }

        public void RecuperacionDatos(Usuario usuario)
        {
            try
            {
                cuentaUsuario.ingresos = ingresos_BD.SeleccionarRegistros().FindAll(IngresoAConsultar => IngresoAConsultar.Usuario_Ingreso.Cedula == usuario.Cedula);
                cuentaUsuario.gastos = gastos_BD.SeleccionarRegistros().FindAll(GastoAConsultar => GastoAConsultar.Usuario.Cedula == usuario.Cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Gasto> consultaGastoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Gasto> listagastos = cuentaUsuario.gastos;
            List<Gasto> gastosEncontrados = new List<Gasto>();
            foreach (Gasto item in listagastos)
            {
                if (item.FechaGasto.Date >= fechaInicial.Date && item.FechaGasto.Date <= fechaFinal.Date)
                {
                    gastosEncontrados.Add(item);
                }
            }
            if (gastosEncontrados.Count == 0)
            {
                return null;
            }
            return gastosEncontrados;
        }

        public List<Gasto> ConsultaGastosAnuales(DateTime año)//aqui vas a cambiar de int a DateTime para realizar la operacion.
        {
            List<Gasto> gastos = cuentaUsuario.gastos;
            List<Gasto> datosSeleccionados = gastos.Where(gasto => gasto.FechaGasto.Year == año.Year).ToList();
            return datosSeleccionados;
        }
        public List<Gasto> ConsultaGastosMensuales(DateTime mes)
        {
            List<Gasto> gastos = cuentaUsuario.gastos;
            List<Gasto> datosSeleccionados = gastos.Where(gasto => gasto.FechaGasto.Month == mes.Month && gasto.FechaGasto.Year == mes.Year).ToList();
            return datosSeleccionados;
        }

        public List<Gasto> ConsultaGastosMensualesPorRango(DateTime mesInicial, DateTime mesFinal)//aqui vas a cambiar de int a DateTime para realizar la operacion.
        {
            List<Gasto> gastos = cuentaUsuario.gastos;
            List<Gasto> gastosEncontrados = new List<Gasto>();
            var totalMesesSeleccionado = gastos.Where(gasto => gasto.FechaGasto.Month >= mesInicial.Month && gasto.FechaGasto.Month <= mesFinal.Month);
            foreach (var item in totalMesesSeleccionado)
            {
                gastosEncontrados.Add(item);
            }
            return gastosEncontrados;
        }
        public List<Ingreso> ConsultaIngresoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Ingreso> listaIngresos = cuentaUsuario.ingresos;
            List<Ingreso> ingresosEncontrados = new List<Ingreso>();

            foreach (Ingreso item in listaIngresos)
            {
                if (item.FechaIngreso.Date >= fechaInicial.Date && item.FechaIngreso.Date <= fechaFinal.Date)
                {
                    ingresosEncontrados.Add(item);
                }
            }
            return ingresosEncontrados;
        }

        public List<Ingreso> ConsultaIngresosAnuales(DateTime año)
        {
            List<Ingreso> ingresos = cuentaUsuario.ingresos;
            List<Ingreso> datosSeleccionados = ingresos.Where(ingreso => ingreso.FechaIngreso.Year == año.Year).ToList();
            return datosSeleccionados;
        }
        public List<Ingreso> ConsultaIngresosMensuales(DateTime mes)
        {
            List<Ingreso> ingresos = cuentaUsuario.ingresos;
            List<Ingreso> datosSeleccionados = ingresos.Where(ingreso => ingreso.FechaIngreso.Month == mes.Month && ingreso.FechaIngreso.Year == mes.Year).ToList();
            return datosSeleccionados;
        }
        public List<Ingreso> ConsultaIngresosMensualesPorRango(DateTime mesInicial, DateTime mesFinal)//aqui vas a cambiar de int a DateTime para realizar la operacion.
        {
            List<Ingreso> ingresos = cuentaUsuario.ingresos;
            List<Ingreso> ingresosEncontrados = new List<Ingreso>();
            var totalMesesSeleccionado = ingresos.Where(ingreso => ingreso.FechaIngreso.Month >= mesInicial.Month && ingreso.FechaIngreso.Month <= mesFinal.Month);
            foreach (var item in totalMesesSeleccionado)
            {
                ingresosEncontrados.Add(item);
            }
            return ingresosEncontrados;
        }
        public List<Ingreso> ConsultaIngresoPorDia(DateTime fecha)
        {
            List<Ingreso> listaIngresos = cuentaUsuario.ingresos;
            List<Ingreso> ingresosEncontrados = new List<Ingreso>();

            foreach (Ingreso item in listaIngresos)
            {
                if (item.FechaIngreso.Date == fecha.Date)
                {
                    ingresosEncontrados.Add(item);
                }
            }

            if (ingresosEncontrados.Count == 0)
            {
                return null;
            }

            return ingresosEncontrados;
        }

        public List<Gasto> ConsultaGastoPorDia(DateTime fecha)
        {
            List<Gasto> listaGastos = cuentaUsuario.gastos;
            List<Gasto> gastosEncontrados = new List<Gasto>();

            foreach (Gasto item in listaGastos)
            {
                if (item.FechaGasto.Date == fecha.Date)
                {
                    gastosEncontrados.Add(item);
                }
            }
            if (gastosEncontrados.Count == 0)
            {
                return null;
            }
            return gastosEncontrados;
        }
        public double gastostotales(List<Gasto> gastos)
        {
            return gastos.Sum(gastoabuscar => gastoabuscar.Monto);
        }
        public double ingresostotales(List<Ingreso> ingresos)
        {
            return ingresos.Sum(ingresosabuscar => ingresosabuscar.Monto);
        }
    }
}
