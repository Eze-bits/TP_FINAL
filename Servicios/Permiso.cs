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
        public List<Componente> le = new List<Componente>();

        public Permiso(string Nombre) : base(Nombre)
        {
      
        }
        public override void Agregar(Componente c)
        {
            
        }
        public override void Remover(Componente c)
        {
            
        }
        public override List<Componente> obtener_lista() { return this.le; }


    }
}
