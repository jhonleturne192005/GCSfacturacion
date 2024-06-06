using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
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


        public List<Producto> buscarProducto(string texto_buscar, int numero_pagina, int numero_elementos)
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

        public string[] insertarProducto(Producto producto)
        {
            //MessageBox.Show(producto.getXml());
            int estado_insersion = productoDao.insertarProducto(producto.getXml());

            switch (estado_insersion)
            {
                case 0:
                    return  new string[]{ "0","El producto fue insertado correctamente"};
                case 1:
                    return new string[] { "1", "Error no existe nombre de producto" };
                case 2:
                    return new string[] { "2", "Error el IVA debe estar en un rango de 0 a 100" };
                default:
                    return new string[] { "3", "Error en la inserción del producto" };
            }

        }


        public string actualizarProducto(Producto producto)
        {
            //MessageBox.Show(producto.getXml());
            int estado_insersion = productoDao.actualizarProducto(producto.getXml());

            switch (estado_insersion)
            {
                case 0:
                    return "El producto fue actualizado correctamente";
                case 1:
                    return "Ya existe un cliente con la identificación ingresada";
                default:
                    return "Error en la actualizacion del producto";
            }
        }


        public string eliminarProducto(int id_producto)
        {
            //MessageBox.Show(producto.getXml());
            int estado_insersion = productoDao.eliminarProducto(id_producto);

            switch (estado_insersion)
            {
                case 0:
                    return "El producto fue eliminado correctamente";
                default:
                    return "Error en la eliminación del producto";
            }
        }



    }
}

