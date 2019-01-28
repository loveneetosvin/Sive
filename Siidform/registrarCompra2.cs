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
    public partial class registrarCompra2 : Telerik.WinControls.UI.RadForm
    {
        public registrarCompra2()
        {
            InitializeComponent();
            cargarCombox();
            cargarCombox2();
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Visible = false;
            Controls.AddRange(new Control[] { dateTimePicker1 });
            radDateTimePicker1.Value = dateTimePicker1.Value;
            labelMsjExito.Text = "";
            btnAgregar.Enabled = false;
        }

        public void cargarCombox()
        {
            //this.radGridView1.MasterTemplate.Rows.Clear();
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Proveedores";

            DataTable tabla = opciones.ObtenerTodasTuplas(NomTabla);
            List<Item> lista = new List<Item>();

            DataRow row;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                row = tabla.Rows[i];
                lista.Add(new Item(row["Nombre"].ToString(), System.Convert.ToInt32(row["CodigoProvedor"])));
            }
            radDropDownList1.DisplayMember = "Name";
            radDropDownList1.ValueMember = "Value";
            radDropDownList1.DataSource = lista;
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

        private void registrarCompra_Load(object sender, EventArgs e)
        {

        }

        private void radTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            compra com = new compra();
            producto product = com.agregarItem(radTextBox1.Text);
            radTextBox3.Text = product.Nombre;
        //    MessageBox.Show("mostrar mensajes");
        }
        Boolean agregarColumna = true;
        rowGridView[] fila;

        public void agregarColumnasPrecios() {
          //  fila = new rowGridView[cantidadTiposPrecios];
            for (int i = 0; i < cantidadTiposPrecios; i++)
            {
                radGridView1.Columns.Add(radGridView2.Rows[i].Cells[0].Value + "", radGridView2.Rows[i].Cells[0].Value + "");
                radGridView1.Columns[4+i].Width = 80;
            //    fila[i].Cells0 = radGridView2.Rows[i].Cells[0].Value + "";
            }
            agregarColumna = false;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //radGridView2.Columns[4].VisibleInColumnChooser = true;
            compra com = new compra();
            producto product = com.agregarItem(radTextBox1.Text);

            //  for(int i=0; i<(System.Convert.ToInt32(txtCantidad.Text)); i++){
            radGridView1.Rows.AddNew();
            int f = radGridView1.Rows.Count;
            this.radGridView1.Rows[f - 1].Cells[0].Value = product.CodigoBarra;

            this.radGridView1.Rows[f - 1].Cells[1].Value = product.Nombre;
            this.radGridView1.Rows[f - 1].Cells[2].Value = txtCosto.Text;
            this.radGridView1.Rows[f - 1].Cells[3].Value = 1+"";
       //     int g = radGridView2.Rows.Count;
            if (agregarColumna) { 
                agregarColumnasPrecios();            
            }

            for (int i = 0; i < cantidadTiposPrecios;i ++ )
            {
//                radGridView1.Columns.Add(radGridView2.Rows[i].Cells[0].Value + "", radGridView2.Rows[i].Cells[0].Value + "");
                int g = radGridView1.Rows.Count;
                this.radGridView1.Rows[g - 1].Cells[4 + i].Value = radGridView2.Rows[i].Cells[1].Value + "";
              //  fila[i].Cells1 = radGridView2.Rows[i].Cells[1].Value + "";
            }
            //this.radGridView1.Rows[f - 1].Cells[5].Value = radDropDownList1.SelectedItem.DisplayValue;
            //this.radGridView1.Rows[f - 1].Cells[6].Value = txtPrecioLiquidacion.Text;

            //inventario inv = new inventario();
            //inv.Prod = product;
            //inv.obtenerCorrelativo();

            //if (hayEsteCodigoBarra(product.CodigoBarra))
            //{

            //}
            //else {
            //    this.radGridView1.Rows[f - 1].Cells[1].Value = inv.Correlativo + 1;                    
            //}
            // }
            calcularTotal();
        }

        public void calcularTotal()
        {
            double cots;
            double canti;
            double mult;
            double sumTotal = 0;
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                cots = System.Convert.ToDouble(this.radGridView1.Rows[i].Cells[2].Value);
                canti = System.Convert.ToDouble(this.radGridView1.Rows[i].Cells[3].Value);
                mult = cots * canti;
                sumTotal = sumTotal + mult;
            }
            txtTotal.Text = System.Convert.ToString(sumTotal);
            labelMsjExito.Text = "";
        }
        public Boolean hayEsteCodigoBarra(String codBarra)
        {
            string cod;
            Boolean hay = false;
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                cod = this.radGridView1.Rows[i].Cells[0].Value + "";
                if (cod == codBarra)
                {
                    hay = true;
                }
            }
            return hay;
        }
        public void sumarCorrelativo()
        {

        }

        public Boolean validar()
        {
            if (txtCosto.Text != "" && radTextBox1.Text != "" && radTextBox3.Text != ""  && (radGridView1.Rows.Count) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Hashtable[] vistaCompra = new Hashtable[1];

            if (validar())
            {
                compra compr = new compra();
                //  proveedor prov = new proveedor(radDropDownList1.SelectedItem.Value.ToString(), radDropDownList1.SelectedItem.DisplayValue.ToString());
                sucursal[] arraySucursales = new sucursal[1];
                arraySucursales[0] = new sucursal(radDropDownList2.SelectedItem.Value.ToString(), radDropDownList2.SelectedItem.DisplayValue.ToString());
             //   arraySucursales[0].Codigosucursal = radDropDownList2.SelectedItem.Value.ToString();
             //   arraySucursales[0].Nombre = radDropDownList2.SelectedItem.DisplayValue.ToString();
                proveedor[] arrayProveedores = new proveedor[1];
                arrayProveedores[0] = new proveedor(radDropDownList1.SelectedItem.Value.ToString(), radDropDownList1.SelectedItem.DisplayValue.ToString());
             //   arrayProveedores[0].CodigoProveedor = radDropDownList1.SelectedItem.Value.ToString();
             //   arrayProveedores[0].Nombre = radDropDownList1.SelectedItem.DisplayValue.ToString();

                compr.Sucursal = arraySucursales;
                compr.Proveedor = arrayProveedores;
                compr.NDoc1 = txtNumDoc.Text;
                int f = 0;

                for (int t = 0; t < radGridView1.Rows.Count; t++)
                {
                    f = f + System.Convert.ToInt32(this.radGridView1.Rows[t].Cells[3].Value);
                }

                inventario[] inventar = new inventario[radGridView1.Rows.Count];
                int cantidad = 0;
              //  MessageBox.Show("variable radGridView1.Rows.Count = " + radGridView1.Rows.Count);
                for (int t = 0; t < radGridView1.Rows.Count; t++)
                {
                    cantidad = System.Convert.ToInt32(this.radGridView1.Rows[t].Cells[3].Value);
                    producto[] arrayProduc = new producto[cantidad];
              //      MessageBox.Show("variable cantidad = " + cantidad);
                    for (int i = 0; i < cantidad; i++)
                    {
              //          MessageBox.Show("variable i = " + i + "   variable t = " + t);
                        arrayProduc[i] = new producto(this.radGridView1.Rows[t].Cells[0].Value + "", this.radGridView1.Rows[t].Cells[1].Value + "");
                        arrayProduc[i].CodigoBarra = this.radGridView1.Rows[t].Cells[0].Value + "";
                        arrayProduc[i].Nombre = this.radGridView1.Rows[t].Cells[1].Value + "";
                    }
                    //inventario invet = new inventario();
                    //invet.Producto = arrayProduc
                    inventar[t] = new inventario();
                    inventar[t].Producto = arrayProduc;
                    //               precio preci = new precio();
                    //               preci.Monto = System.Convert.ToDouble(this.radGridView1.Rows[t].Cells[2].Value);
                    //               invet.Costo = System.Convert.ToDouble(this.radGridView1.Rows[t].Cells[2].Value);
                    inventar[t].Costo = System.Convert.ToDouble(this.radGridView1.Rows[t].Cells[2].Value);


                    fila = new rowGridView[cantidadTiposPrecios];
                    for (int i = 0; i < cantidadTiposPrecios; i++)
                    {
                          fila[i] = new rowGridView();
                          fila[i].Cells0 = radGridView2.Rows[i].Cells[0].Value + "";
                    }




                    int numColumnas = this.radGridView1.Columns.Count;
                    for (int tr = 0; tr < numColumnas-4; tr++)
                    {
                        fila[tr].Cells1 = radGridView1.Rows[t].Cells[4+tr].Value + "";
                    //    f = f + System.Convert.ToInt32(this.radGridView1.Rows[t].Cells[4+tr].Value);
                    }
                    inventar[t].Filasprecios1 = fila;
                }
                compr.Productos = inventar;
                String fech = Convert.ToString(radDateTimePicker1.Value);

                compr.Fecha = radDateTimePicker1.Value;

                //            compr.Fecha = fech.Substring(0, 10);
                compr.calcularTotal();
                compr.registrarCompra();

                this.radGridView1.MasterTemplate.Rows.Clear();
                labelMsjExito.Text = "Venta registrada exitosamente.";

                //Limpiar los texbox.
                txtCosto.Text = "";
                radTextBox3.Text = "";
                //txtCantidad.Text = "";
                radTextBox1.Text = "";
                txtTotal.Text = "";
                radTextBox1.Focus();
                vistaCompra = compr.VistaCompra;

                vistaPreviaCompras vista = new vistaPreviaCompras(vistaCompra);
                vista.Show();
            }
            else {
                MessageBox.Show("Verifique que todos los campos obligatorios esten llenados.");
            }


        }
        int indexGlobal=0;
        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            indexGlobal = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (radGridView1.Rows.Count > 0)
            {
                radGridView1.Rows.RemoveAt(indexGlobal);
                calcularTotal();
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCosto.Text != "" && radTextBox1.Text != "" && radTextBox3.Text != "" )
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;
                return;
            }
        }
        rowGridView[] pr;
        int cantidadTiposPrecios=0;
        public void cargarPrecios() {
            radGridView2.Rows.Clear();
            inventario inv = new inventario();
            double cos = System.Convert.ToDouble(txtCosto.Text);
            inv.obtenerPrecio(cos);
            pr = inv.Filasprecios1;
            cantidadTiposPrecios = pr.Length;
//            MessageBox.Show("pr.Length -> "+pr.Length+ " uno dato: "+pr[0].Cells0);
            for(int i=0; i<pr.Length;i++){
             radGridView2.Rows.AddNew();
             int f = radGridView2.Rows.Count;
//             pr[i] = new rowGridView();
                 this.radGridView2.Rows[f - 1].Cells[0].Value = pr[i].Cells0;
                 this.radGridView2.Rows[f - 1].Cells[1].Value = pr[i].Cells1;
            }
            
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
         //   MessageBox.Show("fuera");
            if (txtCosto.Text != "" && radTextBox1.Text != "" && radTextBox3.Text != "")
            {

                btnAgregar.Enabled = true;
                cargarPrecios();
            }
            else
            {
           //     MessageBox.Show("adentro");
                btnAgregar.Enabled = false;
                radGridView2.Rows.Clear();
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
