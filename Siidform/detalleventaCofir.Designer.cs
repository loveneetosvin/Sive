namespace Siidform
{
    partial class detalleventaCofir
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
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGridView3 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView3
            // 
            this.radGridView3.Location = new System.Drawing.Point(7, 15);
            // 
            // radGridView3
            // 
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.HeaderText = "Subtotal";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "Precio";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 100;
            this.radGridView3.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView3.MasterTemplate.EnableGrouping = false;
            this.radGridView3.Name = "radGridView3";
            this.radGridView3.Size = new System.Drawing.Size(632, 257);
            this.radGridView3.TabIndex = 0;
            this.radGridView3.Text = "radGridView1";
            this.radGridView3.ThemeName = "TelerikMetroBlue";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(39, 278);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(143, 37);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Remover Producto";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(39, 338);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(143, 33);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Atras";
            this.radButton2.ThemeName = "TelerikMetroBlue";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(509, 338);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(130, 33);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "Registrar Venta";
            this.radButton3.ThemeName = "TelerikMetroBlue";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 647;
            this.lineShape1.Y1 = 328;
            this.lineShape1.Y2 = 328;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(498, 278);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Total=";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(539, 276);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 22);
            this.radTextBox1.TabIndex = 6;
            this.radTextBox1.Text = "$ -----------";
            this.radTextBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGridView3);
            this.radPanel1.Controls.Add(this.radTextBox1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radButton3);
            this.radPanel1.Controls.Add(this.radButton2);
            this.radPanel1.Controls.Add(this.shapeContainer2);
            this.radPanel1.Location = new System.Drawing.Point(9, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(666, 387);
            this.radPanel1.TabIndex = 7;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(666, 387);
            this.shapeContainer2.TabIndex = 7;
            this.shapeContainer2.TabStop = false;
            // 
            // detalleventaCofir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 400);
            this.Controls.Add(this.radPanel1);
            this.Name = "detalleventaCofir";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "detalleventaCofir";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        
    }
}
