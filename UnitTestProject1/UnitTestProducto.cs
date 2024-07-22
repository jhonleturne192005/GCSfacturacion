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
    public class Unit2TestProducto
    {
        [TestMethod]
        public void TM_1_Insertar_producto()
        {
            try
            {
                ProductoCtrl productoCtrl = new ProductoCtrl();
                Producto producto = new Producto();

                producto.Nombre_producto = "00Producto00";
                producto.Iva = 0;
                producto.Precio_unitario = 0;

                Respuesta r = productoCtrl.insertarProducto(producto);
                Assert.IsTrue(r.Completado);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_2_Buscar_producto()
        {
            try
            {
                ProductoCtrl productoCtrl = new ProductoCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "nombre_producto"));
                filtros.Add(new Filtros("texto_buscar", "00Producto00"));

                List<Producto> lstProducto = productoCtrl.buscarProductoPaginacion(1, 30, Filtros.filtros_a_xml("Filtros", filtros));
                Assert.IsTrue(lstProducto.Count == 1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TM_3_Get_producto()
        {
            try
            {
                ProductoCtrl productoCtrl = new ProductoCtrl();

                List<Filtros> filtros = new List<Filtros>();
                filtros.Add(new Filtros("campo_busqueda", "nombre_producto"));
                filtros.Add(new Filtros("texto_buscar", "00Producto00"));

                Producto producto = productoCtrl.buscarProductoPaginacion(1, 30, Filtros.filtros_a_xml("Filtros", filtros))[0];
                producto = productoCtrl.getProducto(producto.Id_producto);

                Assert.IsNotNull(producto);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }


        [TestMethod]
        public void TM_4_Modificar_producto()
        {
            bool modificado = false;
            try
            {
                ProductoCtrl productoCtrl = new ProductoCtrl();
                List<Producto> lstProducto = productoCtrl.buscarProducto("00Producto00");

                if (lstProducto.Count > 0)
                {
                    Producto producto = lstProducto[0];
                    producto.Nombre_producto = "00Producto00Mod";
                    producto.Iva = 0;
                    producto.Precio_unitario = 0;

                    Respuesta r = productoCtrl.modificarProducto(producto);
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
        public void TM_5_Eliminar_producto()
        {
            bool eliminado = false;
            try
            {
                ProductoCtrl productoCtrl = new ProductoCtrl();
                List<Producto> lstProducto = productoCtrl.buscarProducto("00Producto00Mod");

                if (lstProducto.Count > 0)
                {
                    Producto producto = lstProducto[0];                 

                    Respuesta r = productoCtrl.eliminarProducto(producto.Id_producto);
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
