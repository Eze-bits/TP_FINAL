using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
   public class Lista_precios
    {
    public DateTime Fecha_actualizacion { get; set; }
        public int PHC { get; set; }
        public int PHM { get; set; }
        public int PLC { get; set; }
        public int PLG { get; set; }
        public int PPC { get; set; }
        public int PPM { get; set; }
    }
}
