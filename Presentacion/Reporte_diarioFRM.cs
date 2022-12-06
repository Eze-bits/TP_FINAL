﻿using System;
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

        //public void graficar(DateTime fecha)
        //{

        //    decimal[] vdd = new decimal[6];
        //    vBLL.Graficar_x_dia(fecha).CopyTo(vdd, 0);

        //    string[] etiquetas = new string[6];
        //    etiquetas[0] = "Pan Hamburguesa chico";
        //    etiquetas[1] = "Pan Hamburguesa grande";
        //    etiquetas[2] = "Pan Lactal chico";
        //    etiquetas[3] = "Pan Lactal grande";
        //    etiquetas[4] = "Pan pancho chico";
        //    etiquetas[5] = "Pan pancho maxi";


        //    chart1.Series[0].Points.DataBindXY(etiquetas, vdd);
        //    chart1.Series[0].ChartType = SeriesChartType.Bar;
        //    chart1.Series[0].IsVisibleInLegend = false;
        //    chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

            
            
            





        //}

        private void fechapic_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Reporte_diarioFRM_Load(object sender, EventArgs e)
        {
            
            graficarbtn_Click(null, null);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void graficarbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(pickerinicio.Value.Date) <= DateTime.Now.Date & Convert.ToDateTime(pickerfin.Value.Date) <= DateTime.Now.Date)
            {
                decimal[] vdd = new decimal[6];
               vBLL.Graficar_x_intervalo(pickerinicio.Value.Date,pickerfin.Value.Date,false).CopyTo(vdd, 0);

                string[] etiquetas = new string[6];
                etiquetas[0] = "Pan Hamburguesa chico";
                etiquetas[1] = "Pan Hamburguesa grande";
                etiquetas[2] = "Pan Lactal chico";
                etiquetas[3] = "Pan Lactal grande";
                etiquetas[4] = "Pan pancho chico";
                etiquetas[5] = "Pan pancho maxi";

                chart2.Series[0].Points.DataBindXY(etiquetas, vdd);
                chart2.Series[0].ChartType = SeriesChartType.Bar;
                chart2.Series[0].IsVisibleInLegend = false;
                chart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                vBLL.Graficar_x_intervalo(pickerinicio.Value.Date, pickerfin.Value.Date, true).CopyTo(vdd, 0);
               
                chart3.Series[0].Points.DataBindXY(etiquetas, vdd);
                chart3.Series[0].ChartType = SeriesChartType.Pie;

                chart3.ChartAreas[0].Area3DStyle.Enable3D = false;
                chart3.Series[0].IsVisibleInLegend = true;
                chart3.Series[0].Color = Color.Red;
                chart3.Series[0].BorderWidth = 5;

            }
            else
            {
                MessageBox.Show("Error, selecciono un intervalo de tiempo incorrecto");


            }



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}