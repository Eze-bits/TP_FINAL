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
using Entidades;
using BLL;

namespace Presentacion
{
    public partial class Reporte_diarioFRM : Form
    {
        public Reporte_diarioFRM()
        {
            InitializeComponent();
        }
        VentaBLL vBLL = new VentaBLL();

        public void graficar(DateTime fecha)
        {

            decimal[] vdd = new decimal[6];
            vBLL.Graficar_x_dia(fecha).CopyTo(vdd, 0);

            string[] etiquetas = new string[6];
            etiquetas[0] = "Pan Hamburguesa chico";
            etiquetas[1] = "Pan Hamburguesa grande";
            etiquetas[2] = "Pan Lactal chico";
            etiquetas[3] = "Pan Lactal grande";
            etiquetas[4] = "Pan pancho chico";
            etiquetas[5] = "Pan pancho maxi";


            chart1.Series[0].Points.DataBindXY(etiquetas, vdd);
            chart1.Series[0].ChartType = SeriesChartType.Bar;
           
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            
            //for (var i = 0; i < chart1.Series.Count; i++)
            //    for (var j = 0; j < chart1.Series[i].Points.Count; j++)
            //        chart1.Series[i].Points[j]["PieLabelStyle"] = "Disabled";





        }

        private void fechapic_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = fechapic.Value.Date;
                graficar(fecha);
            }
            catch { }
        }

        private void Reporte_diarioFRM_Load(object sender, EventArgs e)
        {
            fechapic_ValueChanged(null, null);
        }
    }
}