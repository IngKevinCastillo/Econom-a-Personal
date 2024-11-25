using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public Usuario() { }
        public Usuario(string cedula, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string correoElectronico, string nombreUsuario, string contraseñaUsuario)
        {
            base.Cedula = cedula;
            base.P_Nombre = p_nombre;
            base.S_Nombre = s_nombre;
            base.P_Apellido = p_apellido;
            base.S_Apellido = s_apellido;
            base.CorreoPersona = correoElectronico;
            NombreUsuario = nombreUsuario;
            ContraseñaUsuario = contraseñaUsuario;
        }
        public override string ToString()
        {
            return $"{base.ToString()};{NombreUsuario};{ContraseñaUsuario}";
        }
    }
}
