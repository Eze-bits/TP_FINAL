
namespace Presentacion
{
    partial class Usuario_detalleFRM
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
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.altabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(22, 167);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(186, 21);
            this.nombretxt.TabIndex = 0;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(327, 167);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(186, 21);
            this.passtxt.TabIndex = 1;
            // 
            // modificarbtn
            // 
            this.modificarbtn.Location = new System.Drawing.Point(192, 272);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(138, 27);
            this.modificarbtn.TabIndex = 2;
            this.modificarbtn.Text = "Guardar cambios";
            this.modificarbtn.UseVisualStyleBackColor = true;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // altabtn
            // 
            this.altabtn.Location = new System.Drawing.Point(192, 239);
            this.altabtn.Name = "altabtn";
            this.altabtn.Size = new System.Drawing.Size(138, 27);
            this.altabtn.TabIndex = 3;
            this.altabtn.Text = "Guardar usuario";
            this.altabtn.UseVisualStyleBackColor = true;
            this.altabtn.Click += new System.EventHandler(this.altabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(176, 209);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(186, 21);
            this.idtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "* El id de usuario solo puede ser numerico y mayor a cero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "* El nombre de usuario solo puede poseer letras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(191, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuarios del sistema";
            // 
            // Usuario_detalleFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altabtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.nombretxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Usuario_detalleFRM";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button altabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}