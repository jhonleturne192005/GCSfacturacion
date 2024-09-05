using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    public class EmpleadoCtrl
    {
        EmpleadoDao empleadoDao;

        public EmpleadoCtrl()
        {
            empleadoDao = new EmpleadoDao();
        }

        public Respuesta insertarEmpleado(Empleado empleado, Usuario usuario)
        {
            int estado_insercion = empleadoDao.insertarEmpleado(empleado.getXml(), usuario.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_insercion)
            {
                case 0:
                    mensaje = "El empleado fue insertado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Ocurrió un error durante la inserción del empleado, verifique que los campos cumplan las restricciones específicadas";
                    break;
                case 2:
                    mensaje = "Ya existe un empleado con la cédula específicada";
                    break;
                case 3:
                    mensaje = "Ya existe un empleado con el nombre de usuario específicado";
                    break;
                case 4:
                    mensaje = "Ocurrió un error durante la inserción de las credenciales de acceso";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la inserción del empleado";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public Respuesta modificarEmpleado(Empleado empleado, Usuario usuario)
        {
            int estado_insercion = empleadoDao.modificarEmpleado(empleado.getXml(), usuario.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_insercion)
            {
                case 0:
                    mensaje = "El empleado fue modificado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Ocurrió un error durante la modificación del empleado, verifique que los campos cumplan las restricciones específicadas";
                    break;
                case 2:
                    mensaje = "La contraseña ingresada no es correcta; por lo tanto, los cambios no fueron aplicados";
                    break;
                case 3:
                    mensaje = "Ya existe un empleado con la cédula específicada";
                    break;
                case 4:
                    mensaje = "Ya existe un empleado con el nombre de usuario específicado";
                    break;
                case 5:
                    mensaje = "Ocurrió un error durante la inserción de las credenciales de acceso";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la inserción del empleado";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public Respuesta eliminarEmpleado(int id_empleado)
        {
            int estado_eliminacion = empleadoDao.eliminarEmpleado(id_empleado);

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_eliminacion)
            {
                case 0:
                    mensaje = "El empleado fue eliminado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "El empleado no puede ser eliminado, ya que está relacionado con datos de importancia";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la eliminación el cliente";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public List<Empleado> listarEmpleados(int numero_pagina, int numero_elementos)
        {
            DataTable dtEmpleado = empleadoDao.listarEmpleados(numero_pagina, numero_elementos);
            List<Empleado> lstEmpleados = new List<Empleado>();

            for (int i = 0; i < dtEmpleado.Rows.Count; i++)
            {
                Empleado empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[i];
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();

                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleado> buscarEmpleados(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            DataTable dtEmpleado = empleadoDao.buscarEmpleados(numero_pagina, numero_elementos, texto_buscar);
            List<Empleado> lstEmpleados = new List<Empleado>();

            for (int i = 0; i < dtEmpleado.Rows.Count; i++)
            {
                Empleado empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[i];
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();

                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }
        public Empleado getEmpleadoPorId(int id_empleado)
        {
            Empleado empleado = null;
            DataTable dtEmpleado = empleadoDao.getEmpleado(id_empleado);

            if (dtEmpleado.Rows.Count == 1)
            {
                empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[0];
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();
            }

            return empleado;
        }

        public Empleado getEmpleadoPorCedula(string cedula_empleado)
        {
            Empleado empleado = null;
            DataTable dtEmpleado = empleadoDao.getEmpleadoPorCedula(cedula_empleado);

            if (dtEmpleado.Rows.Count == 1)
            {
                empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[0];
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();
            }

            return empleado;
        }

        public Empleado getEmpleadoUsuarioPorIdEmpleado(int id_empleado)
        {
            Empleado empleado = null; 

            DataTable dtEmpleado = empleadoDao.getEmpleadoUsuario(id_empleado);

            if (dtEmpleado.Rows.Count == 1)
            {
                empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[0];

                //Datos propios del empleado
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();

                //Datos de usuario
                empleado.Usuario.Id_usuario = int.Parse(drEmpleado[5].ToString());
                empleado.Usuario.Nombre_usuario = drEmpleado[6].ToString();
                empleado.Usuario.Activo = bool.Parse(drEmpleado[7].ToString());

                //Datos del tipo de usuario (rol)
                empleado.Usuario.Tipo_usuario.Id_tipo_usuario = int.Parse(drEmpleado[8].ToString());
                empleado.Usuario.Tipo_usuario.Tipo_usuario = drEmpleado[9].ToString();
                empleado.Usuario.Tipo_usuario.Descripcion = drEmpleado[10].ToString();
            }

            return empleado;
        }

        public Empleado getEmpleadoUsuarioPorIdUsuario(int id_usuario)
        {
            Empleado empleado = null;
            DataTable dtEmpleado = empleadoDao.getEmpleadoUsuarioPorIdUsuario(id_usuario);

            if (dtEmpleado.Rows.Count == 1)
            {
                empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[0];

                //Datos propios del empleado
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();

                //Datos de usuario
                empleado.Usuario.Id_usuario = int.Parse(drEmpleado[5].ToString());
                empleado.Usuario.Nombre_usuario = drEmpleado[6].ToString();
                empleado.Usuario.Activo = bool.Parse(drEmpleado[7].ToString());

                //Datos del tipo de usuario (rol)
                empleado.Usuario.Tipo_usuario.Id_tipo_usuario = int.Parse(drEmpleado[8].ToString());
                empleado.Usuario.Tipo_usuario.Tipo_usuario = drEmpleado[9].ToString();
                empleado.Usuario.Tipo_usuario.Descripcion = drEmpleado[10].ToString();
            }

            return empleado;
        }

        public Empleado getEmpleadoUsuarioPorIdUsuario2(string usuario)
        {
            Empleado empleado = null;
            DataTable dtEmpleado = empleadoDao.getEmpleadoUsuario2(usuario);

            if (dtEmpleado.Rows.Count == 1)
            {
                empleado = new Empleado();

                DataRow drEmpleado = dtEmpleado.Rows[0];

                //Datos propios del empleado
                empleado.Id_empleado = int.Parse(drEmpleado[0].ToString());
                empleado.Cedula = drEmpleado[1].ToString();
                empleado.Apellidos = drEmpleado[2].ToString();
                empleado.Nombres = drEmpleado[3].ToString();
                empleado.Fecha_Nacimiento = drEmpleado[4].ToString();

                //Datos de usuario
                empleado.Usuario.Id_usuario = int.Parse(drEmpleado[5].ToString());
                empleado.Usuario.Nombre_usuario = drEmpleado[6].ToString();
                empleado.Usuario.Activo = bool.Parse(drEmpleado[7].ToString());

                //Datos del tipo de usuario (rol)
                empleado.Usuario.Tipo_usuario.Id_tipo_usuario = int.Parse(drEmpleado[8].ToString());
                empleado.Usuario.Tipo_usuario.Tipo_usuario = drEmpleado[9].ToString();
                empleado.Usuario.Tipo_usuario.Descripcion = drEmpleado[10].ToString();
            }

            return empleado;
        }

        public Opcion<string>[] getFiltrosBusqueda()
        {
            return new Opcion<string>[]
            {
               new Opcion<string>("CI. Empleado", "cedula_empleado"),
               new Opcion<string>("Apellidos", "apellidos"),
               new Opcion<string>("Nombres", "nombres")
            };
        }
    }
}
