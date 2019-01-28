namespace Siidform
{
    partial class NuevaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaEmpresa));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.nitmas = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtrepresentante = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radTextBoxControl_nrcemp = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtnombreE = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nitmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepresentante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl_nrcemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombreE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.nitmas);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.txtrepresentante);
            this.radGroupBox1.Controls.Add(this.radTextBoxControl_nrcemp);
            this.radGroupBox1.Controls.Add(this.txtnombreE);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Llene la siguiente información.";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 13);
            this.radGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(492, 275);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Llene la siguiente información.";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // nitmas
            // 
            this.nitmas.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitmas.Location = new System.Drawing.Point(197, 170);
            this.nitmas.Mask = "0000-000000-000-0";
            this.nitmas.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.nitmas.Name = "nitmas";
            this.nitmas.Size = new System.Drawing.Size(200, 21);
            this.nitmas.TabIndex = 4;
            this.nitmas.TabStop = false;
            this.nitmas.Text = "____-______-___-_";
            this.nitmas.ThemeName = "TelerikMetroBlue";
            this.nitmas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitmas_KeyPress);
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton2.Image = global::Siidform.Properties.Resources.cancel;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.Location = new System.Drawing.Point(346, 224);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(125, 38);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "Cerrar";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton2.ThemeName = "TelerikMetroBlue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Gold;
            this.radButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::Siidform.Properties.Resources.drive_disk;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(209, 224);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(124, 38);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Guardar";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // txtrepresentante
            // 
            this.txtrepresentante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepresentante.ForeColor = System.Drawing.Color.Green;
            this.txtrepresentante.Location = new System.Drawing.Point(197, 82);
            this.txtrepresentante.Name = "txtrepresentante";
            this.txtrepresentante.Size = new System.Drawing.Size(289, 26);
            this.txtrepresentante.TabIndex = 2;
            this.txtrepresentante.ThemeName = "TelerikMetroBlue";
            this.txtrepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radTextBoxControl3_KeyPress);
            // 
            // radTextBoxControl_nrcemp
            // 
            this.radTextBoxControl_nrcemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBoxControl_nrcemp.ForeColor = System.Drawing.Color.Green;
            this.radTextBoxControl_nrcemp.Location = new System.Drawing.Point(197, 127);
            this.radTextBoxControl_nrcemp.Name = "radTextBoxControl_nrcemp";
            this.radTextBoxControl_nrcemp.Size = new System.Drawing.Size(200, 26);
            this.radTextBoxControl_nrcemp.TabIndex = 3;
            this.radTextBoxControl_nrcemp.ThemeName = "TelerikMetroBlue";
            // 
            // txtnombreE
            // 
            this.txtnombreE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreE.ForeColor = System.Drawing.Color.Green;
            this.txtnombreE.Location = new System.Drawing.Point(197, 37);
            this.txtnombreE.Name = "txtnombreE";
            this.txtnombreE.Size = new System.Drawing.Size(289, 26);
            this.txtnombreE.TabIndex = 1;
            this.txtnombreE.ThemeName = "TelerikMetroBlue";
            this.txtnombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radTextBoxControl1_KeyPress);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(140, 167);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(49, 24);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "N.I.T.:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(32, 90);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(157, 24);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Representante legal:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(134, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 24);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "N.R.C.:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(50, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(138, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nombre Empresa:";
            // 
            // NuevaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 295);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaEmpresa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Empresa";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nitmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepresentante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl_nrcemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombreE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBoxControl txtrepresentante;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl_nrcemp;
        private Telerik.WinControls.UI.RadTextBoxControl txtnombreE;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMaskedEditBox nitmas;
    }
}
