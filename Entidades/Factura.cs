using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Factura
    {
        public int Nro_factura { get; set; }
        public Cliente Cli { get; set; }
        public Pedido Ped { get; set; }
        public int total { get; set; }
    }
}
