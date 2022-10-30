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
          
        }

        public void cargar_clientes()
        {
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = CliB.Lista_clientesBLL();

        }
      




    }
}
