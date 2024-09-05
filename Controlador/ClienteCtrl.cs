using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    public class ClienteCtrl
    {
        ClienteDao clienteDao;
        public ClienteCtrl()
        {
            this.clienteDao = new ClienteDao();
        }

        public Respuesta insertarCliente(Cliente cliente)
        {
            int estado_insercion = clienteDao.insertarCliente(cliente.getXml());

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

        public Respuesta modificarCliente(Cliente cliente)
        {
            int estado_modificacion = clienteDao.modificarCliente(cliente.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_modificacion)
            {
                case 0:
                    mensaje = "El cliente fue modificado correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "Se ha producido un error durante la modificación del cliente";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public Respuesta eliminarCliente(int IdPersona)
        {
            int estado_eliminacion = clienteDao.eliminarCliente(IdPersona);

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_eliminacion)
            {
                case 0:
                    mensaje = "El cliente fue eliminado correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "Se ha producido un error durante la eliminación el cliente";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public List<Cliente> listarClientes(int numero_pagina, int numero_elementos)
        {
            List<Cliente> lstClientes = new List<Cliente>();
            DataTable dtClientes = clienteDao.listarClientes(numero_pagina, numero_elementos);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                DataRow drCliente = dtClientes.Rows[i];

                Cliente cliente = new Cliente();
                cliente.IdPersona = int.Parse(drCliente[0].ToString());
                cliente.Cedula = drCliente[1].ToString();
                cliente.Apellidos = drCliente[2].ToString();
                cliente.Nombres = drCliente[3].ToString();

                lstClientes.Add(cliente);
            }

            return lstClientes;
        }

        public List<Cliente> buscarClientes(int numero_pagina, int numero_elementos, string xml_filtros_busqueda)
        {
            List<Cliente> lstClientes = new List<Cliente>();
            DataTable dtClientes = clienteDao.buscarClientes(numero_pagina, numero_elementos, xml_filtros_busqueda);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                DataRow drCliente = dtClientes.Rows[i];
                Cliente cliente = new Cliente();
                cliente.IdPersona = int.Parse(drCliente[0].ToString());
                cliente.Cedula = drCliente[1].ToString();
                cliente.Apellidos = drCliente[2].ToString();
                cliente.Nombres = drCliente[3].ToString();

                lstClientes.Add(cliente);
            }

            return lstClientes;
        }

        public Cliente getClientePorId(int IdPersona)
        {
            Cliente cliente = null;
            DataTable dtClientes = clienteDao.getClientePorId(IdPersona);

            if (dtClientes.Rows.Count == 1)
            {
                cliente = new Cliente();

                DataRow drCliente = dtClientes.Rows[0];

                cliente.IdPersona = int.Parse(drCliente[0].ToString());
                cliente.Cedula = drCliente[1].ToString();
                cliente.Apellidos = drCliente[2].ToString();
                cliente.Nombres = drCliente[3].ToString();
            }

            return cliente;
        }

        public Cliente getClientePorCedula(string cedula_cliente)
        {
            Cliente cliente = null;
            DataTable dtClientes = clienteDao.getClientePorCedula(cedula_cliente);

            if (dtClientes.Rows.Count == 1)
            {
                cliente = new Cliente();

                DataRow drCliente = dtClientes.Rows[0];

                cliente.IdPersona = int.Parse(drCliente[0].ToString());
                cliente.Cedula = drCliente[1].ToString();
                cliente.Apellidos = drCliente[2].ToString();
                cliente.Nombres = drCliente[3].ToString();
            }

            return cliente;
        }

        public Opcion<string>[] getFiltrosBusqueda()
        {
            return new Opcion<string>[]
            {
               new Opcion<string>("CI. Cliente", "cedula_cliente"),
               new Opcion<string>("Cliente", "cliente"),
            };
        }
    }
}
