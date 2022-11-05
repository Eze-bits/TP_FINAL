using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class Rol : Componente
    {
        public string Nombre { get; set; }
        private string Pass { get; set; }

        public string Obtener_Pass() { return Pass; }
        public void Grabar_Pass(string pPass) { Pass = pPass; }
    }
}
