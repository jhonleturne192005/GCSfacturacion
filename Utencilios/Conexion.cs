using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
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
                con.Open();
        }

        public void CerrarConexion()
        {
            if (con != null && con.State == ConnectionState.Open)
                con.Close();
        }

        private int gestionDatos(List<SqlParameter> lst_parametros, string nombre_procedimiento)
        {
            int estado = -1;
            try
            {
                if (lst_parametros.Count > 0)
                {
                    this.AbrirConexion();
                    SqlCommand cmd = new SqlCommand(nombre_procedimiento, this.ConexionSQL);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter sqlParameter in lst_parametros)
                        cmd.Parameters.Add(sqlParameter);
                    cmd.ExecuteNonQuery();
                    if (lst_parametros.Count>1)
                        estado = int.Parse(lst_parametros[lst_parametros.Count - 1].Value.ToString());
                    this.CerrarConexion();
                    return estado;
                }
                else
                    Mensaje.error("Error no existen parametros");
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
                this.CerrarConexion();
            }
            return estado;
        }

        private DataSet ObtenerDatos(List<SqlParameter> lst_parametros, string nombre_procedimiento, SqlParameter parametro)
        {
            try
            {
                if (lst_parametros!=null || parametro!=null) 
                {
                    DataSet ds = new DataSet();
                    this.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(nombre_procedimiento, this.ConexionSQL);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (lst_parametros == null && parametro != null)
                        cmd.Parameters.Add(parametro);
                    else if (lst_parametros.Count > 0 && parametro == null)
                    {
                        foreach (SqlParameter sqlParameter in lst_parametros)
                            cmd.Parameters.Add(sqlParameter);
                    }
                    else
                    {
                        Mensaje.error("Error no existe el parametro");
                        return null;
                    }

                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(ds);
                    this.CerrarConexion();
                    return ds;
                }
                else
                {
                    Mensaje.error("Error no existen el parametros");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
                this.CerrarConexion();
            }
            return null;
        }


        public int guardar(List<SqlParameter> lst_parametros,string nombre_procedimiento)
        {
            return this.gestionDatos(lst_parametros, nombre_procedimiento);
        }

        public int actualizar(List<SqlParameter> lst_parametros, string nombre_procedimiento)
        {
            return this.gestionDatos(lst_parametros, nombre_procedimiento);
        }

        public int eliminar(List<SqlParameter> lst_parametros, string nombre_procedimiento)
        {
            return this.gestionDatos(lst_parametros, nombre_procedimiento);
        }

        public DataTable listar(List<SqlParameter> lst_parametros, string nombre_procedimiento)
        {
            return this.ObtenerDatos(lst_parametros, nombre_procedimiento,null).Tables[0];
        }

        public DataTable buscar(List<SqlParameter> lst_parametros, string nombre_procedimiento,SqlParameter parametro)
        {
            return this.ObtenerDatos(lst_parametros, nombre_procedimiento, parametro).Tables[0];
        }

        //MT=Multiples Tablas
        public DataSet buscarMT(List<SqlParameter> lst_parametros, string nombre_procedimiento, SqlParameter parametro)
        {
            return this.ObtenerDatos(lst_parametros, nombre_procedimiento, parametro);
        }


    }
}
