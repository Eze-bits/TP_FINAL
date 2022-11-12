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
        UsuarioBLL usubll = new UsuarioBLL();
        Crypto Cp = new Crypto();
        
        
        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            combo_permisos.Items.Add("Modificar clientes");  //100
            combo_permisos.Items.Add("Crear Lote nuevo");    //101
            combo_permisos.Items.Add("Nuevo pedido");        //102
            combo_permisos.Items.Add("Editar pedidos");      //103
            combo_permisos.Items.Add("Anular y confirmar pedidos");  //104
            combo_permisos.Items.Add("Lista de precios");            //105
            combo_permisos.Items.Add("Modificar usuarios");          //106
            combo_permisos.Items.Add("Modificar contraseña de usuario actual");  //107
            combo_permisos.Items.Add("Reporte de ventas semanal");              //108
            combo_permisos.Items.Add("Facturar pedido");                        //109
          



        }

        private void agregarrolbtn_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Nombre = nombre_roltxt.Text;
            Rol R=null;
            if (usubll.Checkear_usuario(usu) == false)
                
            {
                //usu.Pass = Cp.Encriptar(passtxt.Text);
                //R = new Rol(nombre_roltxt.Text );
            }

            else
            { MessageBox.Show("Error, ya existe un usuario con ese nombre"); }

            arbol_permisos.Nodes.Add(R.retorna_nombre());
            
        }
    }
}
