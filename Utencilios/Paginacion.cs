using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    class Paginacion<T>
    {
        public List<T> Lst_Objetos { get; }
        public int Numero_elementos { get; }
        public int Elementos_Pagina { get; }

        public Paginacion(List<T> lstObjetos, int numero_elementos, int elementos_por_pagina, int total_elementos)
        {
            this.Lst_Objetos = lstObjetos;
            this.Numero_elementos = numero_elementos;
            this.Elementos_Pagina = elementos_por_pagina;
        }
    }
}
