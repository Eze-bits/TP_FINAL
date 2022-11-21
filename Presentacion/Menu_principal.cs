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
using Servicios;
using Entidades;

namespace Presentacion
{
    public partial class Menu_principal : Form
    {
        public int ID_sesion;
        public Menu_principal(Usuario U)
        {
            InitializeComponent();
            ID_sesion = U.ID_usuario;
        }
        PreciosBLL pBLL = new PreciosBLL();
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.MdiParent = this;
            C.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void Lotes_Click(object sender, EventArgs e)
        {





        }

        private void crearLoteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LotesBLL Nl = new LotesBLL();
            Lote L = new Lote();

            if (Nl.checkear_lote(L) == true)
            { MessageBox.Show("Ya existe un lote del dia creado"); }

            else
            {
                LoteNuevoFrm C = new LoteNuevoFrm();
                C.MdiParent = this;
                C.Show();
            }





        }

        private void verYModificarStock_Click(object sender, EventArgs e)
        {
            LotesBLL Nl = new LotesBLL();

            if (Nl.Lotes_cargados() == true)
            {
                Lote_detalleFRM L = new Lote_detalleFRM();
                L.MdiParent = this;
                L.Show();
            }

            else
            {
                MessageBox.Show("No existen lotes cargados en la base de datos.\nAgregue nuevos lotes seleccionando " +
                  '"' + "Crear nuevo Lote" + '"');
            }



        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pBLL.Checkear_existencia_pr() == true)
            {
                Nuevo_pedidoFRM N = new Nuevo_pedidoFRM();
                N.MdiParent = this;
                N.Show();
            }
            else
            {
                MessageBox.Show("Error: Para poder crear pedidos nuevos debe cargar una lista de precios");

            }



        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void modificarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_pedidoFRM M = new Listar_pedidoFRM();
            M.MdiParent = this;
            M.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.MdiParent = this;
            C.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_pedidoFRM N = new Modificar_pedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        private void anularYConfirmarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmar_anular_pedidoFRM N = new Confirmar_anular_pedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primer_ingresoFRM P = new Primer_ingresoFRM();
            P.MdiParent = this;
            P.Show();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosFRM U = new PermisosFRM();
            U.MdiParent = this;
            U.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFRM U = new UsuariosFRM();
            U.MdiParent = this;
            U.Show();
        }

        private void modificarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosFRM U = new PermisosFRM();
            U.MdiParent = this;
            U.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AutenticacionFRM F = new AutenticacionFRM();
            F.Show();
        }

        private void gestionDeBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BackupsFRM B = new BackupsFRM(ID_sesion);
            B.MdiParent = this;
            B.Show();
        }

        private void editarPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pBLL.Checkear_existencia_pr() == true) {
                
                Precios_detalleFRM F = new Precios_detalleFRM();
                F.MdiParent = this;
                F.Show();



            }

            else
            {
                var resultado = MessageBox.Show("No existe una lista de precios en la base de datos, desea crear una nueva ?", "Lista de precios",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Precios_detalleFRM F = new Precios_detalleFRM(true);
                    F.MdiParent = this;
                    F.Show();
                }

            }
        }

        private void facturarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar_pedidoFRM F = new Facturar_pedidoFRM();
            F.MdiParent = this;
            F.Show();
        }

        private void reporteDeVentasSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_diarioFRM R = new Reporte_diarioFRM();
            R.MdiParent = this;
            R.Show();
        }
    }
}
