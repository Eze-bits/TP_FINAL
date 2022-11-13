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
using Servicios;

namespace Presentacion
{
    public partial class UsuariosFRM : Form
    {
        public UsuariosFRM()
        {
            InitializeComponent();
        }

        List<Usuario> Lista_usuarios = new List<Usuario>();
        public UsuarioMP UsuB = new UsuarioMP();

        private void altabtn_Click(object sender, EventArgs e)
        {
            Usuario_detalleFRM U = new Usuario_detalleFRM();
            U.ShowDialog();
            Cargar_grilla();
        }
        
        public void Cargar_grilla()
        {
            Lista_usuarios = UsuB.Mostrar_usuarios();
            grilla_usuarios.DataSource = null;
            grilla_usuarios.DataSource = Lista_usuarios;
        }

        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            Cargar_grilla();
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            Usuario usu = ((Usuario)grilla_usuarios.SelectedRows[0].DataBoundItem);
            Usuario_detalleFRM U = new Usuario_detalleFRM(usu);
            U.ShowDialog();
            Cargar_grilla();
        }
    }
}
