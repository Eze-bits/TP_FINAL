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

        public void actualizar_arbol()
        {
            foreach (Componente c in Lista_roles)
            {
                arbol_permisos.Nodes.Add(c.Descripcion);
            }
        
        
        }



        public void Actualizar_listas()
        {
            Lista_permisos = Cmp.Cargar_permisos();
            Lista_roles = Rmp.Bajar_roles();
            arbol_permisos.Nodes.Clear();
            actualizar_arbol();
        }

        


        private void UsuariosFRM_Load(object sender, EventArgs e)
        {

            combo_permisos.DataSource = Cmp.Cargar_permisos();
            combo_permisos.DisplayMember = "Descripcion";
            Actualizar_listas();


        }

        public void nuevo_rol()
        {
            Componente R = new Rol(desctxt.Text);
            R.ID = id_roltxt.Text;
            id_roltxt.Clear();
            desctxt.Clear();
            Rmp.Nuevo_rol(R,false);
            Actualizar_listas();
        }



        private void agregarrolbtn_Click(object sender, EventArgs e)  ///Nuevo rol
        {
            bool check = false;
            if (Lista_roles.Count() == 0)
            {
                nuevo_rol();
            }

            else
            {
                foreach (Componente c in Lista_roles)
                {
                    if (c.ID == id_roltxt.Text)
                    {
                        MessageBox.Show("Error, ya existe un rol con ese ID");
                        check = true;
                        break;
                    }

                    if (c.Descripcion == desctxt.Text)
                    {
                        MessageBox.Show("Error, ya existe un rol con esa descripcion");
                        check = true;
                        break;
                    }
                }
                if (check == false) { nuevo_rol(); }
            }
        }
        //public void actualizar_arbol()
        //{
        //    foreach (Componente c in Lista_roles)
        //    {
        //        TreeNode TN = new TreeNode(c.Descripcion);
        //        arbol_permisos.Nodes.Add(TN);
        //        foreach (Componente co in c.obtener_lista())
        //        { TN.Nodes.Add(co.Descripcion); }
        //    }


        //}




        private void button2_Click(object sender, EventArgs e)  /// AGREGAR PERMISO AL ROL
        {


            TreeNode TN = new TreeNode(((Componente)(combo_permisos.SelectedItem)).Descripcion);
            foreach (TreeNode T in arbol_permisos.SelectedNode.Nodes)
            {
                if (T.Tag == TN.Tag)
                {
                    MessageBox.Show("Error, el rol ya tiene ese permiso asignado");
                    return;
                }

            }

               arbol_permisos.SelectedNode.Nodes.Add(TN);
               Componente c = (Componente)combo_permisos.SelectedItem;    



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void borrar_permisobtn_Click(object sender, EventArgs e)
        {


            /// Componente per;

            foreach (Componente co in Lista_roles)
            {

                if (co.Descripcion == arbol_permisos.SelectedNode.Parent.Text)  /// busco el rol
                {
                    foreach (Componente p in Cmp.Cargar_permisos())
                    {
                        if (p.Descripcion == arbol_permisos.SelectedNode.Text)
                        {



                        }
                    }
                }

            }




            arbol_permisos.SelectedNode.Remove();
        }
    }
}
