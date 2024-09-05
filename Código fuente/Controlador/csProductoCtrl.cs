using SistemaFacturacion.DAO;
using SistemaFacturacion.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    class csProductoCtrl
    {
        csProductoDao productoDao;

        public csProductoCtrl()
        {
            productoDao = new csProductoDao();
        }

        public List<csProductoDto> listarProductos()
        {
            List<csProductoDto> lstProductos = new List<csProductoDto>();
            DataTable dtProductos = productoDao.listarProductos();

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                DataRow drProducto = dtProductos.Rows[i];

                csProductoDto producto = new csProductoDto();

                producto.id_producto = int.Parse(drProducto[0].ToString());
                producto.nombre_producto = drProducto[1].ToString();
                producto.precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.iva = decimal.Parse(drProducto[3].ToString());

                lstProductos.Add(producto);
            }

            return lstProductos;
        }

        public csProductoDto getProducto(int id_producto)
        {
            csProductoDto producto = null;
            DataTable dtProducto = productoDao.getProducto(id_producto);

            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                producto = producto = new csProductoDto();
                DataRow drProducto = dtProducto.Rows[i];

                producto.id_producto = int.Parse(drProducto[0].ToString());
                producto.nombre_producto = drProducto[1].ToString();
                producto.precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.iva = decimal.Parse(drProducto[3].ToString());
            }

            return producto;
        }

        public List<csProductoDto> buscarProducto(string texto_buscar)
        {
            List<csProductoDto> lstProductos = new List<csProductoDto>();
            DataTable dtProductos = productoDao.buscarProducto(texto_buscar);

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                DataRow drProducto = dtProductos.Rows[i];

                csProductoDto producto = new csProductoDto();

                producto.id_producto = int.Parse(drProducto[0].ToString());
                producto.nombre_producto = drProducto[1].ToString();
                producto.precio_unitario = decimal.Parse(drProducto[2].ToString());
                producto.iva = decimal.Parse(drProducto[3].ToString());

                lstProductos.Add(producto);
            }

            return lstProductos;
        }
    }
}
