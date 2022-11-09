using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Rol : Componente
    {
        //public string Usuario { get; set; }
        //private string Pass { get; set; }
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


        //public string Obtener_Pass() { return Pass; }
        //public void Grabar_Pass(string pPass) { Pass = pPass; }
    }
}
