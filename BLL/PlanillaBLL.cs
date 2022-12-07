using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace BLL
{
    public class PlanillaBLL
    {
        PlanillaMP pMP = new PlanillaMP();

        public bool Checkear_planilla() { return pMP.Checkear_planilla(); }

        public void Guardar_planilla(Planilla_produccion pl)
        {
            pMP.Guardar_planilla(pl);
        }

    }
}
