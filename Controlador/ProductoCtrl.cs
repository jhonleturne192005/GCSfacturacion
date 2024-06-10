using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Controlador
{
    class ProductoCtrl
    {
        ProductoDao productoDao;

        public ProductoCtrl()
        {
            productoDao = new ProductoDao();
        }

        public Respuesta insertarProducto(Producto producto)
        {
            int estado = productoDao.insertarProducto(producto.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado)
            {
                case 0:
                    mensaje = "El producto fue insertado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Error no existe nombre de producto";
                    break;
                case 2:
                    mensaje = "Error el IVA debe estar en un rango de 0 a 100";
                    break;
                default:
                    mensaje = "Error en la inserción del producto";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }
        public Respuesta modificarProducto(Producto producto)
        {
            int estado = productoDao.modificarProducto(producto.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado)
            {
                case 0:
                    mensaje = "El producto fue actualizado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Ya existe un cliente con la identificación ingresada";
                    break;
                default:
                    mensaje = "Error en la actualizacion del producto";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }
        public Respuesta eliminarProducto(int id_producto)
        {
            int estado = productoDao.eliminarProducto(id_producto);

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado)
            {
                case 0:
                    mensaje = "El producto fue eliminado correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "Error en la eliminación del producto";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }
        public List<Producto> listarProductos(int pagina_actual, int elementos_pagina)
        {
            List<Producto> lstProductos = new List<Producto>();
            DataTable dtProductos = productoDao.listarProductos(pagina_actual, elementos_pagina);

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                DataRow drProducto = dtProductos.Rows[i];

                Producto producto = new Producto();

                producto.Id_producto = int.Parse(drProducto[0].ToString());
                producto.Nombre_producto = drProducto[1].ToString();
                producto.Precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.Iva = decimal.Parse(drProducto[3].ToString());

                lstProductos.Add(producto);
            }

            return lstProductos;
        }
        public Producto getProducto(int id_producto)
        {
            Producto producto = null;
            DataTable dtProducto = productoDao.getProducto(id_producto);

            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                producto = producto = new Producto();
                DataRow drProducto = dtProducto.Rows[i];

                producto.Id_producto = int.Parse(drProducto[0].ToString());
                producto.Nombre_producto = drProducto[1].ToString();
                producto.Precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.Iva = decimal.Parse(drProducto[3].ToString());
            }

            return producto;
        }
        public List<Producto> buscarProducto(string texto_buscar)
        {
            List<Producto> lstProductos = new List<Producto>();
            DataTable dtProductos = productoDao.buscarProducto(texto_buscar);

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                DataRow drProducto = dtProductos.Rows[i];

                Producto producto = new Producto();

                producto.Id_producto = int.Parse(drProducto[0].ToString());
                producto.Nombre_producto = drProducto[1].ToString();
                producto.Precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.Iva = decimal.Parse(drProducto[3].ToString());

                lstProductos.Add(producto);
            }

            return lstProductos;
        }
        public List<Producto> buscarProducto(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            List<Producto> lstProductos = new List<Producto>();
            DataTable dtProductos = productoDao.buscarProducto(texto_buscar, numero_pagina, numero_elementos);

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                DataRow drProducto = dtProductos.Rows[i];

                Producto producto = new Producto();

                producto.Id_producto = int.Parse(drProducto[0].ToString());
                producto.Nombre_producto = drProducto[1].ToString();
                producto.Precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.Iva = decimal.Parse(drProducto[3].ToString());

                lstProductos.Add(producto);
            }

            return lstProductos;
        }
    }
}

