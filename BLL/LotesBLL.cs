using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper_DAL;
//using Mapper;

namespace BLL
{
    public class LotesBLL
    {
        LoteMP Ml = new LoteMP();
      //  public bool checkear_lote(Lote L) { return Ml.checkear_l(L); }

        public void graba_lote(Lote L) { Ml.Crear_lote(L); }
    //    public void modificar_stock(Lote L) { Ml.Modificar(L); }

        public bool Lotes_cargados() { return Ml.Checkear_lotes();  }

        public List<Lote> Retorna_listado_de_lotes()
        {
            return Ml.Listado_de_lotes();
        }

        public void Detalle_de_lote( Lote L)
        {
           Ml.Detalle_de_lote(L);
       
        }

       public void borrar_productos_lote(Panificados p) { Ml.Borrar_de_lote(p); }
      public void agregar_productos_lote(List<Panificados> lista_agregar) { Ml.agregar_a_lote_stock(lista_agregar); } 
     //   public void actualizar_stock_lotes(List<Lote> Lista_lotes) { Ml.actualizar_stock_lot(Lista_lotes); }
   
    
    }
}
