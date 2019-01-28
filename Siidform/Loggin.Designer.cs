namespace Siidform
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            this.Plog = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.linkUsuario = new System.Windows.Forms.LinkLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.bsalir = new Telerik.WinControls.UI.RadButton();
            this.Blog = new Telerik.WinControls.UI.RadButton();
            this.Tpass = new Telerik.WinControls.UI.RadTextBoxControl();
            this.Tuser = new Telerik.WinControls.UI.RadTextBoxControl();
            this.TelerikMetro = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Plog)).BeginInit();
            this.Plog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Plog
            // 
            this.Plog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plog.BackColor = System.Drawing.Color.LightGray;
            this.Plog.Controls.Add(this.radLabel3);
            this.Plog.Controls.Add(this.linkUsuario);
            this.Plog.Controls.Add(this.radLabel2);
            this.Plog.Controls.Add(this.userimg);
            this.Plog.Controls.Add(this.radLabel1);
            this.Plog.Controls.Add(this.bsalir);
            this.Plog.Controls.Add(this.Blog);
            this.Plog.Controls.Add(this.Tpass);
            this.Plog.Controls.Add(this.Tuser);
            this.Plog.Location = new System.Drawing.Point(194, 100);
            this.Plog.Name = "Plog";
            this.Plog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plog.Size = new System.Drawing.Size(463, 229);
            this.Plog.TabIndex = 1;
            this.Plog.Tag = "SIID";
            this.Plog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Plog.ThemeName = "TelerikMetro";
            this.Plog.Paint += new System.Windows.Forms.PaintEventHandler(this.Plog_Paint);
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(2, 1);
            this.radLabel3.MinimumSize = new System.Drawing.Size(459, 18);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.MinSize = new System.Drawing.Size(459, 18);
            this.radLabel3.Size = new System.Drawing.Size(459, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "                                                                                 " +
    "         ";
            // 
            // linkUsuario
            // 
            this.linkUsuario.AutoSize = true;
            this.linkUsuario.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkUsuario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkUsuario.Location = new System.Drawing.Point(24, 155);
            this.linkUsuario.Name = "linkUsuario";
            this.linkUsuario.Size = new System.Drawing.Size(158, 16);
            this.linkUsuario.TabIndex = 3;
            this.linkUsuario.TabStop = true;
            this.linkUsuario.Text = "Agregar Empresa";
            this.linkUsuario.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUsuario_LinkClicked);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(27, 109);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(132, 28);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Contraseña:";
            // 
            // userimg
            // 
            this.userimg.BackgroundImage = global::Siidform.Properties.Resources.article;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userimg.Location = new System.Drawing.Point(339, 40);
            this.userimg.Name = "userimg";
            this.userimg.Padding = new System.Windows.Forms.Padding(3);
            this.userimg.Size = new System.Drawing.Size(98, 108);
            this.userimg.TabIndex = 7;
            this.userimg.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(27, 51);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 28);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Usuario:";
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Image = global::Siidform.Properties.Resources.cross;
            this.bsalir.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bsalir.Location = new System.Drawing.Point(332, 178);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(105, 35);
            this.bsalir.TabIndex = 4;
            this.bsalir.Text = "Salir";
            this.bsalir.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bsalir.ThemeName = "TelerikMetro";
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // Blog
            // 
            this.Blog.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.Image = global::Siidform.Properties.Resources.accept;
            this.Blog.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Blog.Location = new System.Drawing.Point(217, 178);
            this.Blog.Name = "Blog";
            this.Blog.Size = new System.Drawing.Size(109, 35);
            this.Blog.TabIndex = 2;
            this.Blog.Text = "Ingresar";
            this.Blog.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Blog.ThemeName = "TelerikMetro";
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // Tpass
            // 
            this.Tpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tpass.Location = new System.Drawing.Point(165, 113);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(168, 24);
            this.Tpass.TabIndex = 1;
            this.Tpass.ThemeName = "TelerikMetro";
            this.Tpass.UseSystemPasswordChar = true;
           // this.Tpass.TextChanged += new System.EventHandler(this.Tpass_TextChanged);
            this.Tpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tpass_KeyPress);
            // 
            // Tuser
            // 
            this.Tuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tuser.Location = new System.Drawing.Point(165, 51);
            this.Tuser.Name = "Tuser";
            this.Tuser.Size = new System.Drawing.Size(168, 26);
            this.Tuser.TabIndex = 0;
            this.Tuser.ThemeName = "TelerikMetro";
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(826, 493);
            this.Controls.Add(this.Plog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loggin";
            this.Opacity = 0.87D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                    Bienvenido SI" +
    "ID";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.Loggin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Plog)).EndInit();
            this.Plog.ResumeLayout(false);
            this.Plog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Plog;
        private System.Windows.Forms.LinkLabel linkUsuario;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.PictureBox userimg;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton bsalir;
        private Telerik.WinControls.UI.RadButton Blog;
        private Telerik.WinControls.UI.RadTextBoxControl Tpass;
        private Telerik.WinControls.UI.RadTextBoxControl Tuser;
        private Telerik.WinControls.Themes.TelerikMetroTheme TelerikMetro;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
    }
}
