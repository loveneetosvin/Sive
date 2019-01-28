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
    public partial class registrarVenta2 : Telerik.WinControls.UI.RadForm
    {
        public registrarVenta2()
        {
            InitializeComponent();
            cargarCombox();
            cargarCombox2();
            btnAgregar.Enabled = false;
            this.radGridView1.Columns[4].IsVisible = false;
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Visible = false;
            Controls.AddRange(new Control[] { dateTimePicker1 });
            // MessageBox.Show(dateTimePicker1.Value.ToString());
            radDateTimePicker1.Value = dateTimePicker1.Value;
            labelMsjExito.Text = "";
            this.groupBox1.Visible = true;
            this.radPanel1.Visible = false;
            radPanel2.Visible = false;
        }

        public void calcularTotal()
        {
            double cots;
            double sumTotal = 0;
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                cots = System.Convert.ToDouble(this.radGridView1.Rows[i].Cells[3].Value);
                sumTotal = sumTotal + cots;
            }
            txtTotal.Text = System.Convert.ToString(sumTotal);
            labelMsjExito.Text = "";
        }
        public void calcularTotal2()
        {
            double cots;
            double sumTotal = 0;
            for (int i = 0; i < radGridView3.Rows.Count; i++)
            {
                cots = System.Convert.ToDouble(this.radGridView3.Rows[i].Cells[3].Value);
                sumTotal = sumTotal + cots;
            }
            radTextBox2.Text = System.Convert.ToString(sumTotal);


            //{
            //    double calIva;

            //}









        }
        public void cargarCombox()
        {
            //this.radGridView1.MasterTemplate.Rows.Clear();
            //Lineas de codigos en comun para todos los metodos.
            List<Item> lista = new List<Item>();

            lista.Add(new Item("Borrador", 1));
            lista.Add(new Item("Factura", 2));
            

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
        double costoProductoTemporal;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.radGridView2.MasterTemplate.Rows.Clear();
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "inventario";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoBarra", radTextBox1.Text);
            crit.Add("correlativo", txtCorrelativo.Text);

            reg.Add("CodigoBarra", "CodigoBarra");
            reg.Add("Correlativo", "Correlativo");
            reg.Add("Gravado", "Gravado");
            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            producto pro = new producto("", "");
            if (tab.Rows.Count > 0)
            {
                DataRow row = tab.Rows[0];

                Hashtable crity = new Hashtable();
                Hashtable regy = new Hashtable();
                //Lineas con detalles especificos por metodo.
                //  MessageBox.Show(" Codigo Barra:  "+row["CodigoBarra"].ToString() + "");

                crity.Add("CodigoBarra", row["CodigoBarra"].ToString());

                regy.Add("CodigoBarra", "CodigoBarra");
                regy.Add("nombre", "nombre");

                costoProductoTemporal = System.Convert.ToDouble(row["Gravado"]);
                DataTable tabr = new DataTable();
                tabr = opciones.BuscarRegistro("productos", crity, regy);

                DataRow rowre = tabr.Rows[0];
                pro = new producto(rowre["CodigoBarra"].ToString(), rowre["nombre"].ToString());
                radTextBox3.Text = pro.Nombre;
            }
            else
            {
                MessageBox.Show("No hay producto con ese correlativo y codigo de Barra");
            }

            //---------------------------------------------

            Hashtable critt = new Hashtable();
            Hashtable regt = new Hashtable();
            //Lineas con detalles especificos por metodo.
            critt.Add("CodigoBarra", radTextBox1.Text);
            critt.Add("correlativo", txtCorrelativo.Text);

            regt.Add("CodigoBarra", "CodigoBarra");
            regt.Add("Correlativo", "Correlativo");
            regt.Add("Gravado", "Gravado");
            regt.Add("TipoPrecio", "TipoPrecio");


            DataTable tabt = new DataTable();
            tabt = opciones.BuscarRegistro("precios", critt, regt);
            // MessageBox.Show("fuera DEL TIPO DE PRECIO, tamaño de la tabla: "+tabt.Rows.Count);
            for (int y = 0; y < tabt.Rows.Count; y++)
            {
                //     MessageBox.Show("DENTRO DEL TIPO DE PRECIO");
                DataRow rowt = tabt.Rows[y];
                radGridView2.Rows.AddNew();
                int f = radGridView2.Rows.Count;
                this.radGridView2.Rows[f - 1].Cells[0].Value = rowt["TipoPrecio"];
                this.radGridView2.Rows[f - 1].Cells[1].Value = Decimal.Round(System.Convert.ToDecimal(rowt["Gravado"]), 2);

            }



            //---------------------------------------------
        }
        int indexGlobal2 = 0;
        String precioSubtotal = "";
        private void radGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            btnAgregar.Enabled = true;
            indexGlobal2 = System.Convert.ToInt32(radGridView2.MasterGridViewInfo.CurrentIndex.ToString());
            txtPrecio.Text = radGridView2.Rows[indexGlobal2].Cells[1].Value.ToString();

            if (radDropDownList1.SelectedItem.Value + "" == "1")
            {
                Decimal[] valores = new Decimal[radGridView2.Rows.Count];
                for (int h = 0; h < radGridView2.Rows.Count; h++)
                {
                    valores[h] = new Decimal();
                    valores[h] = System.Convert.ToDecimal(radGridView2.Rows[h].Cells[1].Value);
                }

                Decimal menor = decimal.MaxValue;
                Decimal mayor = decimal.MinValue;
                for (int i = 0; i < valores.Length; i++)
                {
                    if (valores[i] < menor) menor = valores[i];
                    if (valores[i] > mayor) mayor = valores[i];
                }
                precioSubtotal = "" + menor;
            }
            else
            {
                precioSubtotal = "" + txtPrecio.Text;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //  for(int i=0; i<(System.Convert.ToInt32(txtCantidad.Text)); i++){
            radGridView1.Rows.AddNew();
            int f = radGridView1.Rows.Count;
            this.radGridView1.Rows[f - 1].Cells[0].Value = radTextBox1.Text;
            this.radGridView1.Rows[f - 1].Cells[1].Value = radTextBox3.Text;
            //Subtotal
            this.radGridView1.Rows[f - 1].Cells[2].Value = precioSubtotal;
            //
            this.radGridView1.Rows[f - 1].Cells[3].Value = txtPrecio.Text;
            this.radGridView1.Rows[f - 1].Cells[4].Value = costoProductoTemporal;
            this.radGridView1.Rows[f - 1].Cells[5].Value = txtCorrelativo.Text;
            calcularTotal();
        }
        int indexGlobal = 0;
        int indexGlobal20 = 0;
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (radGridView1.Rows.Count > 0)
            {
                radGridView1.Rows.RemoveAt(indexGlobal);
                calcularTotal();
            }
        }

        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            indexGlobal = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
        }

        public Boolean validar()
        {
            if (txtPrecio.Text != "" && radTextBox1.Text != "" && radTextBox3.Text != "" && txtCorrelativo.Text != "" && (radGridView1.Rows.Count) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        rowGridView[] GridView;
        public void llenarRadGridView3()
        {
            this.radGridView3.MasterTemplate.Rows.Clear();
            GridView = new rowGridView[radGridView1.Rows.Count];
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                radGridView3.Rows.AddNew();
                int f = radGridView3.Rows.Count;
                GridView[f - 1] = new rowGridView();
                GridView[f - 1].Cells0 = this.radGridView1.Rows[f - 1].Cells[0].Value + "";
                this.radGridView3.Rows[f - 1].Cells[0].Value = this.radGridView1.Rows[f - 1].Cells[0].Value;

                GridView[f - 1].Cells1 = this.radGridView1.Rows[f - 1].Cells[1].Value + "";
                this.radGridView3.Rows[f - 1].Cells[1].Value = this.radGridView1.Rows[f - 1].Cells[1].Value;
                //Subtotal
                GridView[f - 1].Cells2 = this.radGridView1.Rows[f - 1].Cells[3].Value + "";
                this.radGridView3.Rows[f - 1].Cells[2].Value = this.radGridView1.Rows[f - 1].Cells[2].Value;
                //
                GridView[f - 1].Cells3 = this.radGridView1.Rows[f - 1].Cells[2].Value + "";
                this.radGridView3.Rows[f - 1].Cells[3].Value = this.radGridView1.Rows[f - 1].Cells[3].Value;
                GridView[f - 1].Cells24 = this.radGridView1.Rows[f - 1].Cells[4].Value + "";
                this.radGridView3.Rows[f - 1].Cells[4].Value = this.radGridView1.Rows[f - 1].Cells[4].Value;
                GridView[f - 1].Cells25 = this.radGridView1.Rows[f - 1].Cells[5].Value + "";
                this.radGridView3.Rows[f - 1].Cells[5].Value = this.radGridView1.Rows[f - 1].Cells[5].Value;
                calcularTotal2();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            llenarRadGridView3();

            this.groupBox1.Visible = false;
            this.radPanel1.Visible = true;

            //··············


        }

        private void txtCorrelativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;
                return;
            }
        }

        private void radTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (radGridView3.Rows.Count > 0)
            {
                radGridView3.Rows.RemoveAt(indexGlobal20);
                calcularTotal2();
            }
        }


        public void atrasPanel2()
        {
            this.radGridView1.MasterTemplate.Rows.Clear();
            for (int i = 0; i < radGridView3.Rows.Count; i++)
            {

                radGridView1.Rows.AddNew();
                int f = radGridView1.Rows.Count;
                this.radGridView1.Rows[f - 1].Cells[0].Value = this.radGridView3.Rows[f - 1].Cells[0].Value;
                this.radGridView1.Rows[f - 1].Cells[1].Value = this.radGridView3.Rows[f - 1].Cells[1].Value;
                //Subtotal
                this.radGridView1.Rows[f - 1].Cells[2].Value = this.radGridView3.Rows[f - 1].Cells[2].Value;
                //
                this.radGridView1.Rows[f - 1].Cells[3].Value = this.radGridView3.Rows[f - 1].Cells[3].Value;
                this.radGridView1.Rows[f - 1].Cells[4].Value = this.radGridView3.Rows[f - 1].Cells[4].Value;
                this.radGridView1.Rows[f - 1].Cells[5].Value = this.radGridView3.Rows[f - 1].Cells[5].Value;
                calcularTotal();
            }
        }
        private void radButton4_Click(object sender, EventArgs e)
        {
            atrasPanel2();
            this.radPanel1.Visible = false;
            this.groupBox1.Visible = true;
        }
        public void registrar()
        {
            if (validar())
            {
                sucursal[] arraySucursales = new sucursal[1];
                arraySucursales[0] = new sucursal(radDropDownList2.SelectedItem.Value.ToString(), radDropDownList2.SelectedItem.DisplayValue.ToString());

                ventas vent = new ventas();
                precio pre = new precio();
                inventario inven = new inventario();
                producto[] pro = new producto[radGridView3.Rows.Count];
                vent.asignarCantidad(radGridView3.Rows.Count);
                for (int t = 0; t < radGridView3.Rows.Count; t++)
                {
                    //  MessageBox.Show("valor de t = "+t);
                    pro[t] = new producto(radGridView3.Rows[t].Cells[0].Value.ToString(), radGridView3.Rows[t].Cells[2].Value.ToString());
                    inven.Correlativo = System.Convert.ToInt32(radGridView3.Rows[t].Cells[5].Value.ToString());

                    pre.Monto = System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString());
                    inven.Precios = pre;
                    inven.Costo = System.Convert.ToDouble(radGridView3.Rows[t].Cells[4].Value);
                    inven.Producto = pro;

                    vent.agregarProducto(inven, System.Convert.ToDouble(radGridView3.Rows[t].Cells[2].Value.ToString()));
                    //                MessageBox.Show("Precios: " + inven.Precios.Monto.ToString());
                }
                vent.Sucursales = arraySucursales;
                String fech = Convert.ToString(radDateTimePicker1.Value);

                vent.Fecha = radDateTimePicker1.Value;
                //vent.Comentario = txtComentario.Text;
                vent.TipoVenta = radDropDownList1.SelectedItem.DisplayValue.ToString();
                vent.calcularTotal();
                vent.registrarVenta();
                this.radGridView2.MasterTemplate.Rows.Clear();
                this.radGridView1.MasterTemplate.Rows.Clear();
                this.radGridView3.MasterTemplate.Rows.Clear();
                //                labelMsjExito.Text = "Venta registrada exitosamente.";

                //Limpiar los texbox.
                txtPrecio.Text = "";
                radTextBox3.Text = "";
                txtCorrelativo.Text = "";
                radTextBox1.Text = "";
                txtTotal.Text = "";
                radTextBox1.Focus();
                //            MessageBox.Show(inven.Precios.Monto.ToString());
                //            MessageBox.Show(inven.Producto[1].Nombre);
                //            MessageBox.Show(inven.Producto[2].Nombre);

                // inven.
            }
            else
            {
                MessageBox.Show("Verifique que todos los campos obligatorios esten llenados.");
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            int tipoVen = System.Convert.ToInt32(radDropDownList1.SelectedItem.Value.ToString());

            if (tipoVen == 1)
            {
                //               MessageBox.Show("Borrador");
                radPanel1.Visible = false;
                radPanel2.Visible = true;

                this.radGridView4.MasterTemplate.Rows.Clear();
                for (int i = 0; i < radGridView3.Rows.Count; i++)
                {
                    radGridView4.Rows.AddNew();
                    int f = radGridView4.Rows.Count;
                    this.radGridView4.Rows[f - 1].Cells[0].Value = this.radGridView3.Rows[f - 1].Cells[0].Value;
                    this.radGridView4.Rows[f - 1].Cells[1].Value = this.radGridView3.Rows[f - 1].Cells[1].Value;
                    //Subtotal
                    this.radGridView4.Rows[f - 1].Cells[2].Value = this.radGridView3.Rows[f - 1].Cells[4].Value;
                    //
                    this.radGridView4.Rows[f - 1].Cells[3].Value = this.radGridView3.Rows[f - 1].Cells[2].Value;
                    this.radGridView4.Rows[f - 1].Cells[4].Value = this.radGridView3.Rows[f - 1].Cells[3].Value;
                    this.radGridView4.Rows[f - 1].Cells[5].Value = this.radGridView3.Rows[f - 1].Cells[5].Value;
                    radTextBox4.Text = radTextBox2.Text;
                }


            }
            else if (tipoVen == 2)
            {
                atrasPanel2();
                llenarRadGridView3();
                String total = radTextBox2.Text;

                //**
                sucursal[] arraySucursales = new sucursal[1];
                arraySucursales[0] = new sucursal(radDropDownList2.SelectedItem.Value.ToString(), radDropDownList2.SelectedItem.DisplayValue.ToString());

                ventas vent = new ventas();
                precio pre = new precio();
                inventario inven = new inventario();
                producto[] pro = new producto[radGridView3.Rows.Count];
                vent.asignarCantidad(radGridView3.Rows.Count);
                for (int t = 0; t < radGridView3.Rows.Count; t++)
                {
                    //  MessageBox.Show("valor de t = "+t);
                    pro[t] = new producto(radGridView3.Rows[t].Cells[0].Value.ToString(), radGridView3.Rows[t].Cells[2].Value.ToString());
                    inven.Correlativo = System.Convert.ToInt32(radGridView3.Rows[t].Cells[5].Value.ToString());

                    pre.Monto = System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString());
                    inven.Precios = pre;
                    inven.Costo = System.Convert.ToDouble(radGridView3.Rows[t].Cells[4].Value);
                    inven.Producto = pro;



                    vent.agregarProducto(inven, System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString()));
                    //                MessageBox.Show("Precios: " + inven.Precios.Monto.ToString());
                }
                vent.Sucursales = arraySucursales;
                String fech = Convert.ToString(radDateTimePicker1.Value);

                vent.Fecha = radDateTimePicker1.Value;
                //vent.Comentario = txtComentario.Text;
                vent.TipoVenta = radDropDownList1.SelectedItem.DisplayValue.ToString();
                vent.calcularTotal();
                //**


                facturarVenta fac = new facturarVenta(GridView, total, vent);
                fac.Show();

                //               MessageBox.Show("Facturacion");
                //    registrar();

            }
            else
            {
                //               MessageBox.Show("Credito Fiscal");
            }



        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            radPanel1.Visible = true;
            radPanel2.Visible = false;

        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            registrar();
            this.radPanel2.Visible = false;
            this.groupBox1.Visible = true;
        }

        private void radGridView3_Click(object sender, EventArgs e)
        {

        }

        private void registrarVenta2_Load(object sender, EventArgs e)
        {

        }
    }
}


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using Telerik.WinControls;

//namespace Siidform
//{
//    public partial class registrarVenta2 : Telerik.WinControls.UI.RadForm
//    {
//        public registrarVenta2()
//        {
//            InitializeComponent();
//            cargarCombox();
//            cargarCombox2();
//            btnAgregar.Enabled = false;
//            this.radGridView1.Columns[4].IsVisible = false;
//            DateTimePicker dateTimePicker1 = new DateTimePicker();
//            dateTimePicker1.Visible = false;
//            Controls.AddRange(new Control[] { dateTimePicker1 });
//           // MessageBox.Show(dateTimePicker1.Value.ToString());
//            radDateTimePicker1.Value = dateTimePicker1.Value;
//            labelMsjExito.Text = "";
//            this.groupBox1.Visible = true;
//            this.radPanel1.Visible = false;
//            radPanel2.Visible = false;
//        }

//        public void calcularTotal()
//        {
//            double cots;
//            double sumTotal = 0;
//            for (int i = 0; i < radGridView1.Rows.Count; i++)
//            {
//                cots = System.Convert.ToDouble(this.radGridView1.Rows[i].Cells[3].Value);
//                sumTotal = sumTotal + cots;
//            }
//            txtTotal.Text = System.Convert.ToString(sumTotal);
//            labelMsjExito.Text = "";
//        }
//        public void calcularTotal2()
//        {
//            double cots;
//            double sumTotal = 0;
//            for (int i = 0; i < radGridView3.Rows.Count; i++)
//            {
//                cots = System.Convert.ToDouble(this.radGridView3.Rows[i].Cells[3].Value);
//                sumTotal = sumTotal + cots;
//            }
//            radTextBox2.Text = System.Convert.ToString(sumTotal);


//            //{
//            //    double calIva;

//            //}









//        }
//        public void cargarCombox()
//        {
//            //this.radGridView1.MasterTemplate.Rows.Clear();
//            //Lineas de codigos en comun para todos los metodos.
//            List<Item> lista = new List<Item>();

//                lista.Add(new Item("Borrador", 1));
//                lista.Add(new Item("Factura", 2));
//                lista.Add(new Item("Crédito Fiscal", 3));

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
//            radDropDownList2.DisplayMember = "Name";
//            radDropDownList2.ValueMember = "Value";
//            radDropDownList2.DataSource = lista;
//        }
//        double costoProductoTemporal;
//        private void btnBuscar_Click(object sender, EventArgs e)
//        {
//            this.radGridView2.MasterTemplate.Rows.Clear();
//            opcionesdb opciones = new opcionesdb();
//            String NomTabla = "inventario";
//            Hashtable crit = new Hashtable();
//            Hashtable reg = new Hashtable();
//            //Lineas con detalles especificos por metodo.
//            crit.Add("CodigoBarra", radTextBox1.Text);
//            crit.Add("correlativo", txtCorrelativo.Text);

//            reg.Add("CodigoBarra", "CodigoBarra");
//            reg.Add("Correlativo", "Correlativo");
//            reg.Add("Gravado", "Gravado");
//            DataTable tab = new DataTable();
//            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
//                producto pro = new producto("", "");
//                if (tab.Rows.Count > 0)
//                {
//                    DataRow row = tab.Rows[0];

//                    Hashtable crity = new Hashtable();
//                    Hashtable regy = new Hashtable();
//                    //Lineas con detalles especificos por metodo.
//                  //  MessageBox.Show(" Codigo Barra:  "+row["CodigoBarra"].ToString() + "");

//                    crity.Add("CodigoBarra", row["CodigoBarra"].ToString());

//                    regy.Add("CodigoBarra", "CodigoBarra");
//                    regy.Add("nombre", "nombre");

//                    costoProductoTemporal = System.Convert.ToDouble(row["Gravado"]);
//                    DataTable tabr = new DataTable();
//                    tabr = opciones.BuscarRegistro("productos", crity, regy);

//                    DataRow rowre = tabr.Rows[0];
//                    pro = new producto(rowre["CodigoBarra"].ToString(), rowre["nombre"].ToString());
//                    radTextBox3.Text = pro.Nombre;
//                }
//                else {
//                    MessageBox.Show("No hay producto con ese correlativo y codigo de Barra");
//                }

//            //---------------------------------------------
                    
//                    Hashtable critt = new Hashtable();
//                    Hashtable regt = new Hashtable();
//                    //Lineas con detalles especificos por metodo.
//                    critt.Add("CodigoBarra", radTextBox1.Text);
//                    critt.Add("correlativo", txtCorrelativo.Text);

//                    regt.Add("CodigoBarra", "CodigoBarra");
//                    regt.Add("Correlativo", "Correlativo");
//                    regt.Add("Gravado", "Gravado");
//                    regt.Add("TipoPrecio", "TipoPrecio");


//                    DataTable tabt = new DataTable();
//                    tabt = opciones.BuscarRegistro("precios", critt, regt);
//                   // MessageBox.Show("fuera DEL TIPO DE PRECIO, tamaño de la tabla: "+tabt.Rows.Count);
//                    for (int y = 0; y < tabt.Rows.Count; y++ )
//                    {
//                   //     MessageBox.Show("DENTRO DEL TIPO DE PRECIO");
//                        DataRow rowt = tabt.Rows[y];
//                        radGridView2.Rows.AddNew();
//                        int f = radGridView2.Rows.Count;
//                        this.radGridView2.Rows[f - 1].Cells[0].Value = rowt["TipoPrecio"];
//                        this.radGridView2.Rows[f - 1].Cells[1].Value =Decimal.Round(System.Convert.ToDecimal( rowt["Gravado"]),2);

//                    }

                    
                    
//            //---------------------------------------------
//        }
//        int indexGlobal2 = 0;
//        String precioSubtotal = "";
//        private void radGridView2_MouseClick(object sender, MouseEventArgs e)
//        {
//            btnAgregar.Enabled = true;
//            indexGlobal2 = System.Convert.ToInt32(radGridView2.MasterGridViewInfo.CurrentIndex.ToString());
//            txtPrecio.Text = radGridView2.Rows[indexGlobal2].Cells[1].Value.ToString();
//            precioSubtotal = "" + txtPrecio.Text;
//        }

//        private void btnAgregar_Click(object sender, EventArgs e)
//        {
//            //  for(int i=0; i<(System.Convert.ToInt32(txtCantidad.Text)); i++){
//            radGridView1.Rows.AddNew();
//            int f = radGridView1.Rows.Count;
//            this.radGridView1.Rows[f - 1].Cells[0].Value = radTextBox1.Text;
//            this.radGridView1.Rows[f - 1].Cells[1].Value = radTextBox3.Text;
//            //Subtotal
//            this.radGridView1.Rows[f - 1].Cells[2].Value = precioSubtotal;
//            //
//            this.radGridView1.Rows[f - 1].Cells[3].Value = txtPrecio.Text;
//            this.radGridView1.Rows[f - 1].Cells[4].Value = costoProductoTemporal;
//            this.radGridView1.Rows[f - 1].Cells[5].Value = txtCorrelativo.Text;
//            calcularTotal();
//        }
//        int indexGlobal=0;
//        int indexGlobal20 = 0;
//        private void btnRemover_Click(object sender, EventArgs e)
//        {
//            if (radGridView1.Rows.Count>0)
//            {
//                radGridView1.Rows.RemoveAt(indexGlobal);
//                calcularTotal();
//            }
//        }

//        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
//        {
//            indexGlobal = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
//        }

//        public Boolean validar() {
//            if (txtPrecio.Text != "" && radTextBox1.Text != "" && radTextBox3.Text != "" && txtCorrelativo.Text != "" && (radGridView1.Rows.Count) > 0)
//            {
//                return true;
//            }else{
//                return false;
//            }
//        }

//        rowGridView[] GridView; 
//        public void llenarRadGridView3() {
//            this.radGridView3.MasterTemplate.Rows.Clear();
//            GridView = new rowGridView[radGridView1.Rows.Count];
//            for (int i = 0; i < radGridView1.Rows.Count; i++)
//            {
//                radGridView3.Rows.AddNew();
//                int f = radGridView3.Rows.Count;
//                GridView[f - 1] = new rowGridView();
//                GridView[f - 1].Cells0 = this.radGridView1.Rows[f - 1].Cells[0].Value+"";
//                this.radGridView3.Rows[f - 1].Cells[0].Value = this.radGridView1.Rows[f - 1].Cells[0].Value;

//                GridView[f - 1].Cells1 = this.radGridView1.Rows[f - 1].Cells[1].Value + "";
//                this.radGridView3.Rows[f - 1].Cells[1].Value = this.radGridView1.Rows[f - 1].Cells[1].Value;
//                //Subtotal
//                GridView[f - 1].Cells2 = this.radGridView1.Rows[f - 1].Cells[3].Value + "";
//                this.radGridView3.Rows[f - 1].Cells[2].Value = this.radGridView1.Rows[f - 1].Cells[2].Value;
//                //
//                GridView[f - 1].Cells3 = this.radGridView1.Rows[f - 1].Cells[2].Value + "";
//                this.radGridView3.Rows[f - 1].Cells[3].Value = this.radGridView1.Rows[f - 1].Cells[3].Value;
//                GridView[f - 1].Cells24 = this.radGridView1.Rows[f - 1].Cells[4].Value + "";
//                this.radGridView3.Rows[f - 1].Cells[4].Value = this.radGridView1.Rows[f - 1].Cells[4].Value;
//                GridView[f - 1].Cells25 = this.radGridView1.Rows[f - 1].Cells[5].Value + "";
//                this.radGridView3.Rows[f - 1].Cells[5].Value = this.radGridView1.Rows[f - 1].Cells[5].Value;
//                calcularTotal2();
//            }
//        }

//        private void btnRegistrar_Click(object sender, EventArgs e)
//        {
//            llenarRadGridView3();

//            this.groupBox1.Visible = false;
//            this.radPanel1.Visible = true;

//            //··············
            
          
//        }

//        private void txtCorrelativo_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
//            {

//                e.Handled = true;
//                return;
//            }
//        }

//        private void radTextBox1_KeyPress(object sender, KeyPressEventArgs e)
//        {

//        }

//        private void radButton2_Click(object sender, EventArgs e)
//        {
//            if (radGridView3.Rows.Count > 0)
//            {
//                radGridView3.Rows.RemoveAt(indexGlobal20);
//                calcularTotal2();
//            }
//        }


//        public void atrasPanel2() {
//            this.radGridView1.MasterTemplate.Rows.Clear();
//            for (int i = 0; i < radGridView3.Rows.Count; i++)
//            {

//                radGridView1.Rows.AddNew();
//                int f = radGridView1.Rows.Count;
//                this.radGridView1.Rows[f - 1].Cells[0].Value = this.radGridView3.Rows[f - 1].Cells[0].Value;
//                this.radGridView1.Rows[f - 1].Cells[1].Value = this.radGridView3.Rows[f - 1].Cells[1].Value;
//                //Subtotal
//                this.radGridView1.Rows[f - 1].Cells[2].Value = this.radGridView3.Rows[f - 1].Cells[2].Value;
//                //
//                this.radGridView1.Rows[f - 1].Cells[3].Value = this.radGridView3.Rows[f - 1].Cells[3].Value;
//                this.radGridView1.Rows[f - 1].Cells[4].Value = this.radGridView3.Rows[f - 1].Cells[4].Value;
//                this.radGridView1.Rows[f - 1].Cells[5].Value = this.radGridView3.Rows[f - 1].Cells[5].Value;
//                calcularTotal();
//            }
//        }
//        private void radButton4_Click(object sender, EventArgs e)
//        {
//            atrasPanel2();
//            this.radPanel1.Visible = false;
//            this.groupBox1.Visible = true;
//        }
//        public void registrar() {
//            if (validar())
//            {
//                sucursal[] arraySucursales = new sucursal[1];
//                arraySucursales[0] = new sucursal(radDropDownList2.SelectedItem.Value.ToString(), radDropDownList2.SelectedItem.DisplayValue.ToString());

//                ventas vent = new ventas();
//                precio pre = new precio();
//                inventario inven = new inventario();
//                producto[] pro = new producto[radGridView3.Rows.Count];
//                vent.asignarCantidad(radGridView3.Rows.Count);
//                for (int t = 0; t < radGridView3.Rows.Count; t++)
//                {
//                    //  MessageBox.Show("valor de t = "+t);
//                    pro[t] = new producto(radGridView3.Rows[t].Cells[0].Value.ToString(), radGridView3.Rows[t].Cells[2].Value.ToString());
//                    inven.Correlativo = System.Convert.ToInt32(radGridView3.Rows[t].Cells[5].Value.ToString());

//                    pre.Monto = System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString());
//                    inven.Precios = pre;
//                    inven.Costo = System.Convert.ToDouble(radGridView3.Rows[t].Cells[4].Value);
//                    inven.Producto = pro;
//                    vent.agregarProducto(inven, System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString()));
//                    //                MessageBox.Show("Precios: " + inven.Precios.Monto.ToString());
//                }
//                vent.Sucursales = arraySucursales;
//                String fech = Convert.ToString(radDateTimePicker1.Value);

//                vent.Fecha = radDateTimePicker1.Value;
//                //vent.Comentario = txtComentario.Text;
//                vent.TipoVenta = radDropDownList1.SelectedItem.DisplayValue.ToString();
//                vent.calcularTotal();
//                vent.registrarVenta();
//                this.radGridView2.MasterTemplate.Rows.Clear();
//                this.radGridView1.MasterTemplate.Rows.Clear();
//                this.radGridView3.MasterTemplate.Rows.Clear();
//                //                labelMsjExito.Text = "Venta registrada exitosamente.";

//                //Limpiar los texbox.
//                txtPrecio.Text = "";
//                radTextBox3.Text = "";
//                txtCorrelativo.Text = "";
//                radTextBox1.Text = "";
//                txtTotal.Text = "";
//                radTextBox1.Focus();
//                //            MessageBox.Show(inven.Precios.Monto.ToString());
//                //            MessageBox.Show(inven.Producto[1].Nombre);
//                //            MessageBox.Show(inven.Producto[2].Nombre);

//                // inven.
//            }
//            else
//            {
//                MessageBox.Show("Verifique que todos los campos obligatorios esten llenados.");
//            }
//        }

//        private void radButton3_Click(object sender, EventArgs e)
//        {
//            int tipoVen = System.Convert.ToInt32(radDropDownList1.SelectedItem.Value.ToString());

//            if(tipoVen == 1){
// //               MessageBox.Show("Borrador");
//                radPanel1.Visible = false;
//                radPanel2.Visible = true;

//                this.radGridView4.MasterTemplate.Rows.Clear();
//                for (int i = 0; i < radGridView3.Rows.Count; i++)
//                {
//                    radGridView4.Rows.AddNew();
//                    int f = radGridView4.Rows.Count;
//                    this.radGridView4.Rows[f - 1].Cells[0].Value = this.radGridView3.Rows[f - 1].Cells[0].Value;
//                    this.radGridView4.Rows[f - 1].Cells[1].Value = this.radGridView3.Rows[f - 1].Cells[1].Value;
//                    //Subtotal
//                    this.radGridView4.Rows[f - 1].Cells[2].Value = this.radGridView3.Rows[f - 1].Cells[4].Value;
//                    //
//                    this.radGridView4.Rows[f - 1].Cells[3].Value = this.radGridView3.Rows[f - 1].Cells[2].Value;
//                    this.radGridView4.Rows[f - 1].Cells[4].Value = this.radGridView3.Rows[f - 1].Cells[3].Value;
//                    this.radGridView4.Rows[f - 1].Cells[5].Value = this.radGridView3.Rows[f - 1].Cells[5].Value;
//                    radTextBox4.Text = radTextBox2.Text;
//                }


//            }
//            else if (tipoVen == 2)
//            {
//                atrasPanel2();
//                llenarRadGridView3();
//                String total = radTextBox2.Text;

//                //**
//                sucursal[] arraySucursales = new sucursal[1];
//                arraySucursales[0] = new sucursal(radDropDownList2.SelectedItem.Value.ToString(), radDropDownList2.SelectedItem.DisplayValue.ToString());

//                ventas vent = new ventas();
//                precio pre = new precio();
//                inventario inven = new inventario();
//                producto[] pro = new producto[radGridView3.Rows.Count];
//                vent.asignarCantidad(radGridView3.Rows.Count);
//                for (int t = 0; t < radGridView3.Rows.Count; t++)
//                {
//                    //  MessageBox.Show("valor de t = "+t);
//                    pro[t] = new producto(radGridView3.Rows[t].Cells[0].Value.ToString(), radGridView3.Rows[t].Cells[2].Value.ToString());
//                    inven.Correlativo = System.Convert.ToInt32(radGridView3.Rows[t].Cells[5].Value.ToString());

//                    pre.Monto = System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString());
//                    inven.Precios = pre;
//                    inven.Costo = System.Convert.ToDouble(radGridView3.Rows[t].Cells[4].Value);
//                    inven.Producto = pro;
//                    vent.agregarProducto(inven, System.Convert.ToDouble(radGridView3.Rows[t].Cells[3].Value.ToString()));
//                    //                MessageBox.Show("Precios: " + inven.Precios.Monto.ToString());
//                }
//                vent.Sucursales = arraySucursales;
//                String fech = Convert.ToString(radDateTimePicker1.Value);

//                vent.Fecha = radDateTimePicker1.Value;
//                //vent.Comentario = txtComentario.Text;
//                vent.TipoVenta = radDropDownList1.SelectedItem.DisplayValue.ToString();
//                vent.calcularTotal();
//                //**


//                facturarVenta fac = new facturarVenta(GridView, total, vent);
//                fac.Show();

// //               MessageBox.Show("Facturacion");
//            //    registrar();
            
//            }
//            else {
// //               MessageBox.Show("Credito Fiscal");
//            }

            
            
//        }

//        private void radButton6_Click(object sender, EventArgs e)
//        {
//            radPanel1.Visible = true;
//            radPanel2.Visible = false;

//        }

//        private void radButton5_Click(object sender, EventArgs e)
//        {
//            registrar();
//        }
//    }
//}
