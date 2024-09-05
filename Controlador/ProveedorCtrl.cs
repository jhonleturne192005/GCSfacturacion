using System.Data;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;

namespace SistemaFacturacion.Controlador
{
    public  class ProveedorCtrl
    {
        ProveedorDao proveedorDao; 
        public ProveedorCtrl()
        {
            this.proveedorDao = new ProveedorDao();

        }

        public List<Proveedor> listarProveedores(int numero_pagina, int numero_elementos)
        {
            List<Proveedor> lstProveedor = new List<Proveedor>();
            DataTable dtClientes = proveedorDao.listarProveedores(numero_pagina, numero_elementos);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                DataRow drProveedor = dtClientes.Rows[i];

                Proveedor proveedor = new Proveedor();
                proveedor.IdProveedor = int.Parse(drProveedor["id"].ToString());
                proveedor.IdPersona = int.Parse(drProveedor["id_persona"].ToString());
                proveedor.Cedula = drProveedor["cedula"].ToString();
                proveedor.Apellidos = drProveedor["apellidos"].ToString();
                proveedor.Nombres = drProveedor["nombre"].ToString();
                proveedor.Email = drProveedor["email"].ToString();
                lstProveedor.Add(proveedor);
            }

            return lstProveedor;
        }

        public List<Proveedor> buscarProveedores(int numero_pagina, int numero_elementos, string xml_filtros_busqueda)
        {
            List<Proveedor> lstProveedor = new List<Proveedor>();
            DataTable dtClientes = proveedorDao.buscarProveedor(numero_pagina, numero_elementos, xml_filtros_busqueda);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                DataRow drProveedor = dtClientes.Rows[i];
                Proveedor proveedor = new Proveedor();
                proveedor.IdProveedor = int.Parse(drProveedor["id"].ToString());
                proveedor.IdPersona = int.Parse(drProveedor["id_persona"].ToString());
                proveedor.Cedula = drProveedor["cedula"].ToString();
                proveedor.Apellidos = drProveedor["apellidos"].ToString();
                proveedor.Nombres = drProveedor["nombres"].ToString();
                proveedor.Email = drProveedor["email"].ToString();

                lstProveedor.Add(proveedor);
            }

            return lstProveedor;
        }
        public Opcion<string>[] getFiltrosBusqueda()
        {
            return new Opcion<string>[]
            {
               new Opcion<string>("CI. Proveedor", "cedula"),
               new Opcion<string>("Proveedor", "proveedor"),
               new Opcion<string>("Email", "email")
            };
        }

        public Respuesta insertarProveedor(Proveedor proveedor)
        {
            int estado_insercion = proveedorDao.insertarProveedor(proveedor.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_insercion)
            {
                case 0:
                    mensaje = "El cliente fue insertado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Ya existe un cliente con la identificación ingresada";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la inserción del cliente";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }


        public Respuesta modificarProveedor(Proveedor proveedor)
        {
            int estado_insercion = proveedorDao.modificarProveedor(proveedor.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_insercion)
            {
                case 0:
                    mensaje = "El proveedor fue modificado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "Ya existe un proveedor con la identificación ingresada";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la inserción del cliente";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public Respuesta eliminarProveedor(int idProveedor)
        {
            int estado_eliminacion = proveedorDao.eliminarProveedor(idProveedor);

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_eliminacion)
            {
                case 0:
                    mensaje = "El proveedor fue eliminado correctamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "El proveedor no puede ser eliminado ya que existen productos asignados al mismo.";
                    completado = true;
                    break;
                default:
                    mensaje = "Se ha producido un error durante la eliminación de proveedor";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public Proveedor getProveedorPorCedula(string cedula_proveedor)
        {
            Proveedor proveedor = null;
            DataTable dtProveedor = proveedorDao.getProveedorPorCedula(cedula_proveedor);

            if (dtProveedor.Rows.Count == 1)
            {
                proveedor = new Proveedor();

                DataRow drProveedor = dtProveedor.Rows[0];

                proveedor.IdProveedor = int.Parse(drProveedor[0].ToString());
                proveedor.Cedula = drProveedor["cedula"].ToString();
                proveedor.Apellidos = drProveedor["apellidos"].ToString();
                proveedor.Nombres = drProveedor["nombres"].ToString();
                proveedor.Email = drProveedor["email"].ToString();
            }

            return proveedor;
        }

        public Proveedor getProveedorPorId(int IdProveedor)
        {
            Proveedor proveedor = null;
            DataTable dtProveedor = proveedorDao.getProveedorPorId(IdProveedor);

            if (dtProveedor.Rows.Count == 1)
            {
                proveedor = new Proveedor();

                DataRow drCliente = dtProveedor.Rows[0];

                proveedor.IdPersona = int.Parse(drCliente[0].ToString());
                proveedor.IdProveedor = IdProveedor;
                proveedor.Cedula = drCliente["cedula"].ToString();
                proveedor.Apellidos = drCliente["apellidos"].ToString();
                proveedor.Nombres = drCliente["nombres"].ToString();
                proveedor.Email = drCliente["email"].ToString();
            }

            return proveedor;
        }
    }
}
