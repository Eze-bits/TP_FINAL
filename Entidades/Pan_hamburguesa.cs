﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pan_hamburguesa_comun : Panificados
    {
       public Pan_hamburguesa_comun(int pUnidades)
        {
            Peso = 200;
            Unidades = pUnidades;
            agregar_descripcion();
            ID = "PHC";
        }

        public Pan_hamburguesa_comun() { agregar_descripcion(); Peso = 200; }

        public Pan_hamburguesa_comun(int pNro_lote,int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 200;
            Unidades = pUnidades;
            ID = "PHC";
            agregar_descripcion();
        }


     public override void agregar_descripcion() {this.Descripcion = "Pan hamburguesa comun"; ID = "PHC"; }


    }

    public class Pan_hamburguesa_maxi : Panificados
    {
       
        public Pan_hamburguesa_maxi(int pNro_lote, int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 320;
            Unidades = pUnidades;
            ID = "PHM";
            agregar_descripcion();
        }

        public Pan_hamburguesa_maxi(int pUnidades)
        {
            Peso = 320;
            Unidades = pUnidades;
            agregar_descripcion();
        }
        public Pan_hamburguesa_maxi() { agregar_descripcion(); Peso = 320; ID = "PHM"; }

        public override void agregar_descripcion() { this.Descripcion = "Pan hamburguesa maxi"; ID = "PHM"; }
    }





}