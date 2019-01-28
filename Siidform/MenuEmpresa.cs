using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
//using ridDatagridView;

namespace Siidform
{
    public partial class MenuEmpresa : Telerik.WinControls.UI.RadForm, IForm
    {
        String Name_user = "";
        int idEmpresaGlobalP = -1;
        public String nombre_empresa = "";
        public MenuEmpresa(String Name_user)
        {
            InitializeComponent();
            this.Name_user = Name_user;
            //   this.Text = "Sistema Integrado de Inventarios - USUARIO REGISTRADO: " + Name_user;
            this.Text = "SIVE - Bienvenida";
            this.IsMdiContainer = true;
            //radMenuItem5.Enabled = false;
            //radMenuItem6.Enabled = false;
            //radMenuItem7.Enabled = false;
            //radMenuItem8.Enabled = false;
            //radMenuItem9.Enabled = false;
//            radMenuItem13.Enabled = false;
        }

        public void idEmpresaElegida(int ID, string name)
        {
            this.idEmpresaGlobalP = ID;
          //    this.Text = "Menu Empresa - USUARIO REGISTRADO: " + Name_user + " ---- ID EMPRESA: " + ID + " - " + name;
            this.Text = "SIVE - Bienvenida";
            this.nombre_empresa = name;
            radMenuItem5.Enabled = true;
            radMenuItem6.Enabled = true;
            radMenuItem7.Enabled = true;
            radMenuItem8.Enabled = true;
            radMenuItem9.Enabled = true;
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NuevaEmpresa Nemp = new NuevaEmpresa(Name_user);
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        
        private void radMenuItem15_Click(object sender, EventArgs e)
        {
           /* IForm2 miInterfaz = this.Owner as IForm2;
            if (miInterfaz != null)
                miInterfaz.cerrarSesion("True");
            //this.Dispose();
            //this.Visible = false;
            Loggin volver = new Loggin();
          if (Telerik.WinControls.RadMessageBox.Show("¿Realmente desea cerrar sesión?", "sesión", MessageBoxButtons.YesNo)==DialogResult.Yes)
          {
                volver.Show();
                this.Dispose();
            }*/

        }

        private void MenuEmpresa_FormClosed_1(object sender, FormClosedEventArgs e)
        {
           /* DialogResult resultado = Telerik.WinControls.RadMessageBox.Show("\t  La aplicacion se cerrará \n¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, Telerik.WinControls.RadMessageIcon.Question);
            if (resultado == DialogResult.OK)
            {
            Application.Exit();
            }
            else
            {

            }*/
            
        }

        private void MenuEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form1 Nemp = new Form1();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
            
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            admProveedores Nemp = new admProveedores();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void nProveedor_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            registrarCompra2 Nemp = new registrarCompra2();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void IntroducirIn_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            registrarVenta2 Nemp = new registrarVenta2();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void Nproducto_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FrmInventario Nemp = new FrmInventario();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void verTotalesMes_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FrmTotales Nemp = new FrmTotales();
            Nemp.MdiParent = this;
            Nemp.Show();
        }

        private void radMenu1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer=true;
            facturaborrador borrador = new facturaborrador();
            borrador.MdiParent = this;
            borrador.Show();

    }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            totalesFinales totalF = new totalesFinales();
            totalF.MdiParent = this;
            totalF.Show();
        }

        private void MenuEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            RadMessageBox.SetThemeName("TelerikMetroBlue");
            DialogResult result = Telerik.WinControls.RadMessageBox.Show("¿ Realmente desea Salir ?", "Confirmación", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void AdmPrecio_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            catalogoprecios precios = new catalogoprecios();
            precios.MdiParent = this;
            precios.Show();
        }

        private void AdmProveedores_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            RadForm1 Nemp = new RadForm1();
            Nemp.MdiParent = this;
            Nemp.Show();
        }
    }
}
