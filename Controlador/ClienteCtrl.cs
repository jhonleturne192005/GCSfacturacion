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
    class ClienteCtrl
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
                    mensaje = "se ha producido un error durante la inserción del cliente";
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

        public Respuesta eliminarCliente(string id_cliente)
        {
            int estado_eliminacion = clienteDao.eliminarCliente(id_cliente);

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
            List<Cliente> clientes = new List<Cliente>();
            DataTable dtClientes = clienteDao.listarClientes(numero_pagina, numero_elementos);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {                
                DataRow drCliente = dtClientes.Rows[i];
                Cliente cliente = new Cliente();
                cliente.Id_Cliente = drCliente[0].ToString();
                cliente.Apellidos = drCliente[1].ToString();
                cliente.Nombres = drCliente[2].ToString();

                clientes.Add(cliente);
            }

            return clientes;
        }

        public Cliente getCliente(string id_cliente)
        {
            Cliente cliente = null;
            DataTable dtClientes = clienteDao.getCliente(id_cliente);

            if (dtClientes.Rows.Count == 1) {
                cliente = new Cliente();

                DataRow drCliente = dtClientes.Rows[0];
                cliente.Id_Cliente = drCliente[0].ToString();
                cliente.Apellidos = drCliente[1].ToString();
                cliente.Nombres = drCliente[2].ToString();
            }
            
            return cliente;
        }
    }
}
