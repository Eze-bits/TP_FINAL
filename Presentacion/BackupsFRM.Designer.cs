
namespace Presentacion
{
    partial class BackupsFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grilla_bitacora = new System.Windows.Forms.DataGridView();
            this.restaurarbtn = new System.Windows.Forms.Button();
            this.crear_backupbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_bitacora
            // 
            this.grilla_bitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grilla_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_bitacora.Location = new System.Drawing.Point(47, 48);
            this.grilla_bitacora.MultiSelect = false;
            this.grilla_bitacora.Name = "grilla_bitacora";
            this.grilla_bitacora.ReadOnly = true;
            this.grilla_bitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_bitacora.Size = new System.Drawing.Size(556, 198);
            this.grilla_bitacora.TabIndex = 0;
            this.grilla_bitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_bitacora_CellClick);
            // 
            // restaurarbtn
            // 
            this.restaurarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.restaurarbtn.Location = new System.Drawing.Point(637, 170);
            this.restaurarbtn.Name = "restaurarbtn";
            this.restaurarbtn.Size = new System.Drawing.Size(169, 23);
            this.restaurarbtn.TabIndex = 1;
            this.restaurarbtn.Text = "Restaurar base de datos";
            this.restaurarbtn.UseVisualStyleBackColor = true;
            this.restaurarbtn.Click += new System.EventHandler(this.restaurarbtn_Click);
            // 
            // crear_backupbtn
            // 
            this.crear_backupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.crear_backupbtn.Location = new System.Drawing.Point(637, 83);
            this.crear_backupbtn.Name = "crear_backupbtn";
            this.crear_backupbtn.Size = new System.Drawing.Size(169, 23);
            this.crear_backupbtn.TabIndex = 2;
            this.crear_backupbtn.Text = "Generar backup";
            this.crear_backupbtn.UseVisualStyleBackColor = true;
            this.crear_backupbtn.Click += new System.EventHandler(this.crear_backupbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bitacora";
            // 
            // BackupsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crear_backupbtn);
            this.Controls.Add(this.restaurarbtn);
            this.Controls.Add(this.grilla_bitacora);
            this.Name = "BackupsFRM";
            this.Text = "Gestion de backups";
            this.Load += new System.EventHandler(this.BackupsFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_bitacora;
        private System.Windows.Forms.Button restaurarbtn;
        private System.Windows.Forms.Button crear_backupbtn;
        private System.Windows.Forms.Label label1;
    }
}