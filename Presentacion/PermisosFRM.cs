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
        RolMP Rmp = new RolMP();
        public List<Componente> Lista_permisos = new List<Componente>();
        public List<Usuario> Lista_usuarios = new List<Usuario>();
        public List<Componente> Lista_roles;
        
        public void Actualizar_listas() {
            Lista_permisos = Cmp.Cargar_permisos();
            Lista_roles = Rmp.Bajar_roles();
            foreach (Componente c in Lista_roles)
            {
                arbol_permisos.Nodes.Add(c.Descripcion);

            }
        }
        
        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            
            combo_permisos.DataSource = Cmp.Cargar_permisos();
            combo_permisos.DisplayMember = "Descripcion";
            Actualizar_listas();
           

        }

        private void agregarrolbtn_Click(object sender, EventArgs e)
        {
            Componente R = new Rol(desctxt.Text);
            R.ID = id_roltxt.Text;
            id_roltxt.Clear();
            desctxt.Clear();
            Cmp.Guardar_rol(R);
            TreeNode TN = new TreeNode(R.Descripcion);
            arbol_permisos.Nodes.Add(TN);
        }

        private void button2_Click(object sender, EventArgs e)  /// AGREGAR PERMISO AL ROL
        {
            TreeNode TN = new TreeNode(((Componente)(combo_permisos.SelectedItem)).Descripcion);
                arbol_permisos.SelectedNode.Nodes.Add(TN);
            Componente c = (Componente)combo_permisos.SelectedItem;
                      
            foreach(Componente co in Lista_roles) {

                if (co.Descripcion == arbol_permisos.SelectedNode.Text)
                { co.Agregar(c); break; }
            
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
