using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public static class Validaciones
    {
        public static bool esCedulaValida(string cedula)
        {
            //Regex para verificar que haya 10 caracteres con números entre [0 y 9]
            string regex_cedula = @"^[0-9]{10}$";

            Regex regex = new Regex(regex_cedula);

            //Verificar si la cédula coincide con el regex
            return regex.IsMatch(cedula);
        }

        public static bool esContraseniaValida(string contrasenia)
        {
            if (contrasenia.Length < 5 || contrasenia.Length > 15) return false;

            //Regex para verificar una combinación de números, letras y caracteres especiales
            string regex_contrasenia = @"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[\W_]).*$";

            Regex regex = new Regex(regex_contrasenia);

            // Verificar si la contraseña coincide con la expresión regular
            return regex.IsMatch(contrasenia);
        }
    }
}
