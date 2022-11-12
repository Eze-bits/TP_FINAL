using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
  public  class Rol : Componente
    {
        public string Pass { get; set; }
        public List<Componente> lista_permisos;

        public Rol(string Nombre) : base(Nombre)
        {
            lista_permisos = new List<Componente>();

        }
        
        public string retorna_nombre() { return Nombre; }

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
