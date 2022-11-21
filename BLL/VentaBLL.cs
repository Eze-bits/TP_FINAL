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
        public decimal[] Graficar_x_dia(DateTime fecha) { return Vmp.graficar_x_dia(fecha); }
    }
}
