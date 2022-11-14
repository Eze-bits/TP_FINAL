
namespace Presentacion
{
    partial class AutenticacionFRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.ingresobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(209, 111);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 2;
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Location = new System.Drawing.Point(48, 110);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(121, 21);
            this.combo_usuarios.TabIndex = 3;
            // 
            // ingresobtn
            // 
            this.ingresobtn.Location = new System.Drawing.Point(125, 167);
            this.ingresobtn.Name = "ingresobtn";
            this.ingresobtn.Size = new System.Drawing.Size(105, 23);
            this.ingresobtn.TabIndex = 4;
            this.ingresobtn.Text = "Ingresar";
            this.ingresobtn.UseVisualStyleBackColor = true;
            this.ingresobtn.Click += new System.EventHandler(this.ingresobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(45, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elija usuario y escriba la contraseña para ingresar";
            // 
            // Autenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingresobtn);
            this.Controls.Add(this.combo_usuarios);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autenticacion";
            this.Text = "Autenticacion";
            this.Load += new System.EventHandler(this.Autenticacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Button ingresobtn;
        private System.Windows.Forms.Label label3;
    }
}