using SistemaFacturacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public static class  DatosSesion
    {
        public static Empleado Empleado { get; set; }

        public static bool esAdmin(Empleado empleado)
        {
            if (empleado == null) return false;
            if (empleado.Usuario == null) return false;
            if (empleado.Usuario.Tipo_usuario == null) return false;

            if (empleado.Usuario.Tipo_usuario.Id_tipo_usuario == 1)
            {
                return true;
            }

            return false;
        }
    }
}
