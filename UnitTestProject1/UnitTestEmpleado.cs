using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaFacturacion.AccesoDatos;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class Unit3TestEmpleado
    {
        [TestMethod]
        public void TM_1_Insertar_empleado()
        {
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();

                Empleado empleado = new Empleado();
                empleado.Cedula_empleado = "0000000000";
                empleado.Apellidos = "Apellidos";
                empleado.Nombres = "Nombres";
                empleado.Fecha_nacimiento = new DateTime(1955, 1, 1).ToString();

                Usuario usuario = new Usuario();
                usuario.Tipo_usuario.Id_tipo_usuario = 1;
                usuario.Nombre_usuario = "_Usuario_";
                usuario.Contrasenia = "123";
                usuario.Activo = true;

                Respuesta r = empleadoCtrl.insertarEmpleado(empleado, usuario);
                Assert.IsTrue(r.Completado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_2_Buscar_empleado()
        {
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "cedula_empleado"));
                filtros.Add(new Filtros("texto_buscar", "0000000000"));

                List<Empleado> lstEmpleado = empleadoCtrl.buscarEmpleados(1, 30, Filtros.filtros_a_xml("Filtros", filtros));
                Assert.IsTrue(lstEmpleado.Count == 1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
                throw new Exception($"Error al insertar producto: {ex.Message}");
            }
        }

        [TestMethod]
        public void TM_3_Get_empleado_por_cedula()
        {
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000000");

                Assert.IsNotNull(empleado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_4_Get_empleado_por_id()
        {
            bool encontrado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000000");

                if (empleado != null)
                {
                    Empleado e = empleadoCtrl.getEmpleadoPorId(empleado.Id_empleado);
                    encontrado = (e != null);
                }

                Assert.IsTrue(encontrado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }



        [TestMethod]
        public void TM_5_Modificar_empleado()
        {
            bool modificado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000000");

                if (empleado != null)
                {
                    empleado = empleadoCtrl.getEmpleadoUsuarioPorIdEmpleado(empleado.Id_empleado);

                    empleado.Nombres = "NombresMod";
                    empleado.Apellidos = "ApellidosMod";
                    empleado.Usuario.Contrasenia = "123";

                    Respuesta r = empleadoCtrl.modificarEmpleado(empleado, empleado.Usuario);
                    modificado = r.Completado;
                }

                Assert.IsTrue(modificado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_6_Modificar_contrasenia_empleado()
        {
            try
            {
                UsuarioCtrl usuarioCtrl = new UsuarioCtrl();
                Respuesta r = usuarioCtrl.modificarContrasenia("_Usuario_", "123", "1234");

                Assert.IsTrue(r.Completado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_7_Modificar_empleado_contrasenia_incorrecta()
        {
            bool modificado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000000");

                if (empleado != null)
                {
                    empleado = empleadoCtrl.getEmpleadoUsuarioPorIdEmpleado(empleado.Id_empleado);

                    empleado.Nombres = "NombresMod";
                    empleado.Apellidos = "ApellidosMod";
                    empleado.Usuario.Contrasenia = "123";

                    Respuesta r = empleadoCtrl.modificarEmpleado(empleado, empleado.Usuario);
                    modificado = r.Completado;
                }

                Assert.IsFalse(modificado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_8_Eliminar_empleado()
        {
            bool eliminado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000000");

                if (empleado != null)
                {
                    Respuesta r = empleadoCtrl.eliminarEmpleado(empleado.Id_empleado);
                    eliminado = r.Completado;
                }

                Assert.IsTrue(eliminado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
