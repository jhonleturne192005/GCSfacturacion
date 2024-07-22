using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SistemaFacturacion.AccesoDatos
{
    public class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + DatosConexion.server +
                ";DataBase=" + DatosConexion.base_datos +
                ";User id=" + DatosConexion.usuario +
                ";Password=" + DatosConexion.clave;
        }

        public bool ConexionAbierta()
        {
            return con.State == ConnectionState.Open;
        }

        public void AbrirConexion()
        {
            if (con != null && con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void CerrarConexion()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable obtenerDatosSp(string nombre_procedimiento, SqlParameter[] lst_parametros)
        {
            DataTable dtResultado = new DataTable();

            try
            {
                this.AbrirConexion();

                SqlDataAdapter adaptador = new SqlDataAdapter();

                //Crear el comando con el procedimiento almacenado y los parámetros recibidos
                SqlCommand cmd = new SqlCommand(nombre_procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst_parametros != null)
                {
                    //Agregar los parámetros al comando
                    cmd.Parameters.AddRange(lst_parametros);
                }

                //Ejecutar el procedimiento y llenar el datatable
                adaptador.SelectCommand = cmd;
                adaptador.Fill(dtResultado);

                this.CerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CerrarConexion();
            }

            return dtResultado;
        }

        public XmlDocument obtenerXmlRp(string nombre_procedimiento, SqlParameter[] lst_parametros)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (lst_parametros == null) return null;

            try
            {
                this.AbrirConexion();


                //Crear el comando con el procedimiento almacenado y los parámetros recibidos
                SqlCommand cmd = new SqlCommand(nombre_procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Agregar los parámetros al comando
                cmd.Parameters.AddRange(lst_parametros);
                DataSet ds = new DataSet();

                XmlReader reader = cmd.ExecuteXmlReader();
                xmlDoc.Load(reader);                

                this.CerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CerrarConexion();
            }

            return xmlDoc;
        }

        public int ejecutarDmlSp(string nombre_procedimiento, SqlParameter[] lst_parametros)
        {
            int estado_transaccion = -1;
            if (lst_parametros == null) return estado_transaccion;

            try
            {
                this.AbrirConexion();
                SqlDataAdapter adaptador = new SqlDataAdapter();

                //Crear el comando con el procedimiento almacenado y los parámetros recibidos
                SqlCommand cmd = new SqlCommand(nombre_procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Agregar parámetro de salida
                SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
                parametro_salida.Direction = ParameterDirection.Output;

                //Agregar los parámetros al comando
                cmd.Parameters.AddRange(lst_parametros);

                //Agregar el parámetro de salida
                cmd.Parameters.Add(parametro_salida);

                //Ejecutar el procedimiento
                cmd.ExecuteNonQuery();

                //Guardar el estado de la ejecución del procedimiento
                estado_transaccion = int.Parse(parametro_salida.Value.ToString());
                this.CerrarConexion();
            }
            catch (Exception ex)
            {
                this.CerrarConexion();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return estado_transaccion;
        }


        public string[] ejecutarConsultaOutputs(string nombre_procedimiento, SqlParameter[] lst_parametros, int numero_parametrosSalida)
        {
            string[] parametros_output = null;
            if (lst_parametros == null) return null;

            try
            {
                this.AbrirConexion();
                SqlDataAdapter adaptador = new SqlDataAdapter();

                //Inicializar el array de parámetros de salida
                parametros_output = new string[numero_parametrosSalida];

                //Crear el comando con el procedimiento almacenado y los parámetros recibidos
                SqlCommand cmd = new SqlCommand(nombre_procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;
                               
                //Agregar los parámetros al comando
                //Los parámetros de salida van incluidos en todos
                cmd.Parameters.AddRange(lst_parametros);

                //Ejecutar el procedimiento
                cmd.ExecuteNonQuery();

                //Guardar las variables de salida
                int contador = 0;
                for (int i = numero_parametrosSalida; i > 0; i--)
                {
                    //Índice para obtener los parámetros de salida en el mismo orden 
                    //que fueron ingresados
                    int indice = cmd.Parameters.Count - i;
                    parametros_output[contador] = cmd.Parameters[indice].Value.ToString();

                    contador++;
                }
               
                this.CerrarConexion();
            }
            catch (Exception ex)
            {
                this.CerrarConexion();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return parametros_output;
        }
    }
}
