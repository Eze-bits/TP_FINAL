
namespace Presentacion
{
    partial class PreciosFRM
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
            this.grilla_precios = new System.Windows.Forms.DataGridView();
            this.modificarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_precios)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_precios
            // 
            this.grilla_precios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_precios.Location = new System.Drawing.Point(65, 70);
            this.grilla_precios.Name = "grilla_precios";
            this.grilla_precios.Size = new System.Drawing.Size(356, 221);
            this.grilla_precios.TabIndex = 0;
            // 
            // modificarbtn
            // 
            this.modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.modificarbtn.Location = new System.Drawing.Point(186, 319);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(114, 23);
            this.modificarbtn.TabIndex = 1;
            this.modificarbtn.Text = "Modificar precios";
            this.modificarbtn.UseVisualStyleBackColor = true;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // PreciosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 404);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.grilla_precios);
            this.Name = "PreciosFRM";
            this.Text = "PreciosFRM";
            ((System.ComponentModel.ISupportInitialize)(this.grilla_precios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_precios;
        private System.Windows.Forms.Button modificarbtn;
    }
}