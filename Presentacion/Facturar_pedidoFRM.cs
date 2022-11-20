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
    public partial class Facturar_pedidoFRM : Form
    {
        public Facturar_pedidoFRM()
        {
            InitializeComponent();
        }
        public List<Cliente> Lista_clientes = new List<Cliente>();
        public List<Pedido> Lista_pedidos = new List<Pedido>();
        ClienteBLL CliB = new ClienteBLL();
        PedidoBLL PeB = new PedidoBLL();
        LotesBLL LoB = new LotesBLL();
        
        public void cargar_clientes()
        {
            Lista_clientes = CliB.Lista_clientesBLL();
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = Lista_clientes;
        }

        public void cargar_pedidos(Cliente C)
        {
            try
            {
                Lista_pedidos = PeB.lista_pedidos_cliente(C);
                grilla_pedidos.DataSource = null;
                grilla_pedidos.DataSource = Lista_pedidos;
               
            }
            catch { }
        }

        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                Cliente C = (Cliente)grillaclientes.CurrentRow.DataBoundItem;
                cargar_pedidos(C);

            }

            catch { }
        }

        private void Facturar_pedidoFRM_Load(object sender, EventArgs e)
        {
            cargar_clientes();
            grillaclientes_CellClick(null, null);
        }
    }
}
