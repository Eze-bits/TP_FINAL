﻿using System;
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
        public bool Checkear_existencia_pr() { return pMP.Checkear_existencia_precios(); }
        public void Modificar_lista_pre(Lista_precios Pr,bool mod) { pMP.Modificar_lista_precios(Pr,mod); }
    }
}
