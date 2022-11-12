using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using Entidades;
using BLL;

namespace Presentacion
{
    public partial class Primer_ingresoFRM : Form
    {
        public Primer_ingresoFRM()
        {
            InitializeComponent();
        }
        UsuarioBLL usuBLL = new UsuarioBLL();

        private void ingresarbtn_Click(object sender, EventArgs e)
        {
    //        Usuario usu = new Usuario("Administrador", passtxt.Text);
    //        usuBLL.Primer_ingreso(usu);
            this.Close();
        }
    }
}
