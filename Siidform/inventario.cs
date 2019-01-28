using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    public class inventario
    {
        producto[] producto;
        int correlativo;
        double costo;
        precio precios;
        producto prod;
        rowGridView[] Filasprecios;

        public rowGridView[] Filasprecios1
        {
            get { return Filasprecios; }
            set { Filasprecios = value; }
        }

        public producto Prod
        {
            get { return prod; }
            set { prod = value; }
        }

        public producto[] Producto
        {
            get { return producto; }
            set { producto = value; }
        }


        public int Correlativo
        {
            get { return correlativo; }
            set { correlativo = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        internal precio Precios
        {
            get { return precios; }
            set { precios = value; }
        }
        arrayVistaCompra[] vCompra;

        internal arrayVistaCompra[] VCompra
        {
            get { return vCompra; }
            set { vCompra = value; }
        }
        int contardorArray = 0;

        public int ContardorArray
        {
            get { return contardorArray; }
            set { contardorArray = value; }
        }
        opcionesdb op = new opcionesdb();

        Hashtable viCompra = new Hashtable();

        public Hashtable ViCompra
        {
            get { return viCompra; }
            set { viCompra = value; }
        }

        public void registrarInventario(int idCompra)
        {


            producto[] pro = Producto;
            //op.iniciarTransaccion();

            String NomTabla = "Inventario";


            String codBarra = pro[0].CodigoBarra;
            String NTabla = "inventario";

            DataTable tab = new DataTable();
            tab = op.obtenerCorrelativo(NTabla, codBarra);
            DataRow row;

            if (tab.Rows.Count == 0)
            {
                correlativo = 0;
            }
            else
            {
                row = tab.Rows[0];
                correlativo = System.Convert.ToInt32(row["correlativo"].ToString()) + 1;
            }
            DataTable tabe = new DataTable();

            tabe = op.ObtenerTodasTuplas("TipoPrecio");
            DataRow row2;

            rowGridView[] tipoPre = Filasprecios1;


            for (int i = 0; i < pro.Length; i++)
            {
                //Vista previa compras
                //ContardorArray = i;
                //vCompra = new arrayVistaCompra[pro.Length];
                //--------------------
                //Lineas con detalles especificos por metodo.
                Hashtable crit = new Hashtable();
                crit.Add("CodigoBarra", pro[i].CodigoBarra);
                crit.Add("Correlativo", correlativo + i);

                ViCompra.Add(correlativo + i + "*" + pro[i].CodigoBarra, pro[i].CodigoBarra);
                //                ViCompra.Add("Correlativo", correlativo + i);

                //vCompra[ContardorArray].CodigoBarra = pro[i].CodigoBarra;
                //vCompra[ContardorArray].Correlativo = (correlativo + i)+"";

                crit.Add("Gravado", Costo);
                crit.Add("id_compra", idCompra);
                op.InsertarRegistro(NomTabla, crit);
                //  op.CommitTransaccion();
                for (int x = 0; x < tipoPre.Length; x++)
                {
                    Hashtable crity = new Hashtable();
                    crity.Add("CodigoBarra", pro[i].CodigoBarra);
                    crity.Add("Correlativo", correlativo + i);
                    crity.Add("Gravado", tipoPre[x].Cells1.ToString().Replace(",","."));
                    crity.Add("TipoPrecio", tipoPre[x].Cells0);
                    op.InsertarRegistro("Precios", crity);

                }
                //for(int x=0; x<3; x++){
                //    Hashtable crity = new Hashtable();
                //    crity.Add("CodigoBarra", pro[i].CodigoBarra);
                //    crity.Add("Correlativo", correlativo+i);

                //    row2 = tabe.Rows[x];
                //    if(x==0){
                //        crity.Add("Gravado", (Costo+(System.Convert.ToDouble(row2["Formula"])/100) * Costo));
                //        crity.Add("TipoPrecio", "Maximo");                    
                //    }else if(x==1){
                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
                //        crity.Add("TipoPrecio", "Minimo");                                     
                //    }else if(x==2){
                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
                //        crity.Add("TipoPrecio", "Normal");                                 
                //    }
                //    op.InsertarRegistro("Precios", crity);                    
                //}
            }
        }
        public void obtenerPrecio(double Ocosto)
        {
            DataTable tabe = new DataTable();
            tabe = op.ObtenerTodasTuplas("TipoPrecio");
            DataRow row2;

            rowGridView[] precios = new rowGridView[tabe.Rows.Count];
            for (int x = 0; x < tabe.Rows.Count; x++)
            {
                row2 = tabe.Rows[x];
                precios[x] = new rowGridView();
                precios[x].Cells0 = row2["TipoPrecio"] + "";
                //                precios[x].Cells1 = Ocosto + (System.Convert.ToDouble(row2["Formula"]) / 100) * Ocosto + "";
                precios[x].Cells1 = Decimal.Round(System.Convert.ToDecimal((Ocosto * (1.13)) / (System.Convert.ToDouble(1) - (System.Convert.ToDouble(row2["Formula"]) / 100))), 2) + "";


                //    row2 = tabe.Rows[x];
                //    if (x == 0)
                //    {
                //        Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
                //        "Maximo");
                //    }
                //    else if (x == 1)
                //    {
                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
                //        crity.Add("TipoPrecio", "Minimo");
                //    }
                //    else if (x == 2)
                //    {
                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
                //        crity.Add("TipoPrecio", "Normal");
                //    }
            }
            Filasprecios1 = precios;
        }
        public void obtenerCorrelativo()
        {
            String codBarra = Prod.CodigoBarra;
            String NTabla = "inventario";

            DataTable tab = new DataTable();
            tab = op.obtenerCorrelativo(NTabla, prod.CodigoBarra);
            DataRow row;
            row = tab.Rows[0];
            correlativo = System.Convert.ToInt32(row["correlativo"].ToString()) + 1;
        }
        public void obtener(string codigoBarra, int correlativo)
        {

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

//namespace Siidform
//{
//    public class inventario
//    {
//        producto[] producto;
//        int correlativo;
//        double costo;
//        precio precios;
//        producto prod;
//        rowGridView[] Filasprecios;

//        public rowGridView[] Filasprecios1
//        {
//            get { return Filasprecios; }
//            set { Filasprecios = value; }
//        }

//        public producto Prod
//        {
//            get { return prod; }
//            set { prod = value; }
//        }

//        public producto[] Producto
//        {
//            get { return producto; }
//            set { producto = value; }
//        }


//        public int Correlativo
//        {
//            get { return correlativo; }
//            set { correlativo = value; }
//        }
        
//        public double Costo
//        {
//            get { return costo; }
//            set { costo = value; }
//        }


//        internal precio Precios
//        {
//            get { return precios; }
//            set { precios = value; }
//        }
//        arrayVistaCompra[] vCompra;

//        internal arrayVistaCompra[] VCompra
//        {
//            get { return vCompra; }
//            set { vCompra = value; }
//        }
//        int contardorArray = 0;

//        public int ContardorArray
//        {
//            get { return contardorArray; }
//            set { contardorArray = value; }
//        }
//        opcionesdb op = new opcionesdb();

//        Hashtable viCompra = new Hashtable();

//        public Hashtable ViCompra
//        {
//            get { return viCompra; }
//            set { viCompra = value; }
//        }

//        public void registrarInventario(int idCompra) {
         

//            producto[] pro = Producto;
//            //op.iniciarTransaccion();

//            String NomTabla = "Inventario";


//            String codBarra = pro[0].CodigoBarra;
//            String NTabla = "inventario";

//            DataTable tab = new DataTable();
//            tab = op.obtenerCorrelativo(NTabla, codBarra);
//            DataRow row;

//            if (tab.Rows.Count == 0)
//            {
//                correlativo = 0;
//            }
//            else { 
//                row = tab.Rows[0];
//                correlativo = System.Convert.ToInt32(row["correlativo"].ToString())+1;
//            }
//            DataTable tabe = new DataTable();

//            tabe = op.ObtenerTodasTuplas("TipoPrecio");
//            DataRow row2;

//            rowGridView[] tipoPre = Filasprecios1;


//            for(int i=0; i<pro.Length;i++){
//                //Vista previa compras
//                    //ContardorArray = i;
//                    //vCompra = new arrayVistaCompra[pro.Length];
//                //--------------------
//               //Lineas con detalles especificos por metodo.
//                Hashtable crit = new Hashtable();
//                crit.Add("CodigoBarra", pro[i].CodigoBarra);
//                crit.Add("Correlativo", correlativo+i);

//                ViCompra.Add(correlativo + i+"*"+pro[i].CodigoBarra, pro[i].CodigoBarra);
////                ViCompra.Add("Correlativo", correlativo + i);

//                //vCompra[ContardorArray].CodigoBarra = pro[i].CodigoBarra;
//                //vCompra[ContardorArray].Correlativo = (correlativo + i)+"";

//                crit.Add("Gravado", Costo);
//                crit.Add("id_compra", idCompra);
//                op.InsertarRegistro(NomTabla, crit);
//              //  op.CommitTransaccion();
//                for (int x = 0; x < tipoPre.Length;x++ )
//                {
//                    Hashtable crity = new Hashtable();
//                    crity.Add("CodigoBarra", pro[i].CodigoBarra);
//                    crity.Add("Correlativo", correlativo + i);
//                    crity.Add("Gravado", tipoPre[x].Cells1);
//                    crity.Add("TipoPrecio", tipoPre[x].Cells0);
//                    op.InsertarRegistro("Precios", crity);                    

//                }
//                //for(int x=0; x<3; x++){
//                //    Hashtable crity = new Hashtable();
//                //    crity.Add("CodigoBarra", pro[i].CodigoBarra);
//                //    crity.Add("Correlativo", correlativo+i);
                    
//                //    row2 = tabe.Rows[x];
//                //    if(x==0){
//                //        crity.Add("Gravado", (Costo+(System.Convert.ToDouble(row2["Formula"])/100) * Costo));
//                //        crity.Add("TipoPrecio", "Maximo");                    
//                //    }else if(x==1){
//                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
//                //        crity.Add("TipoPrecio", "Minimo");                                     
//                //    }else if(x==2){
//                //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
//                //        crity.Add("TipoPrecio", "Normal");                                 
//                //    }
//                //    op.InsertarRegistro("Precios", crity);                    
//                //}
//            }
//        }
//        public void obtenerPrecio(double Ocosto)
//        {
//            DataTable tabe = new DataTable();
//            tabe = op.ObtenerTodasTuplas("TipoPrecio");
//            DataRow row2;

//            rowGridView[] precios = new rowGridView[tabe.Rows.Count];
//            for (int x = 0; x < tabe.Rows.Count; x++)
//            {
//                row2 = tabe.Rows[x];
//                precios[x] = new rowGridView();
//                precios[x].Cells0 = row2["TipoPrecio"]+"";
//                precios[x].Cells1 = Ocosto + (System.Convert.ToDouble(row2["Formula"]) / 100) * Ocosto + "";

//            //    row2 = tabe.Rows[x];
//            //    if (x == 0)
//            //    {
//            //        Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
//            //        "Maximo");
//            //    }
//            //    else if (x == 1)
//            //    {
//            //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
//            //        crity.Add("TipoPrecio", "Minimo");
//            //    }
//            //    else if (x == 2)
//            //    {
//            //        crity.Add("Gravado", (Costo + (System.Convert.ToDouble(row2["Formula"]) / 100) * Costo));
//            //        crity.Add("TipoPrecio", "Normal");
//            //    }
//            }
//            Filasprecios1 = precios;
//        }
//        public void obtenerCorrelativo()
//        {
//            String codBarra = Prod.CodigoBarra;
//            String NTabla = "inventario";

//            DataTable tab = new DataTable();
//            tab = op.obtenerCorrelativo(NTabla, prod.CodigoBarra);
//            DataRow row;
//            row = tab.Rows[0];
//            correlativo = System.Convert.ToInt32(row["correlativo"].ToString())+1;
//        }
//        public void obtener(string codigoBarra, int correlativo)
//        {

//        }


//    }
//}
