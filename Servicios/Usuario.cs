using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Usuario
    {
        public int ID_usuario { get; set; }
        public string Nombre { get; set; }
        protected string Pass { get; set; }
        List<Componente> Lista_roles = new List<Componente>();
        
        public Usuario(string pNombre, string pPass)
        {
            Nombre = pNombre;
            this.Guardar_pass(pPass);
        }

        public Usuario(string pPass)
        { this.Guardar_pass(pPass); }


        public string Obtener_pass() { return Pass; }
        public void Guardar_pass(string p) { this.Pass = p; }
        public Usuario() { }

    }
}
