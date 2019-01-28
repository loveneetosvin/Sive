using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siidform
{
    public class ventas
    {
        int nVenta;

        double utilidad;
        double Iva;
        double VentaGradava;
        double PagoCuenta;
        double renta;
        DateTime fecha;
        double totalVenta;
        double totalVentaColumnaMenorPrecio;
        sucursal[] sucursales;
        String comentario;
        detalleVenta[] producto;
        String tipoVenta;
        CalcularImpuestos impuestos = new CalcularImpuestos();

        public int NVenta
        {
            get { return nVenta; }
            set { nVenta = value; }
        }
        public String TipoVenta
        {
            get { return tipoVenta; }
            set { tipoVenta = value; }
        }

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public void generarNumeroVentas()
        {
            opcionesdb op = new opcionesdb();
            String NTabla = "Ventas";
            DataTable tab = new DataTable();
            tab = op.obtenerNVenta(NTabla, "Numero");
            DataRow row;

            if (tab.Rows.Count == 0)
            {
                NVenta = 0;
            }
            else
            {
                row = tab.Rows[0];
                NVenta = System.Convert.ToInt32(row["Numero"].ToString()) + 1;
            }
        }
        public bool validad()
        {
            return true;
        }

        public void calcularTotal()
        {

            impuestos.ObtenerParametros();
            
            totalVenta = 0.0;
            totalVentaColumnaMenorPrecio = 0.0;
            Iva = 0.0;
            VentaGradava=0;
            double TotalCompra = 0;
            double Brutautilidad = 0;
            double RentaCalculada=0;
             PagoCuenta= 0.0;
             renta=0.0;
            for (int j = 0; j < producto.Length; j++)
            {
                TotalCompra = (producto[j].Costo * impuestos.IVA) + producto[j].Costo;
                totalVenta = totalVenta + producto[j].PrecioVenta;
                totalVentaColumnaMenorPrecio = totalVentaColumnaMenorPrecio + producto[j].PrecioMenorVenta;
                
                VentaGradava = (totalVenta / 1.13);
                
               // Iva = (VentaGradava * 0.13);
               Iva = impuestos.CalcularIVA(VentaGradava);
              //  PagoCuenta = (VentaGradava * 0.0175);
                PagoCuenta = impuestos.CalcularPagoAcuenta(VentaGradava);
             //   Brutautilidad = (VentaGradava - producto[j].Costo);
                Brutautilidad = impuestos.CalcularUtilidadBruta(VentaGradava, producto[j].Costo);
             //   RentaCalculada = ( Brutautilidad* 0.10) ;
                RentaCalculada = impuestos.CalcularRentaCalculada(Brutautilidad);
            //    renta = (RentaCalculada - PagoCuenta);
                renta = impuestos.CalcularRentaFinal(RentaCalculada, PagoCuenta);
            //    utilidad = (Brutautilidad - renta);
                utilidad = impuestos.CalcularUtilidad(Brutautilidad, renta);
               
               
            }
            TotalVen = totalVentaColumnaMenorPrecio;
           
        }

        double totalVen = 0.0;

        public double TotalVen
        {
            get { return totalVen; }
            set { totalVen = value; }
        }
        public void registrarVenta()
        {
            opcionesdb op = new opcionesdb();

            String NTabla = "Ventas";

            generarNumeroVentas();
            //Insertar registro en la tabla de ventas.
            Hashtable crit = new Hashtable();
            crit.Add("TipoVenta", TipoVenta);
            crit.Add("Numero", NVenta);
            crit.Add("TotalReal", totalVenta.ToString().Replace(",", "."));
            crit.Add("TotalVenta", totalVen.ToString().Replace(",", "."));
            String fech = Convert.ToString(Fecha);
            crit.Add("Fecha", fech.Substring(0, 10));
            crit.Add("CodigoSucursal", sucursales[0].Codigosucursal);
            crit.Add("Comentario", Comentario);
            crit.Add("Gravado", VentaGradava.ToString().Replace(",", "."));
            crit.Add("IVA", Iva.ToString().Replace(",", "."));
            crit.Add("PagoACuenta", PagoCuenta.ToString().Replace(",", "."));
            crit.Add("Renta", renta.ToString().Replace(",", "."));
            crit.Add("Utilidad", utilidad.ToString().Replace(",", "."));
            op.InsertarRegistro("Ventas", crit);

            //Insetar registros en la tabla de detalle de venta.
            DataTable tab2 = new DataTable();
            tab2 = op.obtenerNVenta(NTabla, "NVentas");
            DataRow row2;
            int NumVentas;
            row2 = tab2.Rows[0];
            NumVentas = System.Convert.ToInt32(row2["NVentas"].ToString());

            for (int p = 0; p < producto.Length; p++)
            {
                producto[] prd = producto[p].Pro;
                Hashtable crits = new Hashtable();
                crits.Add("NVenta", NumVentas);
                crits.Add("CodigoBarra", prd[p].CodigoBarra);
                crits.Add("Correlativo", producto[p].Correlativo);
                crits.Add("PrecioReal", producto[p].Costo.ToString().Replace(",", "."));
                crits.Add("PrecioVenta", producto[p].PrecioVenta.ToString().Replace(",", "."));
                op.InsertarRegistro("DetalleVenta", crits);

                //Eliminamos en la tabla precio las tuplas de los productos con un codigo de barra espesifico y correlativo.
                producto[] prdR = producto[p].Pro;
                Hashtable critR = new Hashtable();
                critR.Add("CodigoBarra", prdR[p].CodigoBarra);
                critR.Add("Correlativo", producto[p].Correlativo);
                op.EliminarRegistro("Precios", critR);

                //Eliminamos en la tabla Inventario las tuplas de los productos con un codigo de barra espesifico y correlativo.
                producto[] prdRx = producto[p].Pro;
                Hashtable critRx = new Hashtable();
                critRx.Add("CodigoBarra", prdRx[p].CodigoBarra);
                critRx.Add("Correlativo", producto[p].Correlativo);
                op.EliminarRegistro("Inventario", critRx);

                //  MessageBox.Show("Codigo de Barra: " + prd[p].CodigoBarra + " " + prdR[p].CodigoBarra + " " + prdRx[p].CodigoBarra);

            }



        }

        int contador = 0;
        public void agregarProducto(inventario i, double precio)
        {
            //MessageBox.Show("Nuevamente Tamaño del vector detalleVenta: " + producto.Length);
            producto[contador] = new detalleVenta();
            producto[contador].Pro = i.Producto;
            producto[contador].PrecioVenta = i.Precios.Monto;
            producto[contador].Costo = i.Costo;
            producto[contador].Correlativo = i.Correlativo;
            producto[contador].PrecioMenorVenta = precio;
            contador = contador + 1;
        }
        public void asignarCantidad(int can)
        {
            producto = new detalleVenta[can];
            //MessageBox.Show("Tamaño del vector detalleVenta: " + producto.Length);
        }
        internal sucursal[] Sucursales
        {
            get { return sucursales; }
            set { sucursales = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Siidform
//{
//    public class ventas
//    {
//        int nVenta;

//        double utilidad;
//        DateTime fecha;
//        double totalVenta;
//        sucursal[] sucursales;
//        String comentario;
//        detalleVenta[] producto;
//        String tipoVenta;


//        public int NVenta
//        {
//            get { return nVenta; }
//            set { nVenta = value; }
//        }
//        public String TipoVenta
//        {
//            get { return tipoVenta; }
//            set { tipoVenta = value; }
//        }

//        public String Comentario
//        {
//            get { return comentario; }
//            set { comentario = value; }
//        }

//        public void generarNumeroVentas() {
//            opcionesdb op = new opcionesdb();
//            String NTabla = "Ventas";
//            DataTable tab = new DataTable();
//            tab = op.obtenerNVenta(NTabla, "Numero");
//            DataRow row;

//            if (tab.Rows.Count == 0)
//            {
//                NVenta = 0;
//            }
//            else
//            {
//                row = tab.Rows[0];
//                NVenta = System.Convert.ToInt32(row["Numero"].ToString()) + 1;
//            }
//        }
//        public bool validad() {
//            return true;
//        }

//        public void calcularTotal() {
////            MessageBox.Show("Valor del contador: "+contador);
//            totalVenta = 0.0;
//            for (int j = 0; j < producto.Length;j++ )
//            {
//                totalVenta = totalVenta + producto[j].PrecioVenta;
//                utilidad = utilidad + (producto[j].PrecioVenta - producto[j].Costo);
//            }
//        //    MessageBox.Show("Total de la Venta: "+totalVenta+ "    Utilidad: "+utilidad);
//        }


//        public void registrarVenta() {
//            opcionesdb op = new opcionesdb();

//            String NTabla = "Ventas";

//            generarNumeroVentas();
//            //Insertar registro en la tabla de ventas.
//            Hashtable crit = new Hashtable();
//            crit.Add("TipoVenta", TipoVenta);
//            crit.Add("Numero", NVenta);
//            crit.Add("TotalReal", totalVenta);
//            crit.Add("TotalVenta", totalVenta);
//            String fech = Convert.ToString(Fecha);
//            crit.Add("Fecha", fech.Substring(0, 10));
//            crit.Add("CodigoSucursal", sucursales[0].Codigosucursal);
//            crit.Add("Comentario", Comentario);
//            crit.Add("Gravado", totalVenta);
//            crit.Add("Utilidad", utilidad);
//            op.InsertarRegistro("Ventas", crit);
            
//            //Insetar registros en la tabla de detalle de venta.
//            DataTable tab2 = new DataTable();
//            tab2 = op.obtenerNVenta(NTabla, "NVentas");
//            DataRow row2;
//            int NumVentas;
//                row2 = tab2.Rows[0];
//                NumVentas = System.Convert.ToInt32(row2["NVentas"].ToString());

//            for (int p = 0; p < producto.Length;p++ )
//            {
//                producto[] prd = producto[p].Pro;
//                Hashtable crits = new Hashtable();
//                crits.Add("NVenta", NumVentas);
//                crits.Add("CodigoBarra", prd[p].CodigoBarra);
//                crits.Add("Correlativo", producto[p].Correlativo);
//                crits.Add("PrecioReal", producto[p].Costo);
//                crits.Add("PrecioVenta", producto[p].PrecioVenta);
//                op.InsertarRegistro("DetalleVenta", crits);

//                //Eliminamos en la tabla precio las tuplas de los productos con un codigo de barra espesifico y correlativo.
//                producto[] prdR = producto[p].Pro;
//                Hashtable critR = new Hashtable();
//                critR.Add("CodigoBarra", prdR[p].CodigoBarra);
//                critR.Add("Correlativo", producto[p].Correlativo);
//                op.EliminarRegistro("Precios", critR);

//                //Eliminamos en la tabla Inventario las tuplas de los productos con un codigo de barra espesifico y correlativo.
//                producto[] prdRx = producto[p].Pro;
//                Hashtable critRx = new Hashtable();
//                critRx.Add("CodigoBarra", prdRx[p].CodigoBarra);
//                critRx.Add("Correlativo", producto[p].Correlativo);
//                op.EliminarRegistro("Inventario", critRx);

//              //  MessageBox.Show("Codigo de Barra: " + prd[p].CodigoBarra + " " + prdR[p].CodigoBarra + " " + prdRx[p].CodigoBarra);

//            }
            


//        }

//        int contador = 0;
//        public void agregarProducto(inventario i, double precio) {
//            //MessageBox.Show("Nuevamente Tamaño del vector detalleVenta: " + producto.Length);
//            producto[contador] = new detalleVenta();
//            producto[contador].Pro = i.Producto;
//            producto[contador].PrecioVenta = i.Precios.Monto;
//            producto[contador].Costo = i.Costo;
//            producto[contador].Correlativo = i.Correlativo;
//            contador = contador + 1;
//        }
//        public void asignarCantidad(int can) {
//            producto = new detalleVenta[can];
//            //MessageBox.Show("Tamaño del vector detalleVenta: " + producto.Length);
//        }
//        internal sucursal[] Sucursales
//        {
//            get { return sucursales; }
//            set { sucursales = value; }
//        }
//        public DateTime Fecha
//        {
//            get { return fecha; }
//            set { fecha = value; }
//        }
//    }
//}
