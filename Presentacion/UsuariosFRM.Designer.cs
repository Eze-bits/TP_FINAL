
namespace Presentacion
{
    partial class UsuariosFRM
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
            this.grilla_usuarios = new System.Windows.Forms.DataGridView();
            this.altabtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_usuarios
            // 
            this.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_usuarios.Location = new System.Drawing.Point(152, 103);
            this.grilla_usuarios.Name = "grilla_usuarios";
            this.grilla_usuarios.Size = new System.Drawing.Size(307, 185);
            this.grilla_usuarios.TabIndex = 0;
            // 
            // altabtn
            // 
            this.altabtn.Location = new System.Drawing.Point(534, 115);
            this.altabtn.Name = "altabtn";
            this.altabtn.Size = new System.Drawing.Size(119, 33);
            this.altabtn.TabIndex = 1;
            this.altabtn.Text = "Alta de usuario";
            this.altabtn.UseVisualStyleBackColor = true;
            this.altabtn.Click += new System.EventHandler(this.altabtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar usuario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UsuariosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.altabtn);
            this.Controls.Add(this.grilla_usuarios);
            this.Name = "UsuariosFRM";
            this.Text = "UsuariosFRM";
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_usuarios;
        private System.Windows.Forms.Button altabtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}