using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;
using Servicios;

namespace Presentacion
{
    public partial class PermisosFRM : Form
    {
        public PermisosFRM()
        {
            InitializeComponent();
        }
        ComponenteMP Cmp = new ComponenteMP();
        List<Permiso> Lista_permisos = new List<Permiso>();



        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            Lista_permisos = Cmp.Cargar_permisos();
            foreach (Permiso p in Lista_permisos)
            { combo_permisos.Items.Add(p.Descripcion); }


        }

        private void agregarrolbtn_Click(object sender, EventArgs e)
        {
            Rol R = new Rol(desctxt.Text);
            R.ID_rol = id_roltxt.Text;
            id_roltxt.Clear();
            desctxt.Clear();

            arbol_permisos.Nodes.Add(R.Descripcion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////arbol_permisos.Nodes
        }
    }
}
