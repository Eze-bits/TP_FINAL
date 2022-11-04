﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Entidades
{
    public class Panificados : ICloneable
    {
        public int Nro_lote { get; set; }
        public int Peso { get; set; }
        public int Unidades { get; set; }
        public string Descripcion { get; set; }
        public virtual void agregar_descripcion() { Descripcion = "Panificado generico"; }
        public object Clone() { return this.MemberwiseClone(); }
        public string ID { get; set; }
        protected int Precio { get; set; }

        public int Leer_precio() { return Precio; }
        public void Grabar_precio(int pPrecio) { this.Precio = pPrecio; }
    }
}
