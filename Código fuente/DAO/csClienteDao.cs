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
    class csClienteDao
    {
        csConexion conexion;

        public csClienteDao()
        {
            this.conexion = new csConexion();
        }

        public DataTable listarClientes(int numero_pagina, int numero_elementos)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_paginacion_listar_clientes", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_pagina", numero_pagina);
                cmd.Parameters.AddWithValue("@numero_elementos", numero_elementos);

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                
            }

            return dataTable;
        }

        public DataTable getCliente(string id_cliente)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_get_cliente", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {

            }

            return dataTable;
        }

        public DataTable getCantidadCliente(string id_cliente)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("sp_get_cliente", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

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
