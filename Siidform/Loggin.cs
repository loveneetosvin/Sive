using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace Siidform
{
    public partial class Loggin : Telerik.WinControls.UI.RadForm, IForm2
    {
        public Loggin()
        {
            InitializeComponent();
            Telerik.WinControls.RadMessageBox.SetThemeName("TelerikMetro");
        }
        public void cerrarSesion(string valor)
        {
            // this.Text = "Valor:" + valor;
            MessageBox.Show("Contenido: " + valor);
            // this.Hide();
            this.Visible = true;
            // this.Show();
        }

        private void Loggin_Load(object sender, EventArgs e)
        {

        }

        private void Blog_Click(object sender, EventArgs e)
        {



            if (Tuser.Text.Length == 0 || Tpass.Text.Length == 0)
            {


                Telerik.WinControls.RadMessageBox.Show("Debe completar los campos","¡Atencion!");

            }
            else
            {
                // hay que validar 
                String msj = "false";


                if (msj == "true")
                {
                    //Telerik.WinControls.RadMessageBox.Show("Bienvenido");
                    MenuEmpresa menu = new MenuEmpresa(Tuser.Text);
                    menu.Show();
                    this.Visible = false;
                    //                    this.Hide();
                }
                else
                {
                    Telerik.WinControls.RadMessageBox.Show("No se ha encontrado ningun Usuario o Password que coicidan con la base de datos.");
                }

            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {

           
            
            
            if (Telerik.WinControls.RadMessageBox.Show("El sistema esta a punto de cerrar \n   ¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }

        private void linkUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Plog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tpass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
