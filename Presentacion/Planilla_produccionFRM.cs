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

namespace Presentacion
{
    public partial class Planilla_produccionFRM : Form
    {
        public Planilla_produccionFRM()
        {
            InitializeComponent();
        }
        public DataSet a = new DataSet();
        private void Reporte_stock_Load(object sender, EventArgs e)
        {


            DataSet ds = new DataSet();

           
            DataTable dt = new DataTable();
            
            //dt.Columns.Add("Desc");
            //dt.Columns.Add("ID_producto");
            //dt.Columns.Add("Nro_lote");
            //dt.Columns.Add("Precio");


            //dt.Rows.Add("hola","s",100,1000);
            //dt.Rows.Add("hola", "s", 100,1200);
            //dt.Rows.Add("hola", "s", 100,1300);

            ds.Tables.Add(dt);
            Pan_lactal_grandeBindingSource.DataSource = ds.Tables[0];

            this.reportViewer1.RefreshReport();











            //     Pan_lactal_grandeBindingSource.DataSource = ds;
            //   this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
