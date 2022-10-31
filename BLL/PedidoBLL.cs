using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
//using Mapper;
using Mapper_DAL;

namespace BLL
{
    public class PedidoBLL
    {
        PedidoMP PeM = new PedidoMP();
        public void grabar_pedido(Pedido Pe) {
           PeM.grabar_pedido(Pe);
                }
        
        public List<Pedido> lista_pedidos_cliente (Cliente C) {

            return PeM.Listar_pedidos_por_cliente(C);
        
        }
        public void modificar_pedido(Pedido Pe) { PeM.Modificar_pedido(Pe); }

    }
}
