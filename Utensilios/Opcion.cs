using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public class Opcion<T>
    {
        public string ValorMostrar { get; set; }
        public T ValorMiembro { get; set; }

        public Opcion(string valorMostrar, T valorMiembro)
        {
            this.ValorMiembro = valorMiembro;
            this.ValorMostrar = valorMostrar;
        }
    }
}
