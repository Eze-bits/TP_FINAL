using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace BLL
{
    public class PreciosBLL
    {
        PreciosMP pMP = new PreciosMP();
        public bool checkear_cambios() { return pMP.Checkear_existencia_precios(); }

    }
}
