﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombretxt = new System.Windows.Forms.Label();
            this.borrar_permisobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminar_rolbtn = new System.Windows.Forms.Button();
            this.grilla_roles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.agregarusubtn = new System.Windows.Forms.Button();
            this.borrardeusubtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_roles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbol_permisos
            // 
            this.arbol_permisos.Location = new System.Drawing.Point(360, 37);
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
            this.agregarrolbtn.Text = "Nuevo Rol";
            this.agregarrolbtn.UseVisualStyleBackColor = true;
            this.agregarrolbtn.Click += new System.EventHandler(this.agregarrolbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(71, 43);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(100, 20);
            this.desctxt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 30);
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
            this.combo_permisos.Location = new System.Drawing.Point(146, 32);
            this.combo_permisos.Name = "combo_permisos";
            this.combo_permisos.Size = new System.Drawing.Size(351, 21);
            this.combo_permisos.TabIndex = 4;
            // 
            // groupBox1
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
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
            this.groupBox2.Size = new System.Drawing.Size(516, 79);
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
            // borrar_permisobtn
            // 
            this.borrar_permisobtn.Location = new System.Drawing.Point(635, 208);
            this.borrar_permisobtn.Name = "borrar_permisobtn";
            this.borrar_permisobtn.Size = new System.Drawing.Size(162, 23);
            this.borrar_permisobtn.TabIndex = 9;
            this.borrar_permisobtn.Text = "Eliminar Permiso";
            this.borrar_permisobtn.UseVisualStyleBackColor = true;
            this.borrar_permisobtn.Click += new System.EventHandler(this.borrar_permisobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(599, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Roles y permisos";
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Location = new System.Drawing.Point(84, 75);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(233, 21);
            this.combo_usuarios.TabIndex = 12;
            this.combo_usuarios.SelectionChangeCommitted += new System.EventHandler(this.combo_usuarios_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usuarios";
            // 
            // eliminar_rolbtn
            // 
            this.eliminar_rolbtn.Location = new System.Drawing.Point(635, 281);
            this.eliminar_rolbtn.Name = "eliminar_rolbtn";
            this.eliminar_rolbtn.Size = new System.Drawing.Size(162, 23);
            this.eliminar_rolbtn.TabIndex = 16;
            this.eliminar_rolbtn.Text = "Eliminar Rol";
            this.eliminar_rolbtn.UseVisualStyleBackColor = true;
            this.eliminar_rolbtn.Click += new System.EventHandler(this.eliminar_rolbtn_Click);
            // 
            // grilla_roles
            // 
            this.grilla_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_roles.Location = new System.Drawing.Point(381, 57);
            this.grilla_roles.Name = "grilla_roles";
            this.grilla_roles.Size = new System.Drawing.Size(417, 188);
            this.grilla_roles.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Roles del usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.borrardeusubtn);
            this.groupBox3.Controls.Add(this.agregarusubtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.grilla_roles);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.combo_usuarios);
            this.groupBox3.Location = new System.Drawing.Point(42, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(892, 275);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuarios";
            // 
            // agregarusubtn
            // 
            this.agregarusubtn.Location = new System.Drawing.Point(82, 132);
            this.agregarusubtn.Name = "agregarusubtn";
            this.agregarusubtn.Size = new System.Drawing.Size(235, 23);
            this.agregarusubtn.TabIndex = 20;
            this.agregarusubtn.Text = "Agregar rol seleccionado a usuario";
            this.agregarusubtn.UseVisualStyleBackColor = true;
            this.agregarusubtn.Click += new System.EventHandler(this.agregarusubtn_Click);
            // 
            // borrardeusubtn
            // 
            this.borrardeusubtn.Location = new System.Drawing.Point(84, 191);
            this.borrardeusubtn.Name = "borrardeusubtn";
            this.borrardeusubtn.Size = new System.Drawing.Size(235, 23);
            this.borrardeusubtn.TabIndex = 21;
            this.borrardeusubtn.Text = "Borrar rol a usuario";
            this.borrardeusubtn.UseVisualStyleBackColor = true;
            // 
            // PermisosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.eliminar_rolbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrar_permisobtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.arbol_permisos);
            this.Name = "PermisosFRM";
            this.Text = " Permisos";
            this.Load += new System.EventHandler(this.UsuariosFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_roles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbol_permisos;
        private System.Windows.Forms.Button agregarrolbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combo_permisos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombretxt;
        private System.Windows.Forms.Button borrar_permisobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminar_rolbtn;
        private System.Windows.Forms.DataGridView grilla_roles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button borrardeusubtn;
        private System.Windows.Forms.Button agregarusubtn;
    }
}