
namespace Presentacion
{
    partial class Cambiar_contrasenaFRM
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
            this.cambiarbtn = new System.Windows.Forms.Button();
            this.nuevatxt = new System.Windows.Forms.TextBox();
            this.actualtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cambiarbtn
            // 
            this.cambiarbtn.Location = new System.Drawing.Point(115, 162);
            this.cambiarbtn.Name = "cambiarbtn";
            this.cambiarbtn.Size = new System.Drawing.Size(132, 23);
            this.cambiarbtn.TabIndex = 0;
            this.cambiarbtn.Text = "Cambiar contraseña";
            this.cambiarbtn.UseVisualStyleBackColor = true;
            this.cambiarbtn.Click += new System.EventHandler(this.cambiarbtn_Click);
            // 
            // nuevatxt
            // 
            this.nuevatxt.Location = new System.Drawing.Point(169, 91);
            this.nuevatxt.Name = "nuevatxt";
            this.nuevatxt.Size = new System.Drawing.Size(155, 20);
            this.nuevatxt.TabIndex = 1;
            // 
            // actualtxt
            // 
            this.actualtxt.Location = new System.Drawing.Point(169, 26);
            this.actualtxt.Name = "actualtxt";
            this.actualtxt.Size = new System.Drawing.Size(155, 20);
            this.actualtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva contraseña";
            // 
            // Cambiar_contrasenaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actualtxt);
            this.Controls.Add(this.nuevatxt);
            this.Controls.Add(this.cambiarbtn);
            this.Name = "Cambiar_contrasenaFRM";
            this.Text = "Cambiar contraseña de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambiarbtn;
        private System.Windows.Forms.TextBox nuevatxt;
        private System.Windows.Forms.TextBox actualtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}