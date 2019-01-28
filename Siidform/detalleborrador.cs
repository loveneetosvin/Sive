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
    public partial class detalleborrador : Telerik.WinControls.UI.RadForm
    { 
        public String fecha1;
        public String sucursal1;

        public String Sucursal1
        {
            get { return sucursal1; }
            set { sucursal1 = value; }
        }
        public double utilidad;

        CalcularImpuestos imp = new CalcularImpuestos();
        facturaborrador fact = new facturaborrador();
        ventas ven = new ventas();
        
        public detalleborrador(string sucursal)
        {
            InitializeComponent();
            sucursal1 = sucursal;
           
        }

        public void llenarDetalle(DataTable Detalle)
        {
            
            DataRow row;
            for (int f = 0; f < Detalle.Rows.Count; f++)
            {
                row = Detalle.Rows[f];
                radGridView4.Rows.AddNew();
                int x = radGridView4.Rows.Count;
                this.radGridView4.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
                this.radGridView4.Rows[x - 1].Cells[1].Value = row["Correlativo"].ToString();
                this.radGridView4.Rows[x - 1].Cells[2].Value = row["PrecioReal"].ToString();
                this.radGridView4.Rows[x - 1].Cells[3].Value = row["PrecioVenta"].ToString();

                           }
            this.CalcularTotal();
            
           

        }

        public void CalcularTotal()
        {
            int filas = radGridView4.Rows.Count;
            
            double suma = 0;

            for (int f = 0; f < filas; f++)
            {
                suma = suma + Convert.ToDouble(radGridView4.Rows[f].Cells[3].Value.ToString());

            }
            radTextBox2.Text = Convert.ToString(suma);
        }

        public double CalcularTotalReal() {
            int filas = radGridView4.Rows.Count;

            double suma = 0;

            for (int f = 0; f < filas; f++)
            {
                suma = suma + Convert.ToDouble(radGridView4.Rows[f].Cells[2].Value.ToString());

            }
            return suma;
        }

        public void calcularutilidad()
        {
            double totalVenta = 0.0;
          double  totalVentaColumnaMenorPrecio = 0.0;
            for (int j = 0; j < radGridView4.Rows.Count; j++)
            {
                totalVenta = totalVenta + Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString());
                totalVentaColumnaMenorPrecio = totalVentaColumnaMenorPrecio + Convert.ToDouble(radGridView4.Rows[j].Cells[2].Value.ToString());
                utilidad = utilidad + (Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString()) - Convert.ToDouble(radGridView4.Rows[j].Cells[2].Value.ToString()));
            }

        }

        public void HabilitarFact()
        {
            this.radButton1.Visible = true;
            this.txtComentarios.Visible = true;
            this.radLabel11.Visible = true;
        }

        public void DesabilitarFact()
        {
            this.radButton1.Visible = false;
            this.txtComentarios.Visible = false;
            this.radLabel11.Visible = false;
        }

        public Double IvATotal()
        {
            imp.ObtenerParametros();
            
            Double IVATotal = 0;
            for (int j = 0; j < radGridView4.Rows.Count; j++)
            {
              IVATotal = IVATotal + imp.CalcularIVA(Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString()));

            //  MessageBox.Show("Iva: " + Convert.ToString(IVATotal));
            }

            return IVATotal;
        }
        public Double PagoACTotal()
        {
            Double PagoACTotal = 0.0;
            for (int j = 0; j < radGridView4.Rows.Count; j++)
            {
                PagoACTotal = PagoACTotal + Math.Round((imp.CalcularPagoAcuenta(Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString()))), 2 );
             //   MessageBox.Show("PAGO A Cuenta: "+Convert.ToString(PagoACTotal));
            }

            return PagoACTotal;
        }
        public Double RentaTotal()
        {
             Double RentaCalculada = 0.0;
            for (int j = 0; j < radGridView4.Rows.Count; j++)
            {
                RentaCalculada = RentaCalculada + imp.CalcularRentaCalculada(imp.CalcularUtilidadBruta(Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString()), Convert.ToDouble(radGridView4.Rows[j].Cells[2].Value.ToString())));
             //   MessageBox.Show("Penta calculada: " + Convert.ToString(RentaCalculada));
            }
            return RentaCalculada;
        }

        public Double RentaFinal()
        {
            Double RentaFinal;
            RentaFinal = imp.CalcularRentaFinal(this.RentaTotal(), this.PagoACTotal());
          //  MessageBox.Show("Penta Total: " + Convert.ToString(RentaFinal));
            return RentaFinal;
        }

        public Double UtilidadBruta()
        {
            Double Uti = 0.0;
            for (int j = 0; j < radGridView4.Rows.Count; j++)
            {
                Uti = Uti + imp.CalcularUtilidadBruta(Convert.ToDouble(radGridView4.Rows[j].Cells[3].Value.ToString()), Convert.ToDouble(radGridView4.Rows[j].Cells[2].Value.ToString()));
            //     MessageBox.Show("Utilidad Bruta: " + Convert.ToString(Uti));
            }
       
            return Uti;
        }

        public Double UtilidadFinal()
        {
            Double UtiFina;
            UtiFina = imp.CalcularUtilidad(this.UtilidadBruta(), this.RentaFinal());
            return UtiFina;
        }
        public void Facturar()
        {
           // MessageBox.Show(sucursal1);
            ven.generarNumeroVentas();
            //lineas comun
            opcionesdb opcion = new opcionesdb();
            String NomTabla = "";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
          

            //Modificar Venta agregar nueva factura
            NomTabla = "Ventas";
            
            calcularutilidad();
            
         //   MessageBox.Show(Convert.ToString(ven.NVenta));
            crit.Add("TipoVenta", "FACTURA");
            crit.Add("Numero", Convert.ToString(ven.NVenta));
            crit.Add("TotalReal", Convert.ToString(CalcularTotalReal()).Replace(",", "."));
            crit.Add("TotalVenta", radTextBox2.Text.Replace(",", "."));
            crit.Add("Fecha", fact.pasarfecha());

            crit.Add("CodigoSucursal", sucursal1);
            crit.Add("Comentario", txtComentarios.Text);
            crit.Add("Gravado", Convert.ToString(CalcularTotalReal()));
            crit.Add("IVA", Convert.ToString(this.IvATotal()).Replace(",", "."));
            crit.Add("PagoACuenta", Convert.ToString(this.PagoACTotal()).Replace(",", "."));
            crit.Add("Renta", Convert.ToString(this.RentaFinal()).Replace(",", "."));

            crit.Add("Utilidad", Convert.ToString(this.UtilidadFinal()).Replace(",","."));

            // crit.Add();
            opcion.InsertarRegistro(NomTabla, crit);
        }

        public String ObtenerNventa()
        {
            String Nventa;
            opcionesdb opcion = new opcionesdb();
            String NomTabla2 = "Ventas";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();

            reg.Add("NVentas", "NVentas");
            crit.Add("Numero", Convert.ToString(ven.NVenta));

          DataTable tabla =  opcion.BuscarRegistro(NomTabla2, crit, reg);

          
            Nventa = tabla.Rows[0]["NVentas"].ToString();
          //  MessageBox.Show(Nventa);
            return Nventa;
        }

    public void ModificarDetalle(){
        opcionesdb opcion = new opcionesdb();
        
        Hashtable crit = new Hashtable();
        Hashtable reg = new Hashtable();
        ventas ven = new ventas();
            //Modificar Detalle Venta Actualizar los Productos
            //obtener correlativos
            
            
            int filas = radGridView4.Rows.Count;
            String corre;
            String barra;
            double precioR;
            double precioVenta;
            for (int f = 0; f < filas; f++)
            {
                String NomTabla2 = "DetalleVenta";
               
                barra = radGridView4.Rows[f].Cells[0].Value.ToString();
                corre = radGridView4.Rows[f].Cells[1].Value.ToString();
                precioR = Convert.ToDouble(radGridView4.Rows[f].Cells[2].Value.ToString());
                precioVenta = Convert.ToDouble(radGridView4.Rows[f].Cells[3].Value.ToString());
                  crit.Add("NVenta", this.ObtenerNventa());
                  crit.Add("CodigoBarra", barra);
                  crit.Add("Correlativo", corre);
                  crit.Add("PrecioReal", precioR.ToString().Replace(",", "."));
                  crit.Add("PrecioVenta", precioVenta.ToString().Replace(",", "."));
           
                //MessageBox.Show(barra + "   " + corre+precioR+precioVenta);
               
                               
                opcion.InsertarRegistro(NomTabla2, crit);
                
                reg.Clear();
                crit.Clear();
            }
        }
      
        public void EliminarBorrador(){
          //  MessageBox.Show(sucursal1);
            opcionesdb opcion = new opcionesdb();
            String NomTabla = "Ventas";
            Hashtable crit = new Hashtable();
            //Eliminar Registro de Ventas Borrador
            
            crit.Add("TipoVenta", "Borrador");
            crit.Add("CodigoSucursal", sucursal1);



            opcion.EliminarRegistro(NomTabla, crit);

        }

        public void limpiar()
        {
            MessageBox.Show("Facturas Borrador Facturadas¡¡¡¡¡ :)");
            radGridView4.Rows.Clear();
            DesabilitarFact();
            fact.limpiarfact();
            this.Close();
        }

        public void EliminarDetalleV()
        {
            
            opcionesdb opcion = new opcionesdb();
            String NomTabla = "DetalleVenta";
            Hashtable crit = new Hashtable();
            int filas = radGridView4.Rows.Count;
            String corre;
            String barra;
            
            //Eliminar Registro de Ventas Borrador
            
                for (int f = 0; f < filas; f++)
                {
                    barra = radGridView4.Rows[f].Cells[0].Value.ToString();
                    corre = radGridView4.Rows[f].Cells[1].Value.ToString();
                    crit.Add("CodigoBarra", barra);
                    crit.Add("Correlativo", corre);

                    opcion.EliminarRegistro(NomTabla, crit);
                    crit.Clear();
                }
        
            
        }
        private void detalleborrador_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(this.IvATotal()));
            //MessageBox.Show(Convert.ToString(this.PagoACTotal()));
            //MessageBox.Show(Convert.ToString(this.RentaTotal()));
            //MessageBox.Show(Convert.ToString(this.RentaFinal()));
            //MessageBox.Show(Convert.ToString(this.UtilidadBruta()));
            //MessageBox.Show(Convert.ToString(this.UtilidadFinal()));

            this.Facturar();
            this.ObtenerNventa();
            this.EliminarDetalleV();
            this.ModificarDetalle();
            this.EliminarBorrador();
            this.limpiar();

        }
    }
}
