
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurarbtn = new System.Windows.Forms.Button();
            this.crear_backupbtn = new System.Windows.Forms.Button();
            this.stringtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // restaurarbtn
            // 
            this.restaurarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.restaurarbtn.Location = new System.Drawing.Point(471, 135);
            this.restaurarbtn.Name = "restaurarbtn";
            this.restaurarbtn.Size = new System.Drawing.Size(169, 23);
            this.restaurarbtn.TabIndex = 1;
            this.restaurarbtn.Text = "Restaurar base de datos";
            this.restaurarbtn.UseVisualStyleBackColor = true;
            // 
            // crear_backupbtn
            // 
            this.crear_backupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.crear_backupbtn.Location = new System.Drawing.Point(471, 48);
            this.crear_backupbtn.Name = "crear_backupbtn";
            this.crear_backupbtn.Size = new System.Drawing.Size(169, 23);
            this.crear_backupbtn.TabIndex = 2;
            this.crear_backupbtn.Text = "Generar backup";
            this.crear_backupbtn.UseVisualStyleBackColor = true;
            this.crear_backupbtn.Click += new System.EventHandler(this.crear_backupbtn_Click);
            // 
            // stringtxt
            // 
            this.stringtxt.Location = new System.Drawing.Point(444, 284);
            this.stringtxt.Name = "stringtxt";
            this.stringtxt.Size = new System.Drawing.Size(100, 20);
            this.stringtxt.TabIndex = 3;
            // 
            // BackupsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stringtxt);
            this.Controls.Add(this.crear_backupbtn);
            this.Controls.Add(this.restaurarbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BackupsFRM";
            this.Text = "Gestion de backups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button restaurarbtn;
        private System.Windows.Forms.Button crear_backupbtn;
        private System.Windows.Forms.TextBox stringtxt;
    }
}