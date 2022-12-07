
namespace Presentacion
{
    partial class Ver_planillaFRM
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
            this.grilla_planilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_planilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_planilla
            // 
            this.grilla_planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_planilla.Location = new System.Drawing.Point(125, 48);
            this.grilla_planilla.Name = "grilla_planilla";
            this.grilla_planilla.Size = new System.Drawing.Size(522, 306);
            this.grilla_planilla.TabIndex = 0;
            // 
            // Ver_planillaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grilla_planilla);
            this.Name = "Ver_planillaFRM";
            this.Text = "Ver_planillaFRM";
            ((System.ComponentModel.ISupportInitialize)(this.grilla_planilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_planilla;
    }
}