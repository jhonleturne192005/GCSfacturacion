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
    class ClienteDao
    {
        Conexion conexion;

        public ClienteDao()
        {
            this.conexion = new Conexion();
        }

        public int insertarCliente(string xmlCliente)
        {
            int estado_insercion = -1;
            try
            {
                conexion.AbrirConexion();
                
                SqlCommand cmd = new SqlCommand("sp_insertar_cliente", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@xml_cliente", xmlCliente);

                //Parámetro de salida (estado de la inserción)                
                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro_salida);

                //Obtener el estado resultante de la ejecución del procedimiento almacenado
                cmd.ExecuteNonQuery();
                estado_insercion = int.Parse(parametro_salida.Value.ToString());

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return estado_insercion;
        }

        public int modificarCliente(string xmlCliente)
        {
            int estado_modificacion = -1;
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_modificar_cliente", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@xml_cliente", xmlCliente);

                //Parámetro de salida(estado de la inserción)
                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro_salida);

                //Obtener el estado resultante de la ejecución del procedimiento almacenado
                cmd.ExecuteNonQuery();
                estado_modificacion = int.Parse(parametro_salida.Value.ToString());

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return estado_modificacion;
        }

        public int eliminarCliente(string id_cliente)
        {
            int estado_eliminacion = -1;

            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_eliminar_cliente", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

                //Parámetro de salida(estado de la inserción)
                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro_salida);

                //Obtener el estado resultante de la ejecución del procedimiento almacenado
                cmd.ExecuteNonQuery();
                estado_eliminacion = int.Parse(parametro_salida.Value.ToString());


                conexion.CerrarConexion();
            }
            catch(Exception ex)
            {

            }

            return estado_eliminacion;
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
            catch (Exception ex)
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
            catch (Exception ex)
            {

            }

            return dataTable;
        }

    }
}
