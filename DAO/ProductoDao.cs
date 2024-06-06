using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.DAO
{
    class ProductoDao
    {
        Conexion conexion;
        public ProductoDao()
        {
            conexion = new Conexion();
        }

 
        public DataTable listarProductos(int numero_pagina, int numero_elementos)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_paginacion_listar_productos", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_pagina", numero_pagina);
                cmd.Parameters.AddWithValue("@numero_elementos", numero_elementos);
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return dataTable;
        }

        public DataTable getProducto(int id_producto)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_get_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dataTable;
        }

        public DataTable buscarProducto(string texto_buscar)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_buscar_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto_buscar", texto_buscar);
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dataTable;
        }


        public DataTable buscarProducto(string texto_buscar,int numero_pagina, int numero_elementos)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_paginacion_buscar_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto_buscar", texto_buscar);
                cmd.Parameters.AddWithValue("@numero_pagina", numero_pagina);
                cmd.Parameters.AddWithValue("@numero_elementos", numero_elementos);
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dataTable;
        }


        public int insertarProducto(string xmlProducto)
        {
            //int estado_insercion = -1;
            int estado_insercion = 0;
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_insertar_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@xml_producto", xmlProducto);
                

                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro_salida);
                cmd.ExecuteNonQuery();
                estado_insercion = int.Parse(parametro_salida.Value.ToString());

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return estado_insercion;
        }


        public int actualizarProducto(string xmlProducto)
        {
            //int estado_insercion = -1;
            int estado_insercion = 0;
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_modificar_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@xml_producto", xmlProducto);
                SqlDataReader reader = cmd.ExecuteReader();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return estado_insercion;
        }


        public int eliminarProducto(int id_producto)
        {
            //int estado_insercion = -1;
            int estado_eliminacion = 0;
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_eliminar_producto", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_producto", id_producto);

                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro_salida);
                cmd.ExecuteNonQuery();
                estado_eliminacion = int.Parse(parametro_salida.Value.ToString());
                //MessageBox.Show(estado_insercion.ToString());
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return estado_eliminacion;
        }


    }
}
