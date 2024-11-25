using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entity
{
    public class Validaciones
    {
        public string ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre no debe estar vacío.";
            var regex = new Regex(@"^[A-Za-zÑñ]+(?:\s?[A-Za-zÑñ]+){0,2}$");
            if (!regex.IsMatch(nombre))
                return "El nombre no puede tener numeros y caracteres especiales.";
            return nombre;
        }
        public string ValidarApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                return "El apellido no debe estar vacío.";
            var regex = new Regex(@"^[A-Za-zÑñ]+(?:\s[A-Za-zÑñ]+){0,2}$");
            if (!regex.IsMatch(apellido))
                return "El apellido no puede tener numeros y caracteres especiales.";
            return apellido;
        }
        public string ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return "El correo no debe estar vacío.";
            var regex = new Regex(@"^[A-Za-zÑñ0-9]+@(hubspot\.com|gmail\.com|protonmail\.com|icloud\.com|zohomail\.com|outlook\.com|mailbox\.org|yahoo\.com|[A-Za-zÑñ0-9]+\.edu\.co)$");
            if (!regex.IsMatch(correo))
                return "Correo inválido.";
            return correo;
        }

        public string ValidarNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                return "El nombre de usuario no debe estar vacío.";

            var regex = new Regex(@"^[A-Za-zÑñ0-9]+$");
            if (!regex.IsMatch(nombreUsuario))
                return "El usuario no puede tener caracteres especiales y/o espacios.";

            return nombreUsuario;
        }

        public string ValidarContraseña(string contraseña)
        {
            if (string.IsNullOrEmpty(contraseña) || contraseña.Length < 8)
                return "La contraseña debe tener al menos 8 caracteres.";

            return contraseña;
        }
        public bool ValidacionDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return false;

            if (descripcion.StartsWith(" "))
                return false;

            var regex = new Regex(@"^[A-Za-zÑñ0-9-][A-Za-zÑñ0-9-\s]*$");
            if (!regex.IsMatch(descripcion))
                return false;
           
            return true;
        }
        public bool ValidacionSoloNumeros(string input)
        {

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input.Length > 10)
                return false;

            var regex = new Regex(@"^\d{1,10}$");
            if (!regex.IsMatch(input))
                return false;

            return true;
        }

    }
}