using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Presentacion
{
    public partial class ModificarpedidoFRM : Form
    {
        public ModificarpedidoFRM()
        {
            InitializeComponent();
        }

        public List<Cliente> Lista_clientes = new List<Cliente>();
        public List<Pedido> Lista_pedidos = new List<Pedido>();
        
        
        ClienteBLL CliB = new ClienteBLL();
        PedidoBLL PeB = new PedidoBLL();

        private void ModificarpedidoFRM_Load(object sender, EventArgs e)
        {
            cargar_clientes();
            grillaclientes_CellClick(null, null);
            grilla_pedidos_CellClick(null, null);
        }
        public void cargar_detalle_pedido(Pedido Pe) {
            grilla_pedidos_detalle.DataSource = null;
            grilla_pedidos_detalle.DataSource = Pe.retorna_lista_panificados();

        }

        public void cargar_clientes()
        {
            Lista_clientes = CliB.Lista_clientesBLL();
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = Lista_clientes;
        }
        public void cargar_pedidos(Cliente C)
        {
            Lista_pedidos = PeB.lista_pedidos_cliente(C);
            grilla_pedidos.DataSource = null;
            grilla_pedidos.DataSource=Lista_pedidos;
        }
      


        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente C = (Cliente)grillaclientes.CurrentRow.DataBoundItem;
            cargar_pedidos(C);
        }

        private void grilla_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido Pe = (Pedido)grilla_pedidos.CurrentRow.DataBoundItem;
            cargar_detalle_pedido(Pe);
        }
    }
}
