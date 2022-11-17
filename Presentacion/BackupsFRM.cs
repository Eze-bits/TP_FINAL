using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Presentacion
{
    public partial class BackupsFRM : Form
    {
        int ID_usuario;
        public BackupsFRM(int ID)
        {
            InitializeComponent();
            ID_usuario = ID;
        }

        private void crear_backupbtn_Click(object sender, EventArgs e)
        {
            Backup Bak = new Backup();
            string path;
            SaveFileDialog Crear_bak_dialog = new SaveFileDialog();
            Crear_bak_dialog.InitialDirectory = "c:\\";
            Crear_bak_dialog.Title = "Crear Backup";
            Crear_bak_dialog.CheckFileExists = false;
            Crear_bak_dialog.CheckPathExists = true;
            Crear_bak_dialog.DefaultExt = "xml";
            Crear_bak_dialog.Filter = "Archivos xml (*.xml)|*.xml";
            Crear_bak_dialog.ShowDialog();
            path = Crear_bak_dialog.FileName;
            Bak.Crear_backup(path);
            Bitacora Bt = new Bitacora(ID_usuario,"Creacion_de_backup");

        }
    }
}
