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
    public partial class facturarVenta : Telerik.WinControls.UI.RadForm
    {
        rowGridView[] nuestroGridView;
        String total="";
        ventas ventass;
        public 
            
            facturarVenta(rowGridView[] GridView, string tota, ventas vent)
        {
            InitializeComponent();
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Visible = false;
            Controls.AddRange(new Control[] { dateTimePicker1 });
            radDateTimePicker1.Value = dateTimePicker1.Value;

            nuestroGridView = GridView;
            total = tota;
            ventass = vent;
            llenar();
         }
        public void llenar(){
            for(int i=0; i<nuestroGridView.Length;i++){
                radGridView1.Rows.AddNew();
                int f = radGridView1.Rows.Count;
                this.radGridView1.Rows[f - 1].Cells[0].Value = nuestroGridView[f - 1].Cells0;
                this.radGridView1.Rows[f - 1].Cells[1].Value = nuestroGridView[f - 1].Cells1;
                this.radGridView1.Rows[f - 1].Cells[2].Value = nuestroGridView[f - 1].Cells2;
                this.radGridView1.Rows[f - 1].Cells[3].Value = nuestroGridView[f - 1].Cells3;
            }
            txtTotalPagar.Text = total;
            ventass.generarNumeroVentas();
            total = ventass.NVenta+"";
            txtNumFactura.Text = total;
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ventass.registrarVenta();
            this.Close();
        }

        public void llenarDetalle(DataTable Detalle)
        {
            double total = 0;
            DataRow row;
            for (int f = 0; f < Detalle.Rows.Count; f++)
            {
                row = Detalle.Rows[f];
                radGridView1.Rows.AddNew();
                int x = radGridView1.Rows.Count;
                this.radGridView1.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
                this.radGridView1.Rows[x - 1].Cells[1].Value = row["Correlativo"].ToString();
                this.radGridView1.Rows[x - 1].Cells[2].Value = row["PrecioReal"].ToString();
                this.radGridView1.Rows[x - 1].Cells[3].Value = row["PrecioVenta"].ToString();

                double numero = System.Convert.ToDouble(this.radGridView1.Rows[x - 1].Cells[3].Value = row["PrecioVenta"].ToString());
                total = total + numero;
            }

            this.txtTotalPagar.Text = Convert.ToString(total);

        }
    }
}
