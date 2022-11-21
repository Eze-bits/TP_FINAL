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
    public   List<Permiso> Lista_permisos = new List<Permiso>();



        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            Lista_permisos=Cmp.Cargar_permisos();
            combo_permisos.DataSource = Cmp.Cargar_permisos();
            combo_permisos.DisplayMember = "Descripcion";


        }

        private void agregarrolbtn_Click(object sender, EventArgs e)
        {
        Componente R = new Rol(desctxt.Text);
            R.ID = id_roltxt.Text;
            id_roltxt.Clear();
            desctxt.Clear();
            Cmp.Guardar_rol(R);
            arbol_permisos.Nodes.Add(R.Descripcion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            arbol_permisos.SelectedNode.Nodes.Add(Lista_permisos[combo_permisos.SelectedIndex].Descripcion);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
