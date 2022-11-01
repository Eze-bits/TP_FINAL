﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Pedido
    {
        

        #region Propiedades
        public int Nro_pedido { get; set; }
        private int DNI_cliente { get; set; }
        public string Estado { get; set; }
        #endregion

        private List<Panificados> Lista_panificados = new List<Panificados>();

        public int Obtener_DNI() { return DNI_cliente; }
        public void Grabar_DNI(int DNI) { this.DNI_cliente = DNI; }

        #region Metodos

        public List<Panificados> retorna_lista_panificados()
        {

            foreach (Panificados P in Lista_panificados)
            {
                if (P.Unidades == 0)

                { Lista_panificados.Remove(P); break; }        /// limpio unidades en cero

            }
            return this.Lista_panificados;
        }
        public void agregar(Panificados P) { Lista_panificados.Add(P); }
        #endregion

        #region Constructores
        public Pedido() { Estado = "No confirmado"; }    //no confirmado - confirmado - facturado - anulado
        #endregion



    }
}
