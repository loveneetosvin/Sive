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
    public partial class FrmInventario : Telerik.WinControls.UI.RadForm
    {
        public FrmInventario()
        {
            InitializeComponent();
            cargarInventario();
            cargarCombox2();
        }
        double TotalInve = 0;
        public void cargarInventario() {
            opcionesdb opcione = new opcionesdb();
            this.radGridView1.MasterTemplate.Rows.Clear();
            DataTable tabla = opcione.productoJOIN();
            DataRow row;
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView1.Rows.AddNew();
                int x = radGridView1.Rows.Count;
                this.radGridView1.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
                this.radGridView1.Rows[x - 1].Cells[1].Value = row["Correlativo"].ToString();
                this.radGridView1.Rows[x - 1].Cells[2].Value = row["Nombre"].ToString();
                this.radGridView1.Rows[x - 1].Cells[3].Value = row["Gravado"].ToString();
                this.radGridView1.Rows[x - 1].Cells[4].Value = row["NombreP"].ToString();
                TotalInve = TotalInve + System.Convert.ToDouble(row["Gravado"].ToString());
            }
            txtTotal.Text = TotalInve + "";
            labelTP.Text = radGridView1.Rows.Count+"";
        }
        public void cargarCombox2()
        {
            //this.radGridView1.MasterTemplate.Rows.Clear();
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Sucursal";

            DataTable tabla = opciones.ObtenerTodasTuplas(NomTabla);
            List<Item> lista = new List<Item>();

            DataRow row;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                row = tabla.Rows[i];
                lista.Add(new Item(row["Nombre"].ToString(), System.Convert.ToInt32(row["CodigoSucursal"])));
            }
            radDropDownList2.DisplayMember = "Name";
            radDropDownList2.ValueMember = "Value";
            radDropDownList2.DataSource = lista;
        }
        private void btnCargarTodo_Click(object sender, EventArgs e)
        {
            cargarInventario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            opcionesdb opciones = new opcionesdb();
            DataTable tabla = opciones.productoJOINFiltro(System.Convert.ToInt32(radDropDownList2.SelectedItem.Value.ToString()), txtNombre.Text);
            DataRow row;
            this.radGridView1.MasterTemplate.Rows.Clear();
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView1.Rows.AddNew();
                int x = radGridView1.Rows.Count;
                this.radGridView1.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
                this.radGridView1.Rows[x - 1].Cells[1].Value = row["Correlativo"].ToString();
                this.radGridView1.Rows[x - 1].Cells[2].Value = row["Nombre"].ToString();
                this.radGridView1.Rows[x - 1].Cells[3].Value = row["Gravado"].ToString();
                this.radGridView1.Rows[x - 1].Cells[4].Value = row["NombreP"].ToString();
                TotalInve = TotalInve + System.Convert.ToDouble(row["Gravado"].ToString());
            }
            txtTotal.Text = TotalInve + "";
            labelTP.Text = radGridView1.Rows.Count + "";
        }
    }
}
