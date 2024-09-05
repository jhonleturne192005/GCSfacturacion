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
    public class UnitTest2Cliente
    {
        [TestMethod]
        public void TM_1_Insertar_cliente()
        {
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = new Cliente();

                cliente.Cedula = "0000000000";
                cliente.Apellidos = "Apellidos";
                cliente.Nombres = "Nombres";

                Respuesta r = clienteCtrl.insertarCliente(cliente);
                Assert.IsTrue(r.Completado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_2_Buscar_cliente()
        {
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "cedula_cliente"));
                filtros.Add(new Filtros("texto_buscar", "0000000000"));

                List<Cliente> lstCliente = clienteCtrl.buscarClientes(1, 30, Filtros.filtros_a_xml("Filtros", filtros));
                Assert.IsTrue(lstCliente.Count == 1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
                throw new Exception($"Error al insertar producto: {ex.Message}");
            }
        }

        [TestMethod]
        public void TM_3_Get_cliente_por_cedula()
        {
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000000");

                Assert.IsNotNull(cliente);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_4_Get_cliente_por_id()
        {
            bool encontrado = false;
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000000");

                if (cliente != null)
                {
                    Cliente c = clienteCtrl.getClientePorId(cliente.IdPersona);
                    encontrado = c != null;
                }

                Assert.IsTrue(encontrado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_5_Modificar_cliente()
        {
            bool modificado = false;
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000000");

                if (cliente != null)
                {
                    cliente.Nombres = "NombresMod";
                    cliente.Apellidos = "ApellidosMod";

                    Respuesta r = clienteCtrl.modificarCliente(cliente);
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
        public void TM_6_Eliminar_cliente()
        {
            bool eliminado = false;
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000000");

                if (cliente != null)
                {
                    Respuesta r = clienteCtrl.eliminarCliente(cliente.IdPersona);
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