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

        public void Actualizar_listas()
        {
            Lista_permisos = Cmp.Cargar_permisos();
            // Lista_roles = Rmp.Bajar_roles();
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

        private void agregarrolbtn_Click(object sender, EventArgs e)  ///Nuevo rol
        {

            foreach (Componente c in Lista_roles)
            {
                if (c.ID == id_roltxt.Text)
                {
                    MessageBox.Show("Error, ya existe un rol con ese ID");
                }
                else
                {
                    if (c.Descripcion == desctxt.Text)
                    {
                        MessageBox.Show("Error, ya existe un rol con esa descripcion");
                    }
                    else
                    {
                        Componente R = new Rol(desctxt.Text);


                        R.ID = id_roltxt.Text;
                        id_roltxt.Clear();
                        desctxt.Clear();

                        TreeNode TN = new TreeNode(R.Descripcion);
                        arbol_permisos.Nodes.Add(TN);
                        Rmp.Nuevo_rol(R);
                        Actualizar_listas();
                    }

                }
            }


        }

        public void actualizar_arbol()
        {
            foreach (Componente c in Lista_roles)
            {
                TreeNode TN = new TreeNode(c.Descripcion);
                arbol_permisos.Nodes.Add(TN);
                foreach (Componente co in c.obtener_lista())
                { TN.Nodes.Add(co.Descripcion); }
            }


        }




        private void button2_Click(object sender, EventArgs e)  /// AGREGAR PERMISO AL ROL
        {





            //TreeNode TN = new TreeNode(((Componente)(combo_permisos.SelectedItem)).Descripcion);
            //arbol_permisos.SelectedNode.Nodes.Add(TN);
            //Componente c = (Componente)combo_permisos.SelectedItem;    //permiso

            //foreach (Componente co in Lista_roles)
            //{

            //    if (co.Descripcion == arbol_permisos.SelectedNode.Text)
            //    {
            //        co.Agregar(c);
            //        Cmp.guardar_permisos_del_rol((Rol)co);


            //        break;
            //    }

            //}

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
