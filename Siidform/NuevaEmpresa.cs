 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Siidform
{
    public partial class NuevaEmpresa : Telerik.WinControls.UI.RadForm
    {
        String userLocal = "";
        public NuevaEmpresa(String user)
        {
            InitializeComponent();
            userLocal = user;
            nitmas.Mask = "0000-000000-000-0";
        }
        public void limpiar()
        {
            txtnombreE.Text= "";
            txtrepresentante.Text = "";
            radTextBoxControl_nrcemp.Text = "";
            nitmas.Text = "";
            
            nitmas.Focus();
        }
        
        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radTextBoxControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && ((e.KeyChar != (char)Keys.Space)&& (e.KeyChar !=(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void radTextBoxControl3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && ((e.KeyChar != (char)Keys.Back)) && ((e.KeyChar != (char)Keys.Space)))
            {

                e.Handled = true;

            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void nitmas_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
