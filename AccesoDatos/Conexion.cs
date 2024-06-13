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
    class Conexion
    {
        SqlConnection con;
        public SqlConnection ConexionSQL { get { return con; } }

        public Conexion()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + DatosConexion.server +
                ";DataBase=" + DatosConexion.base_datos +
                ";User id=" + DatosConexion.usuario +
                ";Password=" + DatosConexion.clave;
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

            if (lst_parametros == null) return dtResultado;

            try
            {
                this.AbrirConexion();

                SqlDataAdapter adaptador = new SqlDataAdapter();

                //Crear el comando con el procedimiento almacenado y los parámetros recibidos
                SqlCommand cmd = new SqlCommand(nombre_procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Agregar los parámetros al comando
                cmd.Parameters.AddRange(lst_parametros);

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


        /// <summary>
        /// Esta función ejecuta una transacción dml (lenguaje de manipulación de datos); es decir,
        /// que puede ejecutar transacciones como insert, update y delete. Al ejecutar esta función debe
        /// considerarse que el procedimiento a ejecutar debe tener una variable llamada "estado" de tipo output.
        /// </summary>
        /// <param name="nombre_procedimiento">
        /// Es el nombre del procedimiento almacenado que se desea
        /// ejecutar
        /// </param>
        /// <param name="lst_parametros">
        /// Lista de parámetros requeridos para la ejecución del procedimiento almacenado.
        /// Obligatorio enviar los parámetros de tipo output al final de la lista.
        /// </param>
        /// <returns>
        /// Un valor entero que indica los diferentes casos que pueden suceder durante
        /// la ejecución del procedimiento almacenado.
        /// Un valor de -1 indica que no se logró realizar una conexión con la base de datos.
        /// </returns>
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


        public string[] ejecutarDmlSp(string nombre_procedimiento, SqlParameter[] lst_parametros, int numero_parametrosSalida)
        {
            string[] parametros_output = new string [numero_parametrosSalida];
            if (lst_parametros == null) return null;

            try
            {
                this.AbrirConexion();
                SqlDataAdapter adaptador = new SqlDataAdapter();

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
