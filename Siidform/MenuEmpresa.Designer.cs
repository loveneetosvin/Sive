namespace Siidform
{
    partial class MenuEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpresa));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.IntroducirIn = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.nProveedor = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.Nproducto = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.verTotalesMes = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.AdmPrecio = new Telerik.WinControls.UI.RadMenuItem();
            this.AdmProveedores = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radMenu1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem5,
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem9,
            this.radMenuItem8,
            this.radMenuItem13,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(876, 193);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetroBlue";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Empresa";
            this.radMenuItem1.AccessibleName = "Empresa";
            this.radMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem1.Image = global::Siidform.Properties.Resources.Empresas;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Inicio";
            this.radMenuItem1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "Inventario";
            this.radMenuItem5.AccessibleName = "Inventario";
            this.radMenuItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem5.Image = global::Siidform.Properties.Resources.Inventario;
            this.radMenuItem5.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.IntroducirIn});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Venta";
            this.radMenuItem5.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // IntroducirIn
            // 
            this.IntroducirIn.AccessibleDescription = "Introducir Inventario";
            this.IntroducirIn.AccessibleName = "Introducir Inventario";
            this.IntroducirIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroducirIn.Image = ((System.Drawing.Image)(resources.GetObject("IntroducirIn.Image")));
            this.IntroducirIn.Name = "IntroducirIn";
            this.IntroducirIn.Text = "Administrar Venta";
            this.IntroducirIn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.IntroducirIn.Click += new System.EventHandler(this.IntroducirIn_Click);
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.AccessibleDescription = "Proveedores";
            this.radMenuItem6.AccessibleName = "Proveedores";
            this.radMenuItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem6.Image = global::Siidform.Properties.Resources.Proveedores;
            this.radMenuItem6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.nProveedor});
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Compra";
            this.radMenuItem6.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // nProveedor
            // 
            this.nProveedor.AccessibleDescription = "Nuevo Proveedor";
            this.nProveedor.AccessibleName = "Nuevo Proveedor";
            this.nProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nProveedor.Image = ((System.Drawing.Image)(resources.GetObject("nProveedor.Image")));
            this.nProveedor.Name = "nProveedor";
            this.nProveedor.Text = "Registrar Compra";
            this.nProveedor.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.nProveedor.Click += new System.EventHandler(this.nProveedor_Click);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.AccessibleDescription = "Cliente";
            this.radMenuItem7.AccessibleName = "Cliente";
            this.radMenuItem7.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem7.AutoSize = true;
            this.radMenuItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem7.HintText = "";
            this.radMenuItem7.Image = global::Siidform.Properties.Resources.Clientes;
            this.radMenuItem7.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radMenuItem7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem10});
            this.radMenuItem7.Margin = new System.Windows.Forms.Padding(0);
            this.radMenuItem7.MaxSize = new System.Drawing.Size(0, 0);
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.radMenuItem7.StretchHorizontally = true;
            this.radMenuItem7.Text = "Proveedores";
            this.radMenuItem7.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem7.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.radMenuItem7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radMenuItem7.UseCompatibleTextRendering = true;
            this.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem7.ZIndex = 0;
            this.radMenuItem7.Click += new System.EventHandler(this.radMenuItem7_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.AccessibleDescription = "Nuevo Cliente";
            this.radMenuItem10.AccessibleName = "Nuevo Cliente";
            this.radMenuItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem10.Image")));
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Administrar Proveedores";
            this.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem10.Click += new System.EventHandler(this.radMenuItem10_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.AccessibleDescription = "Productos";
            this.radMenuItem9.AccessibleName = "Productos";
            this.radMenuItem9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem9.Image = global::Siidform.Properties.Resources.Producto;
            this.radMenuItem9.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radMenuItem9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.Nproducto});
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Inventario";
            this.radMenuItem9.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Nproducto
            // 
            this.Nproducto.AccessibleDescription = "Nuevo producto";
            this.Nproducto.AccessibleName = "Nuevo producto";
            this.Nproducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nproducto.Image = global::Siidform.Properties.Resources.report;
            this.Nproducto.Name = "Nproducto";
            this.Nproducto.Text = "Ver inventario";
            this.Nproducto.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.Nproducto.Click += new System.EventHandler(this.Nproducto_Click);
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.AccessibleDescription = "Reportes";
            this.radMenuItem8.AccessibleName = "Reportes";
            this.radMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radMenuItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem8.Image = global::Siidform.Properties.Resources.Reportes;
            this.radMenuItem8.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radMenuItem8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.verTotalesMes,
            this.radMenuItem4});
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Totales";
            this.radMenuItem8.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // verTotalesMes
            // 
            this.verTotalesMes.AccessibleDescription = "Actualizar Saldo Producto";
            this.verTotalesMes.AccessibleName = "Actualizar Saldo Producto";
            this.verTotalesMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.verTotalesMes.Image = global::Siidform.Properties.Resources.application_get;
            this.verTotalesMes.Name = "verTotalesMes";
            this.verTotalesMes.Text = "Ver totales del mes";
            this.verTotalesMes.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.verTotalesMes.Click += new System.EventHandler(this.verTotalesMes_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Totales Finales";
            this.radMenuItem4.AccessibleName = "Totales Finales";
            this.radMenuItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem4.Image = global::Siidform.Properties.Resources.report;
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Totales Finales";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.AccessibleDescription = "Ayuda";
            this.radMenuItem13.AccessibleName = "Ayuda";
            this.radMenuItem13.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.radMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(192)))));
            this.radMenuItem13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem13.Image = global::Siidform.Properties.Resources.tareas;
            this.radMenuItem13.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.AdmPrecio,
            this.AdmProveedores});
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Tareas Adm.";
            this.radMenuItem13.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem13.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem13.Click += new System.EventHandler(this.radMenuItem13_Click);
            // 
            // AdmPrecio
            // 
            this.AdmPrecio.AccessibleDescription = "Administrar Precio";
            this.AdmPrecio.AccessibleName = "Administrar Precio";
            this.AdmPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmPrecio.Image = ((System.Drawing.Image)(resources.GetObject("AdmPrecio.Image")));
            this.AdmPrecio.Name = "AdmPrecio";
            this.AdmPrecio.Text = "Administrar Precio";
            this.AdmPrecio.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.AdmPrecio.Click += new System.EventHandler(this.AdmPrecio_Click);
            // 
            // AdmProveedores
            // 
            this.AdmProveedores.AccessibleDescription = "Administrar Tareas";
            this.AdmProveedores.AccessibleName = "Administrar Tareas";
            this.AdmProveedores.DescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmProveedores.Image = ((System.Drawing.Image)(resources.GetObject("AdmProveedores.Image")));
            this.AdmProveedores.Name = "AdmProveedores";
            this.AdmProveedores.Text = "Administrar Tareas";
            this.AdmProveedores.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.AdmProveedores.Click += new System.EventHandler(this.AdmProveedores_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Factura Borrado";
            this.radMenuItem2.AccessibleName = "Factura Borrado";
            this.radMenuItem2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.radMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem2.Image = global::Siidform.Properties.Resources.Respaldos;
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Fac Borrado";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Borrador";
            this.radMenuItem3.AccessibleName = "Borrador";
            this.radMenuItem3.DescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem3.Image = global::Siidform.Properties.Resources.application_view_list;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Borrador";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // MenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(876, 459);
            this.Controls.Add(this.radMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(890, 500);
            this.Name = "MenuEmpresa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Sistema Integrado de Inventarios";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuEmpresa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEmpresa_FormClosed_1);
            this.Load += new System.EventHandler(this.MenuEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem IntroducirIn;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem nProveedor;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem Nproducto;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadMenuItem verTotalesMes;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem AdmPrecio;
        private Telerik.WinControls.UI.RadMenuItem AdmProveedores;
    }
}
