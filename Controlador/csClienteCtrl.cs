using SistemaFacturacion.DAO;
using SistemaFacturacion.Dto;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    class csClienteCtrl
    {
        csClienteDao clienteDao;
        public csClienteCtrl()
        {
            this.clienteDao = new csClienteDao();
        }

        public List<csClienteDto> listarClientes(int numero_pagina, int numero_elementos)
        {
            List<csClienteDto> clientes = new List<csClienteDto>();
            DataTable dtClientes = clienteDao.listarClientes(numero_pagina, numero_elementos);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {                
                DataRow drCliente = dtClientes.Rows[i];
                csClienteDto cliente = new csClienteDto();
                cliente.Cedula = drCliente[0].ToString();
                cliente.Apellidos = drCliente[1].ToString();
                cliente.Nombres = drCliente[2].ToString();

                clientes.Add(cliente);
            }

            return clientes;
        }

        public csClienteDto getCliente(string id_cliente)
        {
            csClienteDto cliente = null;
            DataTable dtClientes = clienteDao.getCliente(id_cliente);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                cliente = new csClienteDto();

                DataRow drCliente = dtClientes.Rows[i];
                cliente.Cedula = drCliente[0].ToString();
                cliente.Apellidos = drCliente[1].ToString();
                cliente.Nombres = drCliente[2].ToString();
            }
            
            return cliente;
        }
    }
}
