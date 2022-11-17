using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Bitacora
    {
        public int ID_usuario { get; set; }
        public string Tipo_de_movimiento { get; set; }  ///BACKUP o RESTAURACION
        public DateTime Fecha { get; set; }
        public string Nombre_de_archivo { get; set; }
        private string Ruta { get; set; }



        public Bitacora(int pID_usuario, string pMovimiento)
        {
            ID_usuario = pID_usuario;
            Tipo_de_movimiento = pMovimiento;
            Fecha = DateTime.Now;
        }

        public string Obtener_ruta() { return this.Ruta; } 
        public void Crear_ruta(string pRuta) { Ruta = pRuta; }


    }
}
