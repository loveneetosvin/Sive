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
    public partial class registrarCompra : Telerik.WinControls.UI.RadForm
    {
        public registrarCompra()
        {
            //InitializeComponent();
            //cargarCombox();
            //cargarCombox2();
        }

//        public void cargarCombox()
//        {
//            //this.radGridView1.MasterTemplate.Rows.Clear();
//            //Lineas de codigos en comun para todos los metodos.
//            opcionesdb opciones = new opcionesdb();
//            String NomTabla = "Proveedores";

//            DataTable tabla = opciones.ObtenerTodasTuplas(NomTabla);
//            List<Item> lista = new List<Item>();

//            DataRow row;
//            for (int i = 0; i < tabla.Rows.Count; i++)
//            {
//                row = tabla.Rows[i];
//                lista.Add(new Item(row["Nombre"].ToString(), System.Convert.ToInt32(row["CodigoProvedor"])));
//            }
//            radDropDownList1.DisplayMember = "Name";
//            radDropDownList1.ValueMember = "Value";
//            radDropDownList1.DataSource = lista;
//        }

//        public void cargarCombox2()
//        {
//            //this.radGridView1.MasterTemplate.Rows.Clear();
//            //Lineas de codigos en comun para todos los metodos.
//            opcionesdb opciones = new opcionesdb();
//            String NomTabla = "Sucursal";

//            DataTable tabla = opciones.ObtenerTodasTuplas(NomTabla);
//            List<Item> lista = new List<Item>();

//            DataRow row;
//            for (int i = 0; i < tabla.Rows.Count; i++)
//            {
//                row = tabla.Rows[i];
//                lista.Add(new Item(row["Nombre"].ToString(), System.Convert.ToInt32(row["CodigoSucursal"])));
//            }
//            radDropDownList22.DisplayMember = "Name";
//            radDropDownList22.ValueMember = "Value";
//            radDropDownList22.DataSource = lista;
//        }

//        private void registrarCompra_Load(object sender, EventArgs e)
//        {

//        }

//        private void radTextBox1_KeyUp(object sender, KeyEventArgs e)
//        {

//        }

//        private void btnBuscar_Click(object sender, EventArgs e)
//        {
//            compra com = new compra();
//            producto product = com.agregarItem(txtCodigoBarra.Text);
//            txtNombre.Text = product.Nombre;
//        }

//        private void btnAgregar_Click(object sender, EventArgs e)
//        {
//            compra com = new compra();
//            producto product = com.agregarItem(txtCodigoBarra.Text);
                
//          //  for(int i=0; i<(System.Convert.ToInt32(txtCantidad.Text)); i++){
//                radGridView11.Rows.AddNew();
//                int f = radGridView11.Rows.Count;
//                this.radGridView11.Rows[f - 1].Cells[0].Value = product.CodigoBarra;
                
//                this.radGridView11.Rows[f - 1].Cells[1].Value = product.Nombre;
//                this.radGridView11.Rows[f - 1].Cells[2].Value = txtCosto2.Text;
//                this.radGridView11.Rows[f - 1].Cells[3].Value = txtCorrelativo.Text;
//                //this.radGridView1.Rows[f - 1].Cells[5].Value = radDropDownList1.SelectedItem.DisplayValue;
//                //this.radGridView1.Rows[f - 1].Cells[6].Value = txtPrecioLiquidacion.Text;
            
//                //inventario inv = new inventario();
//                //inv.Prod = product;
//                //inv.obtenerCorrelativo();

//                //if (hayEsteCodigoBarra(product.CodigoBarra))
//                //{

//                //}
//                //else {
//                //    this.radGridView1.Rows[f - 1].Cells[1].Value = inv.Correlativo + 1;                    
//                //}
//           // }
//                calcularTotal();
//        }

//        public void calcularTotal() {
//            double cots;
//            double canti;
//            double mult;
//            double sumTotal=0;
//            for (int i = 0; i < radGridView11.Rows.Count; i++ )
//            {
//                cots = System.Convert.ToDouble(this.radGridView11.Rows[i].Cells[2].Value);
//                canti = System.Convert.ToDouble(this.radGridView11.Rows[i].Cells[3].Value);
//                mult = cots * canti;
//                sumTotal = sumTotal + mult;
//            }
//            txtTotal2.Text = System.Convert.ToString(sumTotal);
//        }
//        public Boolean hayEsteCodigoBarra(String codBarra) {
//            string cod;
//            Boolean hay = false;
//            for (int i = 0; i < radGridView11.Rows.Count; i++)
//            {
//                cod = this.radGridView11.Rows[i].Cells[0].Value+"";        
//                if(cod == codBarra){
//                    hay = true;
//                }
//            }
//            return hay;
//        }
//        public void sumarCorrelativo() { 
            
//        }
//        private void btnRegistrar_Click(object sender, EventArgs e)
//        {
//            compra compr = new compra();
//          //  proveedor prov = new proveedor(radDropDownList1.SelectedItem.Value.ToString(), radDropDownList1.SelectedItem.DisplayValue.ToString());
//            sucursal[] arraySucursales = new sucursal[1];
//            arraySucursales[0] = new sucursal(radDropDownList22.SelectedItem.Value.ToString(),radDropDownList22.SelectedItem.DisplayValue.ToString());
//            arraySucursales[0].Codigosucursal = radDropDownList22.SelectedItem.Value.ToString();
//            arraySucursales[0].Nombre = radDropDownList22.SelectedItem.DisplayValue.ToString();
//            proveedor[] arrayProveedores = new proveedor[1];
//            arrayProveedores[0] = new proveedor(radDropDownList1.SelectedItem.Value.ToString(), radDropDownList1.SelectedItem.DisplayValue.ToString());
//            arrayProveedores[0].CodigoProveedor = radDropDownList1.SelectedItem.Value.ToString();
//            arrayProveedores[0].Nombre = radDropDownList1.SelectedItem.DisplayValue.ToString();

//            compr.Sucursal = arraySucursales;
//            compr.Proveedor = arrayProveedores;

//            int f = 0;

//            for (int t = 0; t < radGridView11.Rows.Count;t++)
//            {
//                f = f+System.Convert.ToInt32(this.radGridView11.Rows[t].Cells[3].Value);
//            }

//            inventario[] inventar = new inventario[radGridView11.Rows.Count];
//            int cantidad=0;
//            MessageBox.Show("variable radGridView1.Rows.Count = " + radGridView11.Rows.Count);
//            for (int t = 0; t < radGridView11.Rows.Count; t++)
//            {
//                cantidad =  System.Convert.ToInt32(this.radGridView11.Rows[t].Cells[3].Value);
//                producto[] arrayProduc = new producto[cantidad];
//                MessageBox.Show("variable cantidad = " + cantidad);
//                for (int i = 0; i < cantidad; i++)
//                {
//                    MessageBox.Show("variable i = " + i+ "   variable t = " + t);
//                    arrayProduc[i] = new producto(this.radGridView11.Rows[t].Cells[0].Value+"",this.radGridView11.Rows[t].Cells[1].Value + "");
//                    arrayProduc[i].CodigoBarra = this.radGridView11.Rows[t].Cells[0].Value+"";
//                    arrayProduc[i].Nombre = this.radGridView11.Rows[t].Cells[1].Value + "";
//                }
//              //inventario invet = new inventario();
//              //invet.Producto = arrayProduc
//                inventar[t] = new inventario();
//                inventar[t].Producto = arrayProduc;
// //               precio preci = new precio();
// //               preci.Monto = System.Convert.ToDouble(this.radGridView1.Rows[t].Cells[2].Value);
// //               invet.Costo = System.Convert.ToDouble(this.radGridView1.Rows[t].Cells[2].Value);
//                inventar[t].Costo = System.Convert.ToDouble(this.radGridView11.Rows[t].Cells[2].Value);
//            }
//            compr.Productos = inventar;
//            String fech = Convert.ToString(radDateTimePicker11.Value);

//            compr.Fecha = radDateTimePicker11.Value;

////            compr.Fecha = fech.Substring(0, 10);
//            compr.calcularTotal();
//            compr.registrarCompra();


//        }
//        int indexGlobal;
//        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
//        {
//            indexGlobal = System.Convert.ToInt32(radGridView11.MasterGridViewInfo.CurrentIndex.ToString());
            
//        }

//        private void btnRemover_Click(object sender, EventArgs e)
//        {
//            radGridView11.Rows.RemoveAt(indexGlobal);
//            calcularTotal();
//        }
    }
}
