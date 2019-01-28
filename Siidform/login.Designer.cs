namespace Siidform
{
    partial class SIID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.Plog = new Telerik.WinControls.UI.RadPanel();
            this.linkUsuario = new System.Windows.Forms.LinkLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.bsalir = new Telerik.WinControls.UI.RadButton();
            this.Blog = new Telerik.WinControls.UI.RadButton();
            this.Tpass = new Telerik.WinControls.UI.RadTextBoxControl();
            this.Tuser = new Telerik.WinControls.UI.RadTextBoxControl();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Plog)).BeginInit();
            this.Plog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Plog
            // 
            this.Plog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Plog.Controls.Add(this.linkUsuario);
            this.Plog.Controls.Add(this.radLabel2);
            this.Plog.Controls.Add(this.userimg);
            this.Plog.Controls.Add(this.radLabel1);
            this.Plog.Controls.Add(this.bsalir);
            this.Plog.Controls.Add(this.Blog);
            this.Plog.Controls.Add(this.Tpass);
            this.Plog.Controls.Add(this.Tuser);
            this.Plog.Location = new System.Drawing.Point(103, 84);
            this.Plog.Name = "Plog";
            this.Plog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plog.Size = new System.Drawing.Size(459, 237);
            this.Plog.TabIndex = 0;
            this.Plog.Tag = "SIID";
            this.Plog.ThemeName = "Desert";
            // 
            // linkUsuario
            // 
            this.linkUsuario.AutoSize = true;
            this.linkUsuario.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUsuario.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkUsuario.Location = new System.Drawing.Point(24, 155);
            this.linkUsuario.Name = "linkUsuario";
            this.linkUsuario.Size = new System.Drawing.Size(178, 16);
            this.linkUsuario.TabIndex = 3;
            this.linkUsuario.TabStop = true;
            this.linkUsuario.Text = "¿Agregar Usuario?";
            this.linkUsuario.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUsuario_LinkClicked);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(27, 109);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(120, 26);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Contraseña:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(27, 51);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(88, 26);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Usuario:";
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(339, 189);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(98, 24);
            this.bsalir.TabIndex = 4;
            this.bsalir.Text = "Salir";
            this.bsalir.ThemeName = "Desert";
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // Blog
            // 
            this.Blog.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.Location = new System.Drawing.Point(238, 189);
            this.Blog.Name = "Blog";
            this.Blog.Size = new System.Drawing.Size(88, 24);
            this.Blog.TabIndex = 2;
            this.Blog.Text = "log in";
            this.Blog.ThemeName = "Desert";
            this.Blog.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Tpass
            // 
            this.Tpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tpass.Location = new System.Drawing.Point(148, 111);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(168, 24);
            this.Tpass.TabIndex = 1;
            this.Tpass.ThemeName = "Desert";
            this.Tpass.UseSystemPasswordChar = true;
            // 
            // Tuser
            // 
            this.Tuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tuser.Location = new System.Drawing.Point(148, 51);
            this.Tuser.Name = "Tuser";
            this.Tuser.Size = new System.Drawing.Size(168, 26);
            this.Tuser.TabIndex = 0;
            this.Tuser.ThemeName = "Desert";
            // 
            // userimg
            // 
            this.userimg.BackgroundImage = global::Siidform.Properties.Resources.userin;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userimg.Location = new System.Drawing.Point(339, 25);
            this.userimg.Name = "userimg";
            this.userimg.Padding = new System.Windows.Forms.Padding(3);
            this.userimg.Size = new System.Drawing.Size(98, 121);
            this.userimg.TabIndex = 7;
            this.userimg.TabStop = false;
            // 
            // SIID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.Plog);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "SIID";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIENVENIDO SIID";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Plog)).EndInit();
            this.Plog.ResumeLayout(false);
            this.Plog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Plog;
        private Telerik.WinControls.UI.RadTextBoxControl Tuser;
        private Telerik.WinControls.UI.RadTextBoxControl Tpass;
        private Telerik.WinControls.UI.RadButton bsalir;
        private Telerik.WinControls.UI.RadButton Blog;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.PictureBox userimg;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.LinkLabel linkUsuario;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
    }
}

