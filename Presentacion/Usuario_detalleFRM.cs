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

namespace Presentacion
{
    public partial class Usuario_detalleFRM : Form
    {
        public Usuario_detalleFRM()         ///Alta
        {
            InitializeComponent();
            modificarbtn.Visible = false;
        }
        public Usuario_detalleFRM(Usuario usu)    ///Modificacion
        {
            InitializeComponent();
            altabtn.Visible = false;
            nombretxt.Text = usu.Nombre;
            idtxt.Text = usu.ID;
            idtxt.ReadOnly = true;
        }

        private void altabtn_Click(object sender, EventArgs e)
        {

        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
