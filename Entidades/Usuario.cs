using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Pass { get; set; }

        public Usuario(string pNombre, string pPass) { Nombre = pNombre; Pass = pPass; }

    }
}
