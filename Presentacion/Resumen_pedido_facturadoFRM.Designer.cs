
namespace Presentacion
{
    partial class Resumen_pedido_facturadoFRM
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
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.grilla_fac = new System.Windows.Forms.DataGridView();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fac)).BeginInit();
            this.SuspendLayout();
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(508, 43);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(100, 20);
            this.fechatxt.TabIndex = 0;
            this.fechatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grilla_fac
            // 
            this.grilla_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_fac.Location = new System.Drawing.Point(87, 52);
            this.grilla_fac.Name = "grilla_fac";
            this.grilla_fac.Size = new System.Drawing.Size(390, 268);
            this.grilla_fac.TabIndex = 1;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(504, 357);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 2;
            this.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.Location = new System.Drawing.Point(199, 372);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(163, 33);
            this.cerrarbtn.TabIndex = 4;
            this.cerrarbtn.Text = "CERRAR";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL";
            // 
            // Resumen_pedido_facturadoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cerrarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.grilla_fac);
            this.Controls.Add(this.fechatxt);
            this.Name = "Resumen_pedido_facturadoFRM";
            this.Text = "Pedido facturado";
            this.Load += new System.EventHandler(this.Resumen_pedido_facturadoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.DataGridView grilla_fac;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label label2;
    }
}