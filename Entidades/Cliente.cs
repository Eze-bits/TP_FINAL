using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region Propiedades
   
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public int Nro_casa { get; set; }
        public int Telefono_particular { get; set; }
        public string Email { get; set; }



        #endregion

        List<Pedido> Pedidos_cliente = new List<Pedido>();
        
        #region Constructores
        public Cliente() { }

        public Cliente(string pNombre, string pApellido, string pEmail, string pCalle, int pNro_casa, string pLocalidad, int pTelefono_particular, int pDNI)
        {
           
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
            Calle = pCalle;
            Nro_casa = pNro_casa;
            Localidad = pLocalidad;
            Telefono_particular = pTelefono_particular;
            Email = pEmail;
        }
        #endregion



    }
}