namespace Siidform
{
    partial class FrmTotales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTotales));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnio = new Telerik.WinControls.UI.RadTextBox();
            this.radDropDownList3 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnGenerar = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtUtilidad = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtComprasMes = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtVentasMes = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprasMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVentasMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.radDropDownList3);
            this.groupBox1.Controls.Add(this.radLabel2);
            this.groupBox1.Controls.Add(this.radLabel1);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.radDropDownList2);
            this.groupBox1.Controls.Add(this.radLabel12);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(61, 43);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 22);
            this.txtAnio.TabIndex = 48;
            this.txtAnio.ThemeName = "TelerikMetroBlue";
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // radDropDownList3
            // 
            this.radDropDownList3.Location = new System.Drawing.Point(61, 70);
            this.radDropDownList3.Name = "radDropDownList3";
            this.radDropDownList3.Size = new System.Drawing.Size(190, 22);
            this.radDropDownList3.TabIndex = 47;
            this.radDropDownList3.Text = "radDropDownList3";
            this.radDropDownList3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(10, 72);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 18);
            this.radLabel2.TabIndex = 46;
            this.radLabel2.Text = "Mes:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(10, 46);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 44;
            this.radLabel1.Text = "Año:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::Siidform.Properties.Resources.computer;
            this.btnGenerar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerar.Location = new System.Drawing.Point(274, 56);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 39);
            this.btnGenerar.TabIndex = 44;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.ThemeName = "TelerikMetroBlue";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Location = new System.Drawing.Point(61, 19);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(190, 22);
            this.radDropDownList2.TabIndex = 43;
            this.radDropDownList2.Text = "Seleccione sucursal";
            this.radDropDownList2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel12
            // 
            this.radLabel12.Location = new System.Drawing.Point(10, 21);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(50, 18);
            this.radLabel12.TabIndex = 42;
            this.radLabel12.Text = "Sucursal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radLabel8);
            this.groupBox2.Controls.Add(this.radLabel7);
            this.groupBox2.Controls.Add(this.txtUtilidad);
            this.groupBox2.Controls.Add(this.radLabel5);
            this.groupBox2.Controls.Add(this.txtComprasMes);
            this.groupBox2.Controls.Add(this.radLabel4);
            this.groupBox2.Controls.Add(this.txtVentasMes);
            this.groupBox2.Controls.Add(this.radLabel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(31, 90);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(83, 24);
            this.radLabel8.TabIndex = 54;
            this.radLabel8.Text = "COMPRAS";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(31, 24);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(67, 24);
            this.radLabel7.TabIndex = 53;
            this.radLabel7.Text = "VENTAS";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Enabled = false;
            this.txtUtilidad.Location = new System.Drawing.Point(279, 171);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(100, 22);
            this.txtUtilidad.TabIndex = 54;
            this.txtUtilidad.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(85, 175);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(190, 18);
            this.radLabel5.TabIndex = 53;
            this.radLabel5.Text = "UTILIDAD OBTENIDAD EN EL MES:";
            // 
            // txtComprasMes
            // 
            this.txtComprasMes.Enabled = false;
            this.txtComprasMes.Location = new System.Drawing.Point(115, 119);
            this.txtComprasMes.Name = "txtComprasMes";
            this.txtComprasMes.Size = new System.Drawing.Size(100, 22);
            this.txtComprasMes.TabIndex = 52;
            this.txtComprasMes.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(10, 123);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(95, 18);
            this.radLabel4.TabIndex = 51;
            this.radLabel4.Text = "Compras del mes:";
            // 
            // txtVentasMes
            // 
            this.txtVentasMes.Enabled = false;
            this.txtVentasMes.Location = new System.Drawing.Point(115, 47);
            this.txtVentasMes.Name = "txtVentasMes";
            this.txtVentasMes.Size = new System.Drawing.Size(100, 22);
            this.txtVentasMes.TabIndex = 50;
            this.txtVentasMes.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(10, 51);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(84, 18);
            this.radLabel3.TabIndex = 49;
            this.radLabel3.Text = "Ventas del mes:";
            // 
            // FrmTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTotales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total del periodo";
            this.ThemeName = "TelerikMetroBlue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprasMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVentasMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton btnGenerar;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadTextBox txtAnio;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtUtilidad;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtComprasMes;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtVentasMes;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
