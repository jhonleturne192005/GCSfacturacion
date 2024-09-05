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
    public class UnitTest4Proveedor
    {
        [TestMethod]
        public void TM_1_Insertar_proveedor()
        {
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = new Proveedor();

                proveedor.Cedula = "0000000002";
                proveedor.Apellidos = "Apellidos";
                proveedor.Nombres = "Nombres";
                proveedor.Email = "prueba_proveedor@gmail.com";
                proveedor.Fecha_Nacimiento = new DateTime(2002, 10, 12).ToString();

                Respuesta r = proveedorCtrl.insertarProveedor(proveedor);
                Assert.IsTrue(r.Completado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_2_Buscar_proveedor()
        {
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "cedula"));
                filtros.Add(new Filtros("texto_buscar", "0000000002"));

                List<Proveedor> lstCliente = proveedorCtrl.buscarProveedores(1, 30, Filtros.filtros_a_xml("Filtros", filtros));
                Assert.IsTrue(lstCliente.Count == 1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
                throw new Exception($"Error al insertar producto: {ex.Message}");
            }
        }

        [TestMethod]
        public void TM_3_Get_proveedor_por_cedula()
        {
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = proveedorCtrl.getProveedorPorCedula("0000000002");

                Assert.IsNotNull(proveedor);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_4_Get_proveedor_por_id()
        {
            bool encontrado = false;
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = proveedorCtrl.getProveedorPorCedula("0000000002");

                if (proveedor != null)
                {
                    proveedor = proveedorCtrl.getProveedorPorId(proveedor.IdProveedor);
                    encontrado = proveedor != null;
                }

                Assert.IsTrue(encontrado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_5_Modificar_proveedor()
        {
            bool modificado = false;
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = proveedorCtrl.getProveedorPorCedula("0000000002");

                if (proveedor != null)
                {
                    proveedor = proveedorCtrl.getProveedorPorId(proveedor.IdProveedor);
                    proveedor.Nombres = "NombresMod";
                    proveedor.Apellidos = "ApellidosMod";

                    Respuesta r = proveedorCtrl.modificarProveedor(proveedor);
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
        public void TM_6_Eliminar_proveedor()
        {
            bool eliminado = false;
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = proveedorCtrl.getProveedorPorCedula("0000000002");

                if (proveedor != null)
                {
                    proveedor = proveedorCtrl.getProveedorPorId(proveedor.IdProveedor);
                   
                    Respuesta r = proveedorCtrl.eliminarProveedor(proveedor.IdPersona);
                    eliminado = r.Completado;
                }


                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = clienteCtrl.getClientePorCedula("0000000002");
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