using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Siidform
{
    public partial class FrmTotales : Telerik.WinControls.UI.RadForm
    {
        public FrmTotales()
        {
            InitializeComponent();
            cargarCombox2();
            cargarCombox3();
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
        public void cargarCombox3()
        {
            List<Item> lista = new List<Item>();

           lista.Add(new Item("Enero", 1));
           lista.Add(new Item("Febrero", 2));
           lista.Add(new Item("Marzo", 3));
           lista.Add(new Item("Abril", 4));
           lista.Add(new Item("Mayo", 5));
           lista.Add(new Item("Junio", 6));
           lista.Add(new Item("Julio", 7));
           lista.Add(new Item("Agosto", 8));
           lista.Add(new Item("Septiempre", 9));
           lista.Add(new Item("Octubre", 10));
           lista.Add(new Item("Noviembre", 11));
           lista.Add(new Item("Diciembre", 12));
            radDropDownList3.DisplayMember = "Name";
            radDropDownList3.ValueMember = "Value";
            radDropDownList3.DataSource = lista;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            totalVentas();
            totalCompras();
//          txtUtilidad.Text = (System.Convert.ToDouble(txtVentasMes.Text) - System.Convert.ToDouble(txtComprasMes.Text)) + "";
        }
        
        public void totalVentas() {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "ventas";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            //Lineas con detalles especificos por metodo.
            crit.Add("MONTH(Fecha)", radDropDownList3.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", txtAnio.Text);
            crit.Add("CodigoSucursal", radDropDownList2.SelectedItem.Value.ToString());

            reg.Add("TotalVenta", "TotalVenta");
            reg.Add("Utilidad", "Utilidad");

            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.0;
            double utilidad = 0.0;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DataRow row = tab.Rows[i];
                total = total + System.Convert.ToDouble(row["TotalVenta"].ToString());
                utilidad = utilidad + System.Convert.ToDouble(row["Utilidad"].ToString());
            }
            txtVentasMes.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";
            txtUtilidad.Text = Decimal.Round(System.Convert.ToDecimal(utilidad), 2) + "";
        }
        public void totalCompras()
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "compras";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            //Lineas con detalles especificos por metodo.
            crit.Add("MONTH(Fecha)", radDropDownList3.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", txtAnio.Text);
            crit.Add("CodigoSucursal", radDropDownList2.SelectedItem.Value.ToString());

            reg.Add("Gravado", "Gravado");
            reg.Add("Fecha", "Fecha");

            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.0;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DataRow row = tab.Rows[i];
                total = total + System.Convert.ToDouble(row["Gravado"].ToString());
            }
            txtComprasMes.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;
                return;
            }
        }
    }
}
