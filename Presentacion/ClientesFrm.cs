﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using BLL;
using Entidades;


namespace Presentacion
{
    public partial class ClientesFrm : Form
    {
        Cliente C = new Cliente();
        ClienteBLL CliBLL = new ClienteBLL();

        public ClientesFrm()
        {
            InitializeComponent();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            cargar_grilla();
        }

        List<Cliente> Lista_clientes = new List<Cliente>();

        public void cargar_grilla()
        {
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = CliBLL.Lista_clientesBLL();

        }




        private void Bajabtn_Click(object sender, EventArgs e)                     ///BORRAR CLIENTE
        {


            try
            {
                int nrocliente = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente nro: " + nrocliente + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)

                {





                    cargar_grilla();
                    MessageBox.Show("Cliente eliminado exitosamente");
                }

            }

            catch
            { MessageBox.Show("Error: Lista de clientes vacia"); }


        }

        private void grillaclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaclientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void Modificacionbtn_Click(object sender, EventArgs e)     /// MODIFICAR CLIENTE
        {

            try
            {

                Cliente C = ((Cliente)grillaclientes.SelectedRows[0].DataBoundItem);
                Clientes_detalleFrm Cli = new Clientes_detalleFrm(C);
                Cli.ShowDialog();
                cargar_grilla();
            }


            catch { MessageBox.Show("Error: Lista de clientes vacia"); }
        }

        private void ClientesFrm_Enter(object sender, EventArgs e)
        {

        }

        private void Altabtn_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes_detalleFrm Cli = new Clientes_detalleFrm();
                Cli.ShowDialog();
                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }

        }

        private void userControlAlta1_Load(object sender, EventArgs e)
        {

        }

        private void Altabtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clientes_detalleFrm Cli = new Clientes_detalleFrm();
                Cli.ShowDialog();
                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }
        }





        private void Bajabtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                int nrodni = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente DNI: " + nrodni + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    CliBLL.Borrar_cliente(nrodni);
                    MessageBox.Show("Cliente eliminado exitosamente");
                    cargar_grilla();
                }

            }

            catch
            { MessageBox.Show("Error al eliminar cliente"); }
        }





    }
}
