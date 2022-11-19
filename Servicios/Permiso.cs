using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public class Permiso : Componente
    {
        public List<Componente> le;
  
        public Permiso(string Nombre) : base(Nombre)
        {
            le = new List<Componente>();
        }
        public override void Agregar(Componente c)
        {
            le.Add(c);
        }
        public override void Remover(Componente c)
        {
            le.Remove(c);
        }



    }
}
