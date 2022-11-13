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
        public  string Descripcion { get; set; }        ///Nombre

        public Componente(string pNombre)
        {
            this.Descripcion = pNombre;
        }

        public abstract void Agregar(Componente c);
        public abstract void Remover(Componente c);


    }
}
