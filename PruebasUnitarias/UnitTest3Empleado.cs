using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaFacturacion.AccesoDatos;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest3Empleado
    {
       
        [TestMethod]
        public void TM_1_Insertar_empleado()
        {
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();

                //Verificar si ya está registrado
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000001");
                if (cliente != null)
                {
                    clienteCtrl.eliminarCliente(cliente.IdPersona);
                }

                Empleado empleado = new Empleado();
                empleado.Cedula = "0000000001";
                empleado.Apellidos = "Apellidos";
                empleado.Nombres = "Nombres";
                empleado.Fecha_Nacimiento = new DateTime(1955, 1, 1).ToString();                

                Usuario usuario = new Usuario();
                usuario.Tipo_usuario.Id_tipo_usuario = 1;
                usuario.Nombre_usuario = "_Usuario_";
                usuario.Contrasenia = "123";
                usuario.Activo = true;

                Respuesta r = empleadoCtrl.insertarEmpleado(empleado, usuario);
                Assert.IsTrue(r.Completado);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void TM_2_Get_empleado_por_cedula()
        {
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000001");

                Assert.IsNotNull(empleado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_3_Get_empleado_por_id()
        {
            bool encontrado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000001");

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
        public void TM_4_Modificar_empleado()
        {
            bool modificado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000001");

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
        public void TM_5_Modificar_contrasenia_empleado()
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
        public void TM_6_Modificar_empleado_contrasenia_incorrecta()
        {
            bool modificado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000001");

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
        public void TM_7_Eliminar_empleado()
        {
            bool eliminado = false;
            try
            {
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
                Empleado empleado = empleadoCtrl.getEmpleadoPorCedula("0000000001");

                if (empleado != null)
                {
                    Respuesta r = empleadoCtrl.eliminarEmpleado(empleado.Id_empleado);
                    eliminado = r.Completado;
                }

                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000001");
                if (cliente != null)
                {
                    clienteCtrl.eliminarCliente(cliente.IdPersona);
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