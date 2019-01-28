using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siidform
{
    public partial class SIID : Form
    {
        public SIID()
        {
            InitializeComponent();
        }
        private PanelPrincipal menu = new PanelPrincipal();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (Tuser.Text.Length==0 || Tpass.Text.Length == 0 )
            {
                MessageBox.Show("debe completar los campos");
           
            }
            else{
                // hay que validar 
            
            MessageBox.Show("se ha registrado exitosamente");
            menu.Show();
            this.Hide();
            }
        }

        private void linkUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario RegUsuario = new RegistroUsuario();
            RegUsuario.Show();
        }
    }
}
