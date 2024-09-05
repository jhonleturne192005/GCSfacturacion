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
    public class UnitTest6Factura
    {
        static int id_factura;
        static int id_proveedor;
        static int id_empleado;
        static int id_producto;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            try
            {
                //Insertar un empleado y usuario para las pruebas
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();

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

                empleadoCtrl.insertarEmpleado(empleado, usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar empleado: {ex.Message}");
            }

            //Insertar un cliente
            try
            {
                ClienteCtrl clienteCtrl = new ClienteCtrl();
                Cliente cliente = new Cliente();

                cliente.Cedula = "0000000000";
                cliente.Apellidos = "Apellidos";
                cliente.Nombres = "Nombres";

                clienteCtrl.insertarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar cliente: {ex.Message}");
            }

            //Insertar un producto
            try
            {
                ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
                Proveedor proveedor = new Proveedor();

                proveedor.Cedula = "0000000002";
                proveedor.Apellidos = "Apellidos";
                proveedor.Nombres = "Nombres";
                proveedor.Fecha_Nacimiento = new DateTime(2002, 10, 12).ToString();

                proveedorCtrl.insertarProveedor(proveedor);
                proveedor = proveedorCtrl.getProveedorPorCedula("0000000002");

                id_proveedor = proveedor.IdProveedor;

                ProductoCtrl productoCtrl = new ProductoCtrl();
                Producto producto = new Producto();

                producto.Nombre_producto = "00Producto00";
                producto.Iva = 0;
                producto.Precio_unitario = 0;
                producto.Proveedor = proveedor;

                productoCtrl.insertarProducto(producto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar producto: {ex.Message}");
            }
        }

        [TestMethod]
        public void TM_1_Insertar_factura()
        {
            try
            {
                FacturaCtrl facturaCtrl = new FacturaCtrl();

                Factura factura = new Factura();
                FacturaDetalle fDetalle = new FacturaDetalle();

                EmpleadoCtrl eCtrl = new EmpleadoCtrl();
                Empleado empleadoPrueba = eCtrl.getEmpleadoPorCedula("0000000001");

                ProductoCtrl pCtrl = new ProductoCtrl();
                Producto productoPrueba = pCtrl.buscarProducto("00Producto00")[0];

                ClienteCtrl cCtrl = new ClienteCtrl();
                Cliente clientePrueba = cCtrl.getClientePorCedula("0000000000");

                factura.Cliente = clientePrueba;
                factura.Empleado = empleadoPrueba;
                fDetalle.Producto = productoPrueba;
                fDetalle.Cantidad = 0;

                factura.Factura_Detalle.Add(fDetalle);
                Respuesta r = facturaCtrl.insertarFactura(factura);

                id_factura = int.Parse(r.Id);
                id_empleado = empleadoPrueba.Id_empleado;
                id_producto = productoPrueba.Id_producto;

                Assert.IsTrue(r.Completado);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
                throw new Exception($"Error al insertar producto: {ex.ToString()}");
            }
        }


        [TestMethod]
        public void TM_2_Buscar_facturas()
        {
            try
            {
                FacturaCtrl facturaCtrl = new FacturaCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "id_factura"));
                filtros.Add(new Filtros("texto_buscar", id_factura.ToString()));
                filtros.Add(new Filtros("fecha_inicio", DateTime.Now.ToString("MM-dd-yyyy")));
                filtros.Add(new Filtros("fecha_fin", DateTime.Now.ToString("MM-dd-yyyy")));

                List<Factura> facturas = facturaCtrl.buscarFacturas(1, 30, Filtros.filtros_a_xml("Filtros", filtros));
                Assert.IsTrue(facturas.Count == 1);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            //Eliminar el cliente, producto, empleado y factura útilizado en las pruebas
            //Eliminar factura y su detalle
            FacturaCtrl facturaCtrl = new FacturaCtrl();
            facturaCtrl.eliminarFactura(id_factura);

            //Eliminar el empleado
            EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();
            empleadoCtrl.eliminarEmpleado(id_empleado);

            //Eliminar el producto
            ProductoCtrl productoCtrl = new ProductoCtrl();
            productoCtrl.eliminarProducto(id_producto);

            //Eliminar el proveedor
            ProveedorCtrl proveedorCtrl = new ProveedorCtrl();
            proveedorCtrl.eliminarProveedor(id_proveedor);

            //Eliminar el cliente
            ClienteCtrl clienteCtrl = new ClienteCtrl();
            Cliente clientePrueba = clienteCtrl.getClientePorCedula("0000000000");
            clienteCtrl.eliminarCliente(clientePrueba.IdPersona);

            clientePrueba = clienteCtrl.getClientePorCedula("0000000001");
            clienteCtrl.eliminarCliente(clientePrueba.IdPersona);

            clientePrueba = clienteCtrl.getClientePorCedula("0000000002");
            clienteCtrl.eliminarCliente(clientePrueba.IdPersona);
        }
    }
}