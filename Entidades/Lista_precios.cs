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
        public DateTime Fecha_de_ultima_actualizacion { get; set; }
        public Pan_hamburguesa_comun PHC { get; set; }
        public Pan_hamburguesa_maxi PHM { get; set; }
        public Pan_lactal_chico PLC { get; set; }
        public Pan_lactal_grande PLG { get; set; }
        public Pan_pancho_chico PPC { get; set; }
        public Pan_pancho_maxi PPM { get; set; }
        public Lista_precios()
        {
            Fecha_de_ultima_actualizacion = DateTime.Now.Date;

        }

    }
}
