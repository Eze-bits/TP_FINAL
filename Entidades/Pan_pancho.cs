using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pan_pancho_chico : Panificados
    {
        public Pan_pancho_chico(int pUnidades)
        {
            Peso = 230;
            Unidades = pUnidades;
            ID = "PPC";
            agregar_descripcion();
        }

        public Pan_pancho_chico(int pNro_lote, int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 230;
            ID = "PPC";
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_pancho_chico() { agregar_descripcion(); Peso = 230; ID = "PPC"; }
        public override void agregar_descripcion() { this.Descripcion = "Pan pancho chico"; ID = "PPC"; }

    }


    public class Pan_pancho_maxi : Panificados
    {
        public Pan_pancho_maxi(int pUnidades)
        {
            Peso = 350;
            Unidades = pUnidades;
            agregar_descripcion();
            ID = "PPM";
        }

        public Pan_pancho_maxi(int pNro_lote, int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 350;
            ID = "PPM";
            Unidades = pUnidades;
            agregar_descripcion();

        }

        public  Pan_pancho_maxi() { agregar_descripcion(); Peso = 350; ID = "PPM"; }

        public override void agregar_descripcion() { this.Descripcion = "Pan pancho maxi"; ID = "PPM"; }

    }





}