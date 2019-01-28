namespace Siidform
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.Mstrip = new System.Windows.Forms.MenuStrip();
            this.empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elegirEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexMesualPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenMensualTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mstrip
            // 
            this.Mstrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Mstrip.BackgroundImage = global::Siidform.Properties.Resources.panel;
            this.Mstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresa,
            this.inventario,
            this.proveedores,
            this.cliente,
            this.reportes,
            this.productos});
            this.Mstrip.Location = new System.Drawing.Point(0, 0);
            this.Mstrip.Name = "Mstrip";
            this.Mstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Mstrip.Size = new System.Drawing.Size(693, 29);
            this.Mstrip.TabIndex = 0;
            this.Mstrip.Text = "MenuInventario";
            // 
            // empresa
            // 
            this.empresa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEmpresaToolStripMenuItem,
            this.modificarEmpresaToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.elegirEmpresaToolStripMenuItem});
            this.empresa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa.ImageTransparentColor = System.Drawing.Color.PowderBlue;
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(84, 25);
            this.empresa.Text = "Empresa";
            // 
            // nuevaEmpresaToolStripMenuItem
            // 
            this.nuevaEmpresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nuevaEmpresaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuevaEmpresaToolStripMenuItem.BackgroundImage")));
            this.nuevaEmpresaToolStripMenuItem.Name = "nuevaEmpresaToolStripMenuItem";
            this.nuevaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nuevaEmpresaToolStripMenuItem.Text = "Nueva Empresa";
            this.nuevaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.nuevaEmpresaToolStripMenuItem_Click);
            // 
            // modificarEmpresaToolStripMenuItem
            // 
            this.modificarEmpresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.modificarEmpresaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarEmpresaToolStripMenuItem.BackgroundImage")));
            this.modificarEmpresaToolStripMenuItem.Name = "modificarEmpresaToolStripMenuItem";
            this.modificarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.modificarEmpresaToolStripMenuItem.Text = "Modificar Empresa";
            this.modificarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpresaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eliminarToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.BackgroundImage")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // elegirEmpresaToolStripMenuItem
            // 
            this.elegirEmpresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elegirEmpresaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elegirEmpresaToolStripMenuItem.BackgroundImage")));
            this.elegirEmpresaToolStripMenuItem.Name = "elegirEmpresaToolStripMenuItem";
            this.elegirEmpresaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.elegirEmpresaToolStripMenuItem.Text = "Elegir Empresa";
            this.elegirEmpresaToolStripMenuItem.Click += new System.EventHandler(this.elegirEmpresaToolStripMenuItem_Click);
            // 
            // inventario
            // 
            this.inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirInventarioToolStripMenuItem,
            this.modificarInventarioToolStripMenuItem});
            this.inventario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(96, 25);
            this.inventario.Text = "Inventario";
            // 
            // introducirInventarioToolStripMenuItem
            // 
            this.introducirInventarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.introducirInventarioToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("introducirInventarioToolStripMenuItem.BackgroundImage")));
            this.introducirInventarioToolStripMenuItem.Name = "introducirInventarioToolStripMenuItem";
            this.introducirInventarioToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.introducirInventarioToolStripMenuItem.Text = "Introducir Inventario";
            this.introducirInventarioToolStripMenuItem.Click += new System.EventHandler(this.introducirInventarioToolStripMenuItem_Click);
            // 
            // modificarInventarioToolStripMenuItem
            // 
            this.modificarInventarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificarInventarioToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarInventarioToolStripMenuItem.BackgroundImage")));
            this.modificarInventarioToolStripMenuItem.Name = "modificarInventarioToolStripMenuItem";
            this.modificarInventarioToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.modificarInventarioToolStripMenuItem.Text = "Modificar Inventario";
            this.modificarInventarioToolStripMenuItem.Click += new System.EventHandler(this.modificarInventarioToolStripMenuItem_Click);
            // 
            // proveedores
            // 
            this.proveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem,
            this.listarProveedorToolStripMenuItem});
            this.proveedores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(115, 25);
            this.proveedores.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nuevoProveedorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuevoProveedorToolStripMenuItem.BackgroundImage")));
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modificarProveedorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarProveedorToolStripMenuItem.BackgroundImage")));
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.modificarProveedorToolStripMenuItem.Text = "Modificar Proveedor";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eliminarProveedorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarProveedorToolStripMenuItem.BackgroundImage")));
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminar Proveedor";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // listarProveedorToolStripMenuItem
            // 
            this.listarProveedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listarProveedorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listarProveedorToolStripMenuItem.BackgroundImage")));
            this.listarProveedorToolStripMenuItem.Name = "listarProveedorToolStripMenuItem";
            this.listarProveedorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.listarProveedorToolStripMenuItem.Text = "Listar Proveedor";
            this.listarProveedorToolStripMenuItem.Click += new System.EventHandler(this.listarProveedorToolStripMenuItem_Click);
            // 
            // cliente
            // 
            this.cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cliente.BackgroundImage")));
            this.cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.listarClienteToolStripMenuItem});
            this.cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(73, 25);
            this.cliente.Text = "Cliente";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nuevoClienteToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuevoClienteToolStripMenuItem.BackgroundImage")));
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modificarClienteToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarClienteToolStripMenuItem.BackgroundImage")));
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eliminarClienteToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarClienteToolStripMenuItem.BackgroundImage")));
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // listarClienteToolStripMenuItem
            // 
            this.listarClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listarClienteToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listarClienteToolStripMenuItem.BackgroundImage")));
            this.listarClienteToolStripMenuItem.Name = "listarClienteToolStripMenuItem";
            this.listarClienteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.listarClienteToolStripMenuItem.Text = "Listar Cliente";
            this.listarClienteToolStripMenuItem.Click += new System.EventHandler(this.listarClienteToolStripMenuItem_Click);
            // 
            // reportes
            // 
            this.reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexMesualPorProductoToolStripMenuItem,
            this.resumenMensualTotalToolStripMenuItem,
            this.resumenAnualToolStripMenuItem});
            this.reportes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(89, 25);
            this.reportes.Text = "Reportes";
            // 
            // kardexMesualPorProductoToolStripMenuItem
            // 
            this.kardexMesualPorProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kardexMesualPorProductoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kardexMesualPorProductoToolStripMenuItem.BackgroundImage")));
            this.kardexMesualPorProductoToolStripMenuItem.Name = "kardexMesualPorProductoToolStripMenuItem";
            this.kardexMesualPorProductoToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.kardexMesualPorProductoToolStripMenuItem.Text = "Kardex Mensual por Producto";
            this.kardexMesualPorProductoToolStripMenuItem.Click += new System.EventHandler(this.kardexMesualPorProductoToolStripMenuItem_Click);
            // 
            // resumenMensualTotalToolStripMenuItem
            // 
            this.resumenMensualTotalToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resumenMensualTotalToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resumenMensualTotalToolStripMenuItem.BackgroundImage")));
            this.resumenMensualTotalToolStripMenuItem.Name = "resumenMensualTotalToolStripMenuItem";
            this.resumenMensualTotalToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.resumenMensualTotalToolStripMenuItem.Text = "Resumen Mensual Total";
            this.resumenMensualTotalToolStripMenuItem.Click += new System.EventHandler(this.resumenMensualTotalToolStripMenuItem_Click);
            // 
            // resumenAnualToolStripMenuItem
            // 
            this.resumenAnualToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resumenAnualToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resumenAnualToolStripMenuItem.BackgroundImage")));
            this.resumenAnualToolStripMenuItem.Name = "resumenAnualToolStripMenuItem";
            this.resumenAnualToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.resumenAnualToolStripMenuItem.Text = "Resumen Anual";
            this.resumenAnualToolStripMenuItem.Click += new System.EventHandler(this.resumenAnualToolStripMenuItem_Click);
            // 
            // productos
            // 
            this.productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem1,
            this.listarProductoToolStripMenuItem,
            this.tipoDeMedidaToolStripMenuItem});
            this.productos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(97, 25);
            this.productos.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nuevoProductoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuevoProductoToolStripMenuItem.BackgroundImage")));
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modificarProductoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarProductoToolStripMenuItem.BackgroundImage")));
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem1
            // 
            this.eliminarProveedorToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eliminarProveedorToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarProveedorToolStripMenuItem1.BackgroundImage")));
            this.eliminarProveedorToolStripMenuItem1.Name = "eliminarProveedorToolStripMenuItem1";
            this.eliminarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(223, 26);
            this.eliminarProveedorToolStripMenuItem1.Text = "Eliminar Producto";
            this.eliminarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem1_Click);
            // 
            // listarProductoToolStripMenuItem
            // 
            this.listarProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listarProductoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listarProductoToolStripMenuItem.BackgroundImage")));
            this.listarProductoToolStripMenuItem.Name = "listarProductoToolStripMenuItem";
            this.listarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.listarProductoToolStripMenuItem.Text = "Listar Producto";
            this.listarProductoToolStripMenuItem.Click += new System.EventHandler(this.listarProductoToolStripMenuItem_Click);
            // 
            // tipoDeMedidaToolStripMenuItem
            // 
            this.tipoDeMedidaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tipoDeMedidaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tipoDeMedidaToolStripMenuItem.BackgroundImage")));
            this.tipoDeMedidaToolStripMenuItem.Name = "tipoDeMedidaToolStripMenuItem";
            this.tipoDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.tipoDeMedidaToolStripMenuItem.Text = "Tipo de Medida";
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 441);
            this.Controls.Add(this.Mstrip);
            this.Name = "PanelPrincipal";
            this.Text = "Sistema Integrado  Inventario ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            this.Mstrip.ResumeLayout(false);
            this.Mstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private System.Windows.Forms.MenuStrip Mstrip;
        private System.Windows.Forms.ToolStripMenuItem empresa;
        private System.Windows.Forms.ToolStripMenuItem nuevaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elegirEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventario;
        private System.Windows.Forms.ToolStripMenuItem introducirInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedores;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cliente;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportes;
        private System.Windows.Forms.ToolStripMenuItem kardexMesualPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenMensualTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenAnualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMedidaToolStripMenuItem;

    }
}