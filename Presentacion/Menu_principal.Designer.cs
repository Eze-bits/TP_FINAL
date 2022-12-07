
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
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearLoteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYModificarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarcontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.editarPreciosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.reporteDeVentasSemanalToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.gestionDeBackupsToolStripMenuItem,
            this.reporteDeStockToolStripMenuItem,
            this.crearLoteNuevoToolStripMenuItem,
            this.verYModificarStockToolStripMenuItem,
            this.cambiarcontToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoToolStripMenuItem,
            this.editarPedidosToolStripMenuItem,
            this.anularYConfirmarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // editarPedidosToolStripMenuItem
            // 
            this.editarPedidosToolStripMenuItem.Name = "editarPedidosToolStripMenuItem";
            this.editarPedidosToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.editarPedidosToolStripMenuItem.Text = "Editar pedidos";
            this.editarPedidosToolStripMenuItem.Click += new System.EventHandler(this.editarPedidosToolStripMenuItem_Click);
            // 
            // anularYConfirmarPedidosToolStripMenuItem
            // 
            this.anularYConfirmarPedidosToolStripMenuItem.Name = "anularYConfirmarPedidosToolStripMenuItem";
            this.anularYConfirmarPedidosToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.anularYConfirmarPedidosToolStripMenuItem.Text = "Anular y confirmar pedidos";
            this.anularYConfirmarPedidosToolStripMenuItem.Click += new System.EventHandler(this.anularYConfirmarPedidosToolStripMenuItem_Click);
            // 
            // editarPreciosToolStripMenuItem
            // 
            this.editarPreciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem});
            this.editarPreciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editarPreciosToolStripMenuItem.Name = "editarPreciosToolStripMenuItem";
            this.editarPreciosToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.editarPreciosToolStripMenuItem.Text = "Precios";
            this.editarPreciosToolStripMenuItem.Click += new System.EventHandler(this.editarPreciosToolStripMenuItem_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // reporteDeVentasSemanalToolStripMenuItem
            // 
            this.reporteDeVentasSemanalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reporteDeVentasSemanalToolStripMenuItem.Name = "reporteDeVentasSemanalToolStripMenuItem";
            this.reporteDeVentasSemanalToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.reporteDeVentasSemanalToolStripMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasSemanalToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasSemanalToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarPedidoToolStripMenuItem});
            this.facturacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturarPedidoToolStripMenuItem
            // 
            this.facturarPedidoToolStripMenuItem.Name = "facturarPedidoToolStripMenuItem";
            this.facturarPedidoToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.facturarPedidoToolStripMenuItem.Text = "Facturar pedido";
            this.facturarPedidoToolStripMenuItem.Click += new System.EventHandler(this.facturarPedidoToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPermisosToolStripMenuItem});
            this.administradorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // modificarPermisosToolStripMenuItem
            // 
            this.modificarPermisosToolStripMenuItem.Name = "modificarPermisosToolStripMenuItem";
            this.modificarPermisosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.modificarPermisosToolStripMenuItem.Text = "Modificar permisos";
            this.modificarPermisosToolStripMenuItem.Click += new System.EventHandler(this.modificarPermisosToolStripMenuItem_Click);
            // 
            // gestionDeBackupsToolStripMenuItem
            // 
            this.gestionDeBackupsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestionDeBackupsToolStripMenuItem.Name = "gestionDeBackupsToolStripMenuItem";
            this.gestionDeBackupsToolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.gestionDeBackupsToolStripMenuItem.Text = "Gestion de backups";
            this.gestionDeBackupsToolStripMenuItem.Click += new System.EventHandler(this.gestionDeBackupsToolStripMenuItem_Click);
            // 
            // reporteDeStockToolStripMenuItem
            // 
            this.reporteDeStockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reporteDeStockToolStripMenuItem.Name = "reporteDeStockToolStripMenuItem";
            this.reporteDeStockToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.reporteDeStockToolStripMenuItem.Text = "Reporte de stock";
            // 
            // crearLoteNuevoToolStripMenuItem
            // 
            this.crearLoteNuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.crearLoteNuevoToolStripMenuItem.Name = "crearLoteNuevoToolStripMenuItem";
            this.crearLoteNuevoToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.crearLoteNuevoToolStripMenuItem.Text = "Crear Lote nuevo";
            this.crearLoteNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearLoteNuevoToolStripMenuItem_Click_1);
            // 
            // verYModificarStockToolStripMenuItem
            // 
            this.verYModificarStockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.verYModificarStockToolStripMenuItem.Name = "verYModificarStockToolStripMenuItem";
            this.verYModificarStockToolStripMenuItem.Size = new System.Drawing.Size(198, 23);
            this.verYModificarStockToolStripMenuItem.Text = "Ver y modificar stock de Lote";
            this.verYModificarStockToolStripMenuItem.Click += new System.EventHandler(this.verYModificarStockToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cambiarcontToolStripMenuItem
            // 
            this.cambiarcontToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cambiarcontToolStripMenuItem.Name = "cambiarcontToolStripMenuItem";
            this.cambiarcontToolStripMenuItem.Size = new System.Drawing.Size(143, 23);
            this.cambiarcontToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarcontToolStripMenuItem.Click += new System.EventHandler(this.cambiarcontToolStripMenuItem_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 640);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_principal";
            this.Text = "Sistema IADA SA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_principal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeBackupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearLoteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYModificarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarcontToolStripMenuItem;
    }
}

