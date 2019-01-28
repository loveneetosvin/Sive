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
    public partial class catalogoprecios : Telerik.WinControls.UI.RadForm
    {
        public catalogoprecios()
        {
            InitializeComponent();
        }

        private void catalogoprecios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.Precios' Puede moverla o quitarla según sea necesario.
            this.preciosTableAdapter.Fill(this.inventarioDataSet.Precios);

        }
    }
}
