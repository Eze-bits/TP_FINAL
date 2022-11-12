using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Servicios
{
    public abstract class Componente
    {
        protected string Nombre { get; set; }              ///Nombre



      



        public Componente(string pNombre)
        {
            this.Nombre = pNombre;
        }

        public abstract void Agregar(Componente c);
        public abstract void Remover(Componente c);


    }
}
