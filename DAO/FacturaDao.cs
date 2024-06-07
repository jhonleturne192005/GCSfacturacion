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
    class FacturaDao
    {
        Conexion conexion;
        public FacturaDao()
        {
            conexion = new Conexion();
        }

        public int insertarFactura(string xmlFactura)
        {
            int estado_insercion = -1;
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("sp_insertar_factura", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@xml_factura", xmlFactura);

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
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return estado_insercion;
        }

        public DataTable listarFactura(int numero_pagina, int numero_elementos)
        {
            DataTable dtFacturas = new DataTable();
            try
            {
                conexion.AbrirConexion();
                SqlDataAdapter dataApdater = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand("sp_paginacion_listar_facturas", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@numero_pagina", numero_pagina);
                cmd.Parameters.AddWithValue("@numero_elementos", numero_elementos);

                dataApdater.SelectCommand = cmd;
                dataApdater.Fill(dtFacturas);

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex + "Test");
            }

            return dtFacturas;
        }

        public DataTable buscarFactura(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            DataTable dtFacturas = new DataTable();
            try
            {
                conexion.AbrirConexion();
                SqlDataAdapter dataApdater = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand("sp_paginacion_buscar_facturas", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@numero_pagina", numero_pagina);
                cmd.Parameters.AddWithValue("@numero_elementos", numero_elementos);
                cmd.Parameters.AddWithValue("@texto_buscar", texto_buscar);

                dataApdater.SelectCommand = cmd;
                dataApdater.Fill(dtFacturas);

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex + "Test");
            }

            return dtFacturas;
        }

        public DataSet visualizarFactura(int id_factura)
        {            
            DataSet ds = new DataSet();
            try
            {
                conexion.AbrirConexion();
                SqlDataAdapter dataApdater = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand("sp_visualizar_factura", conexion.ConexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_factura", id_factura);

                dataApdater.SelectCommand = cmd;
                dataApdater.Fill(ds);

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex + "Test");
            }

            return ds;
        }
    }

}
