﻿
namespace Presentacion
{
    partial class LoteNuevoFrm
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
            this.generalotebtn = new System.Windows.Forms.Button();
            this.hammtxt = new System.Windows.Forms.TextBox();
            this.lactgtxt = new System.Windows.Forms.TextBox();
            this.pancctxt = new System.Windows.Forms.TextBox();
            this.pancmtxt = new System.Windows.Forms.TextBox();
            this.hamctxt = new System.Windows.Forms.TextBox();
            this.lactctxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generalotebtn
            // 
            this.generalotebtn.Location = new System.Drawing.Point(432, 66);
            this.generalotebtn.Name = "generalotebtn";
            this.generalotebtn.Size = new System.Drawing.Size(147, 37);
            this.generalotebtn.TabIndex = 1;
            this.generalotebtn.Text = "Generar lote";
            this.generalotebtn.UseVisualStyleBackColor = true;
            this.generalotebtn.Click += new System.EventHandler(this.generalotebtn_Click);
            // 
            // hammtxt
            // 
            this.hammtxt.Location = new System.Drawing.Point(103, 113);
            this.hammtxt.Name = "hammtxt";
            this.hammtxt.Size = new System.Drawing.Size(100, 20);
            this.hammtxt.TabIndex = 2;
            // 
            // lactgtxt
            // 
            this.lactgtxt.Location = new System.Drawing.Point(103, 191);
            this.lactgtxt.Name = "lactgtxt";
            this.lactgtxt.Size = new System.Drawing.Size(100, 20);
            this.lactgtxt.TabIndex = 3;
            // 
            // pancctxt
            // 
            this.pancctxt.Location = new System.Drawing.Point(103, 229);
            this.pancctxt.Name = "pancctxt";
            this.pancctxt.Size = new System.Drawing.Size(100, 20);
            this.pancctxt.TabIndex = 4;
            // 
            // pancmtxt
            // 
            this.pancmtxt.Location = new System.Drawing.Point(103, 267);
            this.pancmtxt.Name = "pancmtxt";
            this.pancmtxt.Size = new System.Drawing.Size(100, 20);
            this.pancmtxt.TabIndex = 5;
            // 
            // hamctxt
            // 
            this.hamctxt.Location = new System.Drawing.Point(103, 75);
            this.hamctxt.Name = "hamctxt";
            this.hamctxt.Size = new System.Drawing.Size(100, 20);
            this.hamctxt.TabIndex = 6;
            // 
            // lactctxt
            // 
            this.lactctxt.Location = new System.Drawing.Point(103, 156);
            this.lactctxt.Name = "lactctxt";
            this.lactctxt.Size = new System.Drawing.Size(100, 20);
            this.lactctxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hamburguesa 200 gramos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hamburguesa 320 gramos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lactal 300 gramos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Panchos 350 gramos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Panchos 230 gramos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lactal 600 gramos";
            // 
            // LoteNuevoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lactctxt);
            this.Controls.Add(this.hamctxt);
            this.Controls.Add(this.pancmtxt);
            this.Controls.Add(this.pancctxt);
            this.Controls.Add(this.lactgtxt);
            this.Controls.Add(this.hammtxt);
            this.Controls.Add(this.generalotebtn);
            this.Name = "LoteNuevoFrm";
            this.Text = "Lote";
            this.Load += new System.EventHandler(this.LoteNuevoFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generalotebtn;
        private System.Windows.Forms.TextBox hammtxt;
        private System.Windows.Forms.TextBox lactgtxt;
        private System.Windows.Forms.TextBox pancctxt;
        private System.Windows.Forms.TextBox pancmtxt;
        private System.Windows.Forms.TextBox hamctxt;
        private System.Windows.Forms.TextBox lactctxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}