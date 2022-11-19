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
        }



        private void PreciosFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
