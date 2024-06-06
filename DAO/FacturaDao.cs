using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
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

                SqlCommand cmd = new SqlCommand("sp_insertar_facturas", conexion.ConexionSQL);

                cmd.Parameters.AddWithValue("@xml_factura", xmlFactura);
                cmd.ExecuteReader();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return estado_insercion;
        }
    }
}
