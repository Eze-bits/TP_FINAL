using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Rol : Componente
    {
        
        public Rol(string Nombre) : base(Nombre)
        {
            comp = new List<Componente>();        
        }
        public List<Componente> comp;
        public override void Agregar(Componente c)
        {
            comp.Add(c);
        }

        public override void Remover(Componente c)
        {
            comp.Remove(c);
        }


      
    }
}
