using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    class ProductoCtrl
    {
        ProductoDao productoDao;

        public ProductoCtrl()
        {
            productoDao = new ProductoDao();
        }

        public List<Producto> listarProductos()
        {
            List<Producto> lstProductos = new List<Producto>();
            DataTable dtProductos = productoDao.listarProductos();

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
    }
}
