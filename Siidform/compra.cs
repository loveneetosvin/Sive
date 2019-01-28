using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Siidform
{
    class compra
    {
        int idCompra;
        inventario[] productos;
        proveedor[] proveedor;
        sucursal[] sucursal;
        DateTime fecha;
        double total;
        opcionesdb opcione = new opcionesdb();
        String NDoc;

        public String NDoc1
        {
            get { return NDoc; }
            set { NDoc = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        //Este metodo es solo para agregar una nueva fila del producto al GridView.
        public producto agregarItem(String codBarra){
            controladorProducto ctProdu = new controladorProducto();
            producto pro = ctProdu.obtener(codBarra);
            return pro;
        }

        //Sumatoria de los precios de todos los productos en GridView.
        public void calcularTotal()
        {
            inventario[] invet = Productos;
            inventario inv = new inventario();
            int num=0;
            double subtotal = 0.0;
            double total = 0.0;
            for (int i = 0; i < invet.Length; i++)
            {
                num = invet[i].Producto.Length;
                subtotal = num*invet[i].Costo;
                total = total + subtotal;
            }
            Total = total;
            //MessageBox.Show("Total de la compra: "+total);
        }

        //Se registra la compra con todos los detalles de los productos y precios, así como el total de la compra.
        arrayVistaCompra[] vCompra;

        internal arrayVistaCompra[] VCompra
        {
            get { return vCompra; }
            set { vCompra = value; }
        }

        Hashtable[] vistaCompra;

        public Hashtable[] VistaCompra
        {
            get { return vistaCompra; }
            set { vistaCompra = value; }
        }
        
        public void registrarCompra()
        {
          //  opcione.iniciarTransaccion();

            inventario[] invet = Productos;
            

            String NomTabla = "Compras";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoProveedor", Proveedor[0].CodigoProveedor.ToString());
            crit.Add("TipoCompra", "2");
            crit.Add("CodigoSucursal", sucursal[0].Codigosucursal.ToString());
            crit.Add("Gravado", Total);
            double iva = total*0.13;

            crit.Add("IVA", Decimal.Round(System.Convert.ToDecimal(iva), 2));
            crit.Add("Percepcion", 0);

            String fech = Convert.ToString(Fecha);
            crit.Add("Fecha", fech.Substring(0, 10));
            crit.Add("NDocumento", NDoc1);

            opcione.InsertarRegistro(NomTabla, crit);

            DataTable tabla = opcione.obtenerIdCompra();
            
            DataRow row;
            row = tabla.Rows[0];
           // opcione.CommitTransaccion();
           // int contadorArrayVistaPrevia=0;
            
            VistaCompra = new Hashtable[invet.Length];

            for (int f = 0; f < invet.Length;f++ )
            {
                inventario inv = new inventario();
                inv = invet[f];
                inv.registrarInventario(System.Convert.ToInt32(row["idComp"]));
                VistaCompra[f] = inv.ViCompra;
                //for(int h=0;h<inv.ContardorArray;h++){
                //    contadorArrayVistaPrevia = contadorArrayVistaPrevia+1; 
                //    VCompra[contadorArrayVistaPrevia].CodigoBarra = inv.VCompra[h].CodigoBarra;
                //    VCompra[contadorArrayVistaPrevia].Correlativo = inv.VCompra[h].Correlativo;
                //}
             }


        }
        //Devuelve un booleano (true o false) para indicar si la compra se registro o no.
        public bool validar()
        {
            return true;
        }

        public void obtenerSucursales() {
            //controladorSucursales ctS = new controladorSucursales();
            //Sucursal = ctS.obtenerSucursales();
        }

        public void obtenerProveedores() {
            //controladorProveedores ctP = new controladorProveedores();
            //Proveedor = ctP.obtener();
        }

        public proveedor[] Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public inventario[] Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }


        public sucursal[] Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

    }
}
