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
using BE;
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
        RolMP rMP = new RolMP();
        Crypto Cp = new Crypto();
        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario(nombretxt.Text, Cp.Encriptar(passtxt.Text));
                usu.ID_usuario = 100;
                usuMP.Agregar_usuario(usu,true);
                Cmp.Crear_tabla_permisos();
                Rol R = new Rol("Administrador");
                R.ID = "admin";
                usu.Agregar_roles(R);
                rMP.Nuevo_rol(R);
                rMP.Grabar_permisos_admin();

                this.Hide();
                Menu_principal M = new Menu_principal(usu);
                M.Show();
            }
            catch { }
        }
    }
}
