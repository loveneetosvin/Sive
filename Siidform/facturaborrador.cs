using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections;

namespace Siidform
{
    public partial class facturaborrador : Telerik.WinControls.UI.RadForm
    {
        public facturaborrador()
        {
            InitializeComponent();
            //Caragar Fecha----------------------------------------
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Visible = false;
            Controls.AddRange(new Control[] { dateTimePicker1 });
            radDateTimePicker1.Value = dateTimePicker1.Value;
            //-------------------------------------------------
          
            this.CalcularTotal();
            this.cargarCombox2();
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
            listSucursal.DisplayMember = "Name";
            listSucursal.ValueMember = "Value";
            listSucursal.DataSource = lista;
            
        }

      

        public void cargarFacturasBorrador(String sucursal)
        {

            this.radGridView1.MasterTemplate.Rows.Clear();
            opcionesdb opcione = new opcionesdb();
            String NomTabla = "Ventas";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();

            //Lineas con detalles especificos por metodo.
            reg.Add("NVentas", "NVentas" );
            reg.Add("Fecha", "Fecha" );
            reg.Add("TotalReal", "TotalReal");

            crit.Add("TipoVenta", "Borrador");
            crit.Add("CodigoSucursal", sucursal);

            DataTable tabla = opcione.BuscarRegistro(NomTabla, crit, reg);


            DataRow row;
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView1.Rows.AddNew();
                int x = radGridView1.Rows.Count;
                this.radGridView1.Rows[x - 1].Cells[0].Value = row["Nventas"].ToString();
                this.radGridView1.Rows[x - 1].Cells[1].Value = row["Fecha"].ToString();
                this.radGridView1.Rows[x - 1].Cells[2].Value = row["TotalReal"].ToString();
            }
}


            public void MostrarDetalles(){
                if(radGridView1.Rows.Count > 0){
                    detalleborrador detalle = new detalleborrador(listSucursal.SelectedValue.ToString());
                opcionesdb opcion = new opcionesdb();
                String NomTabla = "DetalleVenta";
                Hashtable crit = new Hashtable();
                Hashtable reg = new Hashtable();
                
                //Obtener Id de Venta
                int fila = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
                String id = radGridView1.Rows[fila].Cells[0].Value.ToString();
                //MessageBox.Show(id);

                //obtenerdetalle
                //Lineas con detalles especificos por metodo.
                reg.Add("CodigoBarra", "CodigoBarra");
                reg.Add("Correlativo", "Correlativo");
                reg.Add("PrecioReal", "PrecioReal");
                reg.Add("PrecioVenta", "PrecioVenta");

                crit.Add("NVenta", id);

                DataTable tabla = opcion.BuscarRegistro(NomTabla, crit, reg);
                detalle.DesabilitarFact();
                detalle.llenarDetalle(tabla);
                detalle.Show();
                    }
            }

            public void CalcularTotal()
            {
                int filas = radGridView1.Rows.Count;
                double numero = 0;
                double suma = 0;

                for (int f = 0; f < filas; f++)
                {
                    suma = suma + Convert.ToDouble(radGridView1.Rows[f].Cells[2].Value.ToString());

                }
                radTextBox1.Text = Convert.ToString(suma);
            }

            private void radButton3_Click(object sender, EventArgs e)
            {
                this.MostrarDetalles();
                //this.ObtenerTodos();
            }


            //private void radButton1_Click(object sender, EventArgs e)
            //{
            //    //Obtener datos de fila seleccionada
            //    int fila = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
            //    radGridView3.Rows.Add();

               
            //    //Agregar Datos de Fila seleccionada
            //}

            private void radButton1_Click_1(object sender, EventArgs e)
            {
                if (radGridView1.Rows.Count > 0)
                {
                    //Obtener datos de fila seleccionada
                    int fila = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());

                    //Agregar Datos de Fila seleccionada
                    radGridView3.Rows.Add(radGridView1.Rows[fila].Cells[0].Value.ToString(), radGridView1.Rows[fila].Cells[1].Value.ToString(), radGridView1.Rows[fila].Cells[2].Value.ToString());
                    radGridView1.Rows.RemoveAt(fila);
                    this.CalcularTotal();
                }
            }

            private void radButton2_Click(object sender, EventArgs e)
            {
                if (radGridView3.Rows.Count > 0) { 
                int fila = System.Convert.ToInt32(radGridView3.MasterGridViewInfo.CurrentIndex.ToString());
                
                radGridView1.Rows.Add(radGridView3.Rows[fila].Cells[0].Value.ToString(), radGridView3.Rows[fila].Cells[1].Value.ToString(), radGridView3.Rows[fila].Cells[2].Value.ToString());
                radGridView3.Rows.RemoveAt(fila);
                this.CalcularTotal();
                }
            }


            public void ObtenerTodos()
            {

                detalleborrador detalle = new detalleborrador(listSucursal.SelectedValue.ToString());
                int filas = radGridView3.Rows.Count;
                rowGridView grid = new rowGridView();
                DataTable todos = new DataTable();
                String ids;
                opcionesdb opcion = new opcionesdb();
                String NomTabla = "DetalleVenta";
                Hashtable crit = new Hashtable();
                Hashtable reg = new Hashtable();

                //Obtener Id de Venta
              //  int fila = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
              //  String id = radGridView1.Rows[fila].Cells[0].Value.ToString();
                //MessageBox.Show(id);

                //obtenerdetalle
                //Lineas con detalles especificos por metodo.
                reg.Add("CodigoBarra", "CodigoBarra");
                reg.Add("Correlativo", "Correlativo");
                reg.Add("PrecioReal", "PrecioReal");
                reg.Add("PrecioVenta", "PrecioVenta");

                for (int f = 0; f < filas; f++)
                {
                    ids = radGridView3.Rows[f].Cells[0].Value.ToString();
                    crit.Add("NVenta", ids);

                    DataTable tabla = opcion.BuscarRegistro(NomTabla, crit, reg);
                    todos = tabla.Clone();
                    for (int a = 0; a < tabla.Rows.Count; a++) { 
                        todos.ImportRow(tabla.Rows[a]);
                    
                    }
                   
                    
                    detalle.llenarDetalle(todos);
                    tabla.Clear();
                    crit.Clear();

                }

                detalle.HabilitarFact();
                detalle.Show();
            }
            public String pasarfecha()
            {
                String fecha1 = Convert.ToString(radDateTimePicker1.Value);
                return fecha1;
            }
            public String pasarSucursal()
            {
                String sucursal1 = listSucursal.Text;
                return sucursal1;
            }
            public String pasarSucursalid()
            {
                detalleborrador de = new detalleborrador(listSucursal.SelectedValue.ToString());
                 MessageBox.Show(listSucursal.SelectedValue.ToString());
                String sucursal1 = listSucursal.SelectedValue.ToString();
                de.sucursal1 = sucursal1;
                 return sucursal1;
            }

            public List<String> PasarNventasBorrador()
            {
                List<String> Nventas = new List<string>();
                int filas = radGridView3.Rows.Count;
                String ids;
                for (int f = 0; f < filas; f++)
                {

                    ids = radGridView3.Rows[f].Cells[0].Value.ToString();
                    Nventas.Add(ids);

                }
                //  MessageBox.Show(Convert.ToString(Nventas.Count));
                return Nventas;
            }

            public void limpiarfact()
            {
                radGridView1.Rows.Clear();
                radGridView3.Rows.Clear();

            }

            private void radButton4_Click(object sender, EventArgs e)
            {
                if (radGridView3.Rows.Count > 0)
                {
                    this.PasarNventasBorrador();

                    this.ObtenerTodos();

                }
                this.limpiarfact();
            }

            private void radButton5_Click(object sender, EventArgs e)
            {
                
                this.cargarFacturasBorrador(listSucursal.SelectedItem.Value.ToString());
            }
        


    }
}
