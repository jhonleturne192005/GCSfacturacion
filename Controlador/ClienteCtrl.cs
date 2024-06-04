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

        public string insertarCliente(Cliente cliente)
        {
            int estado_insercion = clienteDao.insertarCliente(cliente.getXml());
            
            switch (estado_insercion)
            {
                case 0:
                    return "El cliente fue insertado correctamente";
                case 1:
                    return "Ya existe un cliente con la identificación ingresada";
                default:
                    return "Error en la inserción del cliente";
            }
        }

        public string modificarCliente(Cliente cliente)
        {
            int estado_modificacion = clienteDao.modificarCliente(cliente.getXml());

            switch (estado_modificacion)
            {
                case 0:
                    return "El cliente fue insertado correctamente";
                case 1:
                    return "Ya existe un cliente con la identificación ingresada";
                default:
                    return "Error en la inserción del cliente";
            }
        }

        public List<Cliente> listarClientes(int numero_pagina, int numero_elementos)
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable dtClientes = clienteDao.listarClientes(numero_pagina, numero_elementos);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {                
                DataRow drCliente = dtClientes.Rows[i];
                Cliente cliente = new Cliente();
                cliente.Cedula = drCliente[0].ToString();
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

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                cliente = new Cliente();

                DataRow drCliente = dtClientes.Rows[i];
                cliente.Cedula = drCliente[0].ToString();
                cliente.Apellidos = drCliente[1].ToString();
                cliente.Nombres = drCliente[2].ToString();
            }
            
            return cliente;
        }
    }
}
