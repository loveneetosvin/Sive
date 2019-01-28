namespace Siidform
{
    partial class FrmInventario
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.txtTotal = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCargarTodo = new Telerik.WinControls.UI.RadButton();
            this.labelTP = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(393, 425);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 18);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "----------------";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(261, 425);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(124, 18);
            this.radLabel9.TabIndex = 16;
            this.radLabel9.Text = "Valor Total Inventarios: ";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(5, 53);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.HeaderText = "Codigo Barras";
            gridViewTextBoxColumn1.Name = "cod";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.HeaderText = "Correlativo";
            gridViewTextBoxColumn2.Name = "correlativo";
            gridViewTextBoxColumn2.Width = 90;
            gridViewTextBoxColumn3.HeaderText = "Nombre";
            gridViewTextBoxColumn3.Name = "nombre";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.HeaderText = "Costo";
            gridViewTextBoxColumn4.Name = "costo";
            gridViewTextBoxColumn4.Width = 90;
            gridViewTextBoxColumn5.HeaderText = "Proveedor";
            gridViewTextBoxColumn5.Name = "proveedor";
            gridViewTextBoxColumn5.Width = 200;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(795, 366);
            this.radGridView1.TabIndex = 18;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel12
            // 
            this.radLabel12.Location = new System.Drawing.Point(393, 27);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(50, 18);
            this.radLabel12.TabIndex = 38;
            this.radLabel12.Text = "Sucursal:";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Location = new System.Drawing.Point(444, 25);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(190, 22);
            this.radDropDownList2.TabIndex = 40;
            this.radDropDownList2.Text = "radDropDownList2";
            this.radDropDownList2.ThemeName = "TelerikMetroBlue";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(106, 18);
            this.radLabel1.TabIndex = 39;
            this.radLabel1.Text = "Buscar por Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Siidform.Properties.Resources.magnifier;
            this.btnBuscar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(640, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 22);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.ThemeName = "TelerikMetroBlue";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(325, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(192, 18);
            this.radLabel2.TabIndex = 42;
            this.radLabel2.Text = "Buscar filtrada por nombre y sucursal";
            // 
            // btnCargarTodo
            // 
            this.btnCargarTodo.Image = global::Siidform.Properties.Resources.arrow_refresh;
            this.btnCargarTodo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargarTodo.Location = new System.Drawing.Point(666, 425);
            this.btnCargarTodo.Name = "btnCargarTodo";
            this.btnCargarTodo.Size = new System.Drawing.Size(134, 42);
            this.btnCargarTodo.TabIndex = 43;
            this.btnCargarTodo.Text = "Cargar Todo";
            this.btnCargarTodo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarTodo.ThemeName = "TelerikMetroBlue";
            this.btnCargarTodo.Click += new System.EventHandler(this.btnCargarTodo_Click);
            // 
            // labelTP
            // 
            this.labelTP.Location = new System.Drawing.Point(123, 425);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(79, 18);
            this.labelTP.TabIndex = 19;
            this.labelTP.Text = "----------------";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 425);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(103, 18);
            this.radLabel4.TabIndex = 18;
            this.radLabel4.Text = "Total de Productos:";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 470);
            this.Controls.Add(this.labelTP);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnCargarTodo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel12);
            this.Controls.Add(this.radDropDownList2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.radGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario de la Empresa";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabel txtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnCargarTodo;
        private Telerik.WinControls.UI.RadLabel labelTP;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
