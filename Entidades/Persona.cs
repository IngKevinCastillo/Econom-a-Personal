using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string P_Nombre { get; set; }
        public string S_Nombre { get; set; }
        public string P_Apellido { get; set; }
        public string S_Apellido { get; set; }
        public string CorreoPersona { get; set; }
        public Persona() { }
        public Persona(string cedula, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string correoElectronico)
        {
            Cedula = cedula;
            P_Nombre = p_nombre;
            S_Nombre = s_nombre;
            P_Apellido = p_apellido;
            S_Apellido = s_apellido;
            CorreoPersona = correoElectronico;
        }
        public override string ToString()
        {
            return $"{Cedula};{P_Nombre};{S_Nombre};{P_Apellido};{S_Apellido};{CorreoPersona}";
        }
    }
}
