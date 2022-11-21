﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Rol : Componente
    {

        public List<Componente> lista_permisos= new  List<Componente>();
     
        public Rol(string Nombre) : base(Nombre)
        {
         

        }

     public override List<Componente> obtener_lista() { return this.lista_permisos; }

        public override void Agregar(Componente c)
        {
            lista_permisos.Add(c);
        }

        public override void Remover(Componente c)
        {
            lista_permisos.Remove(c);
        }



    }
}
