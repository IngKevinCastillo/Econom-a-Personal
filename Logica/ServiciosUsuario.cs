using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosUsuario : ICRUDSERVICIOINGRESOS, ICRUDSERVICIOGASTOS
    {
        private RepositorioIngresos ingresos_BD;
        private RepositorioUsuarios usuarios_BD;
        private RepositorioGastos gastos_BD;
        Cuenta cuentaUsuario = new Cuenta();
        public ServiciosUsuario()
        {
            gastos_BD = new RepositorioGastos();
            ingresos_BD = new RepositorioIngresos();
            usuarios_BD = new RepositorioUsuarios();
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
        public List<Gasto> ObtenerGastos()
        {
            return gastos_BD.SeleccionarRegistros();
        }
        public List<Ingreso> ObtenerIngresos()
        {
            return ingresos_BD.SeleccionarRegistros();
        }
        public List<Gasto> ObtenerGastosCuenta()
        {
            return cuentaUsuario.gastos;
        }
        public List<Ingreso> ObtenerIngresoCuenta()
        {
            return cuentaUsuario.ingresos;
        }
        public string RegistrarGasto(Gasto gasto)
        {
            var gastosExistentes = ObtenerGastos();
            string nuevoId;

            if (gastosExistentes == null || !gastosExistentes.Any())
            {
                nuevoId = "1";
            }
            else
            {
                int maxId = gastosExistentes.Max(g => int.Parse(g.IdGasto));
                nuevoId = (maxId + 1).ToString();
            }

            gasto.IdGasto = nuevoId;
            var resultado = gastos_BD.InsertarGasto(gasto);
            return resultado ? "Registro de Egreso exitoso" : "Error al Registrar Gasto";
        }

        public string RegistrarIngreso(Ingreso ingreso)
        {
            var ingresosExistentes = ObtenerIngresos();
            string nuevoId;

            if (ingresosExistentes == null || !ingresosExistentes.Any())
            {
                nuevoId = "1";
            }
            else
            {
                int maxId = ingresosExistentes.Max(i => int.Parse(i.IdIngreso));
                nuevoId = (maxId + 1).ToString();
            }

            ingreso.IdIngreso = nuevoId;
            var resultado = ingresos_BD.InsertarIngreso(ingreso);

            return resultado ? "Registro de Ingreso exitoso" : "Error al Registrar Ingreso";
        }

        public bool EliminarGasto(string idGasto)
        {
            cuentaUsuario.gastos.RemoveAll(g => g.IdGasto == idGasto);
            return gastos_BD.EliminarGasto(idGasto);
        }
        public Gasto BuscarGasto(string id)
        {
            return gastos_BD.BuscarGasto(id);
        }
        public Ingreso BuscarIngreso(string id)
        {
            return ingresos_BD.BuscarIngreso(id);
        }
        public bool EliminarIngreso(string idIngreso)
        {
            cuentaUsuario.ingresos.RemoveAll(g => g.IdIngreso == idIngreso);
            return ingresos_BD.EliminarIngreso(idIngreso);
        }
        public bool EditarIngreso(Ingreso ingreso)
        {
            cuentaUsuario.ingresos.RemoveAll(ingresoABuscar => ingresoABuscar.IdIngreso == ingreso.IdIngreso);
            return ingresos_BD.EditarIngreso(ingreso);
        }
        public bool EditarEgreso(Gasto gasto)
        {
            cuentaUsuario.gastos.RemoveAll(gastoABuscar => gastoABuscar.IdGasto == gasto.IdGasto);
            return gastos_BD.EditarGasto(gasto);
        }
        public string AgregarUsuario(Usuario usuario)
        {
            var operacion = usuarios_BD.InsertarUsuario(usuario);
            if (operacion == true)
            {
                return "Registro Usuario Exitoso";
            }
            else
            {
                return "Error al Registrar Usuario";
            }

        }
        public string EliminarUsuario(string cedula)
        {

            return usuarios_BD.EliminarUsuario(cedula);
        }

        public Usuario BuscarUsuarioNombre(string nombre)
        {
            return usuarios_BD.BuscarUsuarioNombre(nombre);
        }
        public Usuario BuscarUsuario(string cedula)
        {
            return usuarios_BD.BuscarUsuario(cedula);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios_BD.SeleccionarRegistros();
        }
        public bool validarUsuario(string nombreUsuario, string contraseña)
        {
            Usuario usuario = ObtenerUsuarios().Find(usuarioABuscar => usuarioABuscar.NombreUsuario == nombreUsuario && usuarioABuscar.ContraseñaUsuario == contraseña);
            if (usuario == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string EditarUsuario(Usuario usuario)
        {
            var proceso = usuarios_BD.EditarUsuario(usuario);
            if (proceso == false)
            {
                return "Error al editar usuario";
            }
            else
            {
                return "¡Modificación Exitosa!";
            }
        }
    }
}
