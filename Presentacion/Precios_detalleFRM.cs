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

namespace Presentacion
{
    public partial class Precios_detalleFRM : Form
    {
        public Precios_detalleFRM()       /// lista nueva
        {
            InitializeComponent();
            this.Text = "Nueva lista de precios";
            modprecios.Hide();
        }
        PreciosBLL pBLL = new PreciosBLL();
        public Precios_detalleFRM(Lista_precios L)     /// modificar o consultar
        {
            InitializeComponent();
            hamctxt.Text = Convert.ToString(L.PHC.Leer_precio());
            hammtxt.Text = Convert.ToString(L.PHM.Leer_precio());
            lactctxt.Text = Convert.ToString(L.PLC.Leer_precio());
            lactgtxt.Text = Convert.ToString(L.PLG.Leer_precio());
            pancctxt.Text = Convert.ToString(L.PPC.Leer_precio());
            pancmtxt.Text = Convert.ToString(L.PPM.Leer_precio());
            hamctxt.ReadOnly = true;
            hammtxt.ReadOnly = true;
            lactctxt.ReadOnly = true;
            lactgtxt.ReadOnly = true;
            pancctxt.ReadOnly = true;
            pancmtxt.ReadOnly = true;
            fechatxt.Text = Convert.ToString(L.Fecha_de_ultima_actualizacion);
        }

        public void actualizar_lista() { }

        private void PreciosFRM_Load(object sender, EventArgs e)
        {

        }

        private void modprecios_Click(object sender, EventArgs e)
        {
            hamctxt.ReadOnly = false;
            hammtxt.ReadOnly = false;
            lactctxt.ReadOnly = false;
            lactgtxt.ReadOnly = false;
            pancctxt.ReadOnly = false;
            pancmtxt.ReadOnly = false;
            modprecios.Enabled = false;
        }

        public void modificar_lista(bool mod)
        {
            Lista_precios Li = new Lista_precios();
            Li.PHC = new Pan_hamburguesa_comun();
            Li.PHC.Grabar_precio(Convert.ToDouble(hamctxt.Text));
            Li.PHM = new Pan_hamburguesa_maxi();
            Li.PHM.Grabar_precio(Convert.ToDouble(hammtxt.Text));
            Li.PLC = new Pan_lactal_chico();
            Li.PLC.Grabar_precio(Convert.ToDouble(lactctxt.Text));
            Li.PLG = new Pan_lactal_grande();
            Li.PLG.Grabar_precio(Convert.ToDouble(lactgtxt.Text));
            Li.PPC = new Pan_pancho_chico();
            Li.PPC.Grabar_precio(Convert.ToDouble(pancctxt.Text));
            Li.PPM = new Pan_pancho_maxi();
            Li.PPM.Grabar_precio(Convert.ToDouble(pancmtxt.Text));
            pBLL.Modificar_lista_pre(Li, mod);
        }


        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                modificar_lista(false);
                MessageBox.Show("Lista de precios modificada correctamente");
            
            
            }
            catch { }
        }

        private void guardarcambiosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                modificar_lista(true);
                MessageBox.Show("Lista nueva de precios guardada correctamente");
            
            }
            catch { }
        }
    }
}
