﻿
namespace Presentacion
{
    partial class Nuevo_pedidoFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.combocliente = new System.Windows.Forms.ComboBox();
            this.npedidobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar cliente";
            // 
            // combocliente
            // 
            this.combocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocliente.FormattingEnabled = true;
            this.combocliente.Location = new System.Drawing.Point(41, 89);
            this.combocliente.Name = "combocliente";
            this.combocliente.Size = new System.Drawing.Size(373, 21);
            this.combocliente.TabIndex = 1;
            // 
            // npedidobtn
            // 
            this.npedidobtn.Location = new System.Drawing.Point(175, 136);
            this.npedidobtn.Name = "npedidobtn";
            this.npedidobtn.Size = new System.Drawing.Size(94, 48);
            this.npedidobtn.TabIndex = 2;
            this.npedidobtn.Text = "Crear pedido";
            this.npedidobtn.UseVisualStyleBackColor = true;
            this.npedidobtn.Click += new System.EventHandler(this.npedidobtn_Click);
            // 
            // NuevopedidoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 253);
            this.Controls.Add(this.npedidobtn);
            this.Controls.Add(this.combocliente);
            this.Controls.Add(this.label1);
            this.Name = "NuevopedidoFRM";
            this.Text = "nuevopedidoFRM";
            this.Load += new System.EventHandler(this.nuevopedidoFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combocliente;
        private System.Windows.Forms.Button npedidobtn;
    }
}