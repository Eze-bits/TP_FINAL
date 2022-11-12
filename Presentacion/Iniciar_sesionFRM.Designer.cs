
namespace Presentacion
{
    partial class Iniciar_sesionFRM
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
            this.passtxt = new System.Windows.Forms.TextBox();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(199, 96);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 0;
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Location = new System.Drawing.Point(31, 96);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(121, 21);
            this.combo_usuarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al sistema IADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(56, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija  el usuario y cargue la contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Iniciar_sesionFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_usuarios);
            this.Controls.Add(this.passtxt);
            this.Name = "Iniciar_sesionFRM";
            this.Text = "Iniciar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}