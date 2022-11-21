using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class Reporte_diarioFRM : Form
    {
        public Reporte_diarioFRM()
        {
            InitializeComponent();
        }


        public void graficar()
        {
            int[] vdd = new int[6];
            int[] vda = new int[6];
            string[] etiquetas = new string[6];
            etiquetas[0] = "Pan Hamburguesa chico";
            etiquetas[1] = "Pan Hamburguesa grande";
            etiquetas[2] = "Pan Lactal chico";
            etiquetas[3] = "Pan Lactal grande";
            etiquetas[4] = "Pan pancho comun";
            etiquetas[5] = "Pan pancho maxi";

        }
    }
}