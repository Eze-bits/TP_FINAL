
namespace Presentacion
{
    partial class Menu_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lotes = new System.Windows.Forms.ToolStripMenuItem();
            this.crearLoteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYModificarStock = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularYConfirmarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasSemanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.Lotes,
            this.pedidosToolStripMenuItem,
            this.editarPreciosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.reporteDeVentasSemanalToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Lotes
            // 
            this.Lotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearLoteNuevoToolStripMenuItem,
            this.verYModificarStock});
            this.Lotes.Name = "Lotes";
            this.Lotes.Size = new System.Drawing.Size(47, 20);
            this.Lotes.Text = "Lotes";
            this.Lotes.Click += new System.EventHandler(this.Lotes_Click);
            // 
            // crearLoteNuevoToolStripMenuItem
            // 
            this.crearLoteNuevoToolStripMenuItem.Name = "crearLoteNuevoToolStripMenuItem";
            this.crearLoteNuevoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.crearLoteNuevoToolStripMenuItem.Text = "Crear Lote nuevo";
            this.crearLoteNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearLoteNuevoToolStripMenuItem_Click);
            // 
            // verYModificarStock
            // 
            this.verYModificarStock.Name = "verYModificarStock";
            this.verYModificarStock.Size = new System.Drawing.Size(226, 22);
            this.verYModificarStock.Text = "Ver y modificar stock de Lote";
            this.verYModificarStock.Click += new System.EventHandler(this.verYModificarStock_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoToolStripMenuItem,
            this.editarPedidosToolStripMenuItem,
            this.anularYConfirmarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // editarPedidosToolStripMenuItem
            // 
            this.editarPedidosToolStripMenuItem.Name = "editarPedidosToolStripMenuItem";
            this.editarPedidosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editarPedidosToolStripMenuItem.Text = "Editar pedidos";
            this.editarPedidosToolStripMenuItem.Click += new System.EventHandler(this.editarPedidosToolStripMenuItem_Click);
            // 
            // anularYConfirmarPedidosToolStripMenuItem
            // 
            this.anularYConfirmarPedidosToolStripMenuItem.Name = "anularYConfirmarPedidosToolStripMenuItem";
            this.anularYConfirmarPedidosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.anularYConfirmarPedidosToolStripMenuItem.Text = "Anular y confirmar pedidos";
            this.anularYConfirmarPedidosToolStripMenuItem.Click += new System.EventHandler(this.anularYConfirmarPedidosToolStripMenuItem_Click);
            // 
            // editarPreciosToolStripMenuItem
            // 
            this.editarPreciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem});
            this.editarPreciosToolStripMenuItem.Name = "editarPreciosToolStripMenuItem";
            this.editarPreciosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editarPreciosToolStripMenuItem.Text = "Precios";
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de precios";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // reporteDeVentasSemanalToolStripMenuItem
            // 
            this.reporteDeVentasSemanalToolStripMenuItem.Name = "reporteDeVentasSemanalToolStripMenuItem";
            this.reporteDeVentasSemanalToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.reporteDeVentasSemanalToolStripMenuItem.Text = "Reporte de ventas semanal";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarPedidoToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturarPedidoToolStripMenuItem
            // 
            this.facturarPedidoToolStripMenuItem.Name = "facturarPedidoToolStripMenuItem";
            this.facturarPedidoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.facturarPedidoToolStripMenuItem.Text = "Facturar pedido";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPermisosToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // modificarPermisosToolStripMenuItem
            // 
            this.modificarPermisosToolStripMenuItem.Name = "modificarPermisosToolStripMenuItem";
            this.modificarPermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarPermisosToolStripMenuItem.Text = "Modificar permisos";
            this.modificarPermisosToolStripMenuItem.Click += new System.EventHandler(this.modificarPermisosToolStripMenuItem_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_principal";
            this.Text = "Sistema IADA SA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Lotes;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearLoteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYModificarStock;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularYConfirmarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasSemanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPermisosToolStripMenuItem;
    }
}

