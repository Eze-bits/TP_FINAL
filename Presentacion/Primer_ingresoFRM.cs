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

        UsuarioMP usuMP = new UsuarioMP();
        ComponenteMP Cmp = new ComponenteMP();
        Crypto Cp = new Crypto();
        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario(nombretxt.Text, Cp.Encriptar(passtxt.Text));
                usu.ID_usuario = 100;
                usuMP.Agregar_usuario(usu);
                Cmp.Crear_tabla_permisos();


                this.Hide();
                Menu_principal M = new Menu_principal(usu);
                M.Show();
            }
            catch { }
        }
    }
}
