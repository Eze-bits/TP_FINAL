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
    public partial class Crear_planillaFRM : Form
    {
        public Crear_planillaFRM()
        {
            InitializeComponent();


            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";




        }


        private void genera_pbtn_Click(object sender, EventArgs e)
        {


            try
            {
                Planilla_produccion Pl = new Planilla_produccion();
                PlanillaBLL pBLL = new PlanillaBLL();
                Lote Lo = new Lote();
                Pl.Nro_lote = Lo.Nro_lote;
                if (Convert.ToInt32(hamctxt.Text) >= 0)
                {
                    Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(Convert.ToInt32(hamctxt.Text));
                    Pl.Agregar_a_planilla(Phc);
                }

                if (Convert.ToInt32(hammtxt.Text) >= 0)
                {
                    Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(Convert.ToInt32(hammtxt.Text));
                    Pl.Agregar_a_planilla(Phg);
                }


                if (Convert.ToInt32(lactctxt.Text) >= 0)
                {
                    Pan_lactal_chico Plc = new Pan_lactal_chico(Convert.ToInt32(lactctxt.Text));
                    Pl.Agregar_a_planilla(Plc);
                }

                if (Convert.ToInt32(lactgtxt.Text) >= 0)

                {
                    Pan_lactal_grande Plg = new Pan_lactal_grande(Convert.ToInt32(lactgtxt.Text));
                    Pl.Agregar_a_planilla(Plg);
                }

                if (Convert.ToInt32(pancctxt.Text) >= 0)
                {
                    Pan_pancho_chico Ppc = new Pan_pancho_chico(Convert.ToInt32(pancctxt.Text));
                    Pl.Agregar_a_planilla(Ppc);
                }

                if (Convert.ToInt32(pancmtxt.Text) >= 0)
                {
                    Pan_pancho_maxi Ppm = new Pan_pancho_maxi(Convert.ToInt32(pancmtxt.Text));
                    Pl.Agregar_a_planilla(Ppm);
                }
                pBLL.Guardar_planilla(Pl);

                MessageBox.Show("Planilla creada corectamente");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos, intente nuevamente");

            }



        }

        private void Crear_planillaFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
