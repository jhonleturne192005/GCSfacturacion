using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DAO
{
    class csProductoDao
    {
        csConexion conexion;
        public csProductoDao()
        {
            conexion = new csConexion();
        }

        public DataTable listarProductos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_listar_productos", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch(Exception e)
            {

            }

            return dataTable;
        }

        public DataTable listarProductos(int numero_pagina, int numero_elementos)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_listar_productos", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {

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

            }

            return dataTable;
        }
    }
}
