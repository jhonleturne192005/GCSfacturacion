using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    public class TipoUsuarioCtrl
    {
        TipoUsuarioDao tipoUsuarioDao;
        public TipoUsuarioCtrl()
        {
            tipoUsuarioDao = new TipoUsuarioDao();
        }

        public List<TipoUsuario> listarTipoUsuarios()
        {
            DataTable dtTipoUsuarios = tipoUsuarioDao.ListarTipoUsuarios();

            List<TipoUsuario> lstTipoUsuarios = new List<TipoUsuario>();

            for (int i = 0; i < dtTipoUsuarios.Rows.Count; i++)            
            {
                TipoUsuario tipo_usuario = new TipoUsuario();

                DataRow drTipoUsuario = dtTipoUsuarios.Rows[i];
                tipo_usuario.Id_tipo_usuario = int.Parse(drTipoUsuario[0].ToString());
                tipo_usuario.Tipo_usuario = drTipoUsuario[1].ToString();
                tipo_usuario.Descripcion = drTipoUsuario[2].ToString();

                lstTipoUsuarios.Add(tipo_usuario);
            }

            return lstTipoUsuarios;
        }

        public Opcion<int>[] getOpcionesTipoUsuarios()
        {
            List<TipoUsuario> lstTipoUsuarios = listarTipoUsuarios();
            Opcion<int>[] opcionesTipo = new Opcion<int>[lstTipoUsuarios.Count];

            for (int i = 0; i < lstTipoUsuarios.Count; i++)
            {
                opcionesTipo[i] = new Opcion<int>(lstTipoUsuarios[i].Tipo_usuario, lstTipoUsuarios[i].Id_tipo_usuario);
            }

            return opcionesTipo;
        }
    }
}
