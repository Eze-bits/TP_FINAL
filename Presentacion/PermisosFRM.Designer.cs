
namespace Presentacion
{
    partial class PermisosFRM
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
            this.arbol_permisos = new System.Windows.Forms.TreeView();
            this.agregarrolbtn = new System.Windows.Forms.Button();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.combo_permisos = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_roltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombretxt = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.borrar_permisobtn = new System.Windows.Forms.Button();
            this.combousuarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbol_permisos
            // 
            this.arbol_permisos.Location = new System.Drawing.Point(359, 23);
            this.arbol_permisos.Name = "arbol_permisos";
            this.arbol_permisos.Size = new System.Drawing.Size(563, 152);
            this.arbol_permisos.TabIndex = 0;
            // 
            // agregarrolbtn
            // 
            this.agregarrolbtn.Location = new System.Drawing.Point(84, 81);
            this.agregarrolbtn.Name = "agregarrolbtn";
            this.agregarrolbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarrolbtn.TabIndex = 1;
            this.agregarrolbtn.Text = "Agregar Rol";
            this.agregarrolbtn.UseVisualStyleBackColor = true;
            this.agregarrolbtn.Click += new System.EventHandler(this.agregarrolbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(17, 41);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(100, 20);
            this.desctxt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar permiso al rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combo_permisos
            // 
            this.combo_permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_permisos.FormattingEnabled = true;
            this.combo_permisos.Location = new System.Drawing.Point(169, 32);
            this.combo_permisos.Name = "combo_permisos";
            this.combo_permisos.Size = new System.Drawing.Size(351, 21);
            this.combo_permisos.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar Rol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id_roltxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.desctxt);
            this.groupBox1.Controls.Add(this.agregarrolbtn);
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // id_roltxt
            // 
            this.id_roltxt.Location = new System.Drawing.Point(139, 41);
            this.id_roltxt.Name = "id_roltxt";
            this.id_roltxt.Size = new System.Drawing.Size(100, 20);
            this.id_roltxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nombretxt);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.combo_permisos);
            this.groupBox2.Location = new System.Drawing.Point(27, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 79);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // nombretxt
            // 
            this.nombretxt.AutoSize = true;
            this.nombretxt.Location = new System.Drawing.Point(272, 16);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(98, 13);
            this.nombretxt.TabIndex = 6;
            this.nombretxt.Text = "Nombre de permiso";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(741, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Modificar Rol";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // borrar_permisobtn
            // 
            this.borrar_permisobtn.Location = new System.Drawing.Point(656, 265);
            this.borrar_permisobtn.Name = "borrar_permisobtn";
            this.borrar_permisobtn.Size = new System.Drawing.Size(162, 23);
            this.borrar_permisobtn.TabIndex = 9;
            this.borrar_permisobtn.Text = "Eliminar Permiso";
            this.borrar_permisobtn.UseVisualStyleBackColor = true;
            // 
            // combousuarios
            // 
            this.combousuarios.FormattingEnabled = true;
            this.combousuarios.Location = new System.Drawing.Point(80, 373);
            this.combousuarios.Name = "combousuarios";
            this.combousuarios.Size = new System.Drawing.Size(121, 21);
            this.combousuarios.TabIndex = 10;
            // 
            // PermisosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 539);
            this.Controls.Add(this.combousuarios);
            this.Controls.Add(this.borrar_permisobtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.arbol_permisos);
            this.Name = "PermisosFRM";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView arbol_permisos;
        private System.Windows.Forms.Button agregarrolbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combo_permisos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label nombretxt;
        private System.Windows.Forms.Button borrar_permisobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_roltxt;
        private System.Windows.Forms.ComboBox combousuarios;
    }
}