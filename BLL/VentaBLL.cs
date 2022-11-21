using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace BLL
{
    public class VentaBLL
    {
        VentaMP Vmp = new VentaMP();
        public void Agregar_venta(Venta Ve) { Vmp.Agregar_venta(Ve); }
    }
}
