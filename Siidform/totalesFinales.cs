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
    public partial class totalesFinales : Telerik.WinControls.UI.RadForm
    {
        public totalesFinales()
        {
            InitializeComponent();
            CargarSucursales();
            CargarMes();
        }

        public void CargarSucursales()
        {
            opcionesdb opcionesS = new opcionesdb();
            String NombreTabla = "Sucursal";
            DataTable tabla = opcionesS.ObtenerTodasTuplas(NombreTabla);
            List<Item> lista = new List<Item>();

            DataRow row;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                row = tabla.Rows[i];
                lista.Add(new Item(row["Nombre"].ToString(), System.Convert.ToInt32(row["CodigoSucursal"])));
            }

            SucursalList.DisplayMember = "Name";
            SucursalList.ValueMember = "Value";
            SucursalList.DataSource = lista;

        }



        public void CargarMes()
        {
            List<Item> mes = new List<Item>();

            mes.Add(new Item("Enero", 1));
            mes.Add(new Item("Febrero", 2));
            mes.Add(new Item("Marzo", 3));
            mes.Add(new Item("Abril", 4));
            mes.Add(new Item("Mayo", 5));
            mes.Add(new Item("Junio", 6));
            mes.Add(new Item("Julio", 7));
            mes.Add(new Item("Agosto", 8));
            mes.Add(new Item("Septiempre", 9));
            mes.Add(new Item("Octubre", 10));
            mes.Add(new Item("Noviembre", 11));
            mes.Add(new Item("Diciembre", 12));
            MesList.DisplayMember = "Name";
            MesList.ValueMember = "Value";
            MesList.DataSource = mes;

        }

        public void CreditoCompra()
        {
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Compras";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            crit.Add("MONTH(Fecha)", MesList.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", AnyoBox.Text);
            crit.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());


            crit.Add("TipoCompra", 1);
            reg.Add("Gravado", "Gravado");
            reg.Add("Fecha", "Fecha");
            reg.Add("IVA", "IVA");
            reg.Add("Percepcion", "Percepcion");


            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.00;
            double TotalIva = 0.00;
            double TotalPercepcion = 0.00;

            try
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {


                    DataRow row = tab.Rows[i];
                    total = total + System.Convert.ToDouble(row["Gravado"].ToString());
                    TotalIva = TotalIva + System.Convert.ToDouble(row["IVA"].ToString());
                    TotalPercepcion += System.Convert.ToDouble(row["Percepcion"].ToString());
                }
                Creditotxt.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";
                TxtIva.Text = Decimal.Round(System.Convert.ToDecimal(TotalIva), 2) + "";
                TxtPercepcion.Text = Decimal.Round(System.Convert.ToDecimal(TotalPercepcion), 2) + "  ";

            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                Telerik.WinControls.RadMessageBox.Show("Tuplas de la tabla Compras tienen un valor de NULL " + ex.HResult + "\n Revice la base de Datos");

            }


        }


        public void LibreCompra()
        {

            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Compras";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            crit.Add("MONTH(Fecha)", MesList.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", AnyoBox.Text);
            crit.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());


            crit.Add("TipoCompra", 2);
            reg.Add("Gravado", "Gravado");
            reg.Add("Fecha", "Fecha");



            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.0;
            try
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {


                    DataRow row = tab.Rows[i];
                    total = total + System.Convert.ToDouble(row["Gravado"].ToString());
                }
                TxtlibreCompra.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";

            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                Telerik.WinControls.RadMessageBox.Show("Gravado con TipoCompra=2 tiene un valor de NULL " + ex.HResult + "\n Revice la base de Datos");

            }




        }


        public void Ventaconsumidor()
        {
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Ventas";
            Hashtable crit = new Hashtable();

            Hashtable reg = new Hashtable();
            crit.Add("MONTH(Fecha)", MesList.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", AnyoBox.Text);
            crit.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());


            crit.Add("TipoVenta", "FACTURA");
            reg.Add("Gravado", "Gravado");
            reg.Add("Fecha", "Fecha");
            reg.Add("IVA", "IVA");
            reg.Add("PagoACuenta", "PagoACuenta");
            reg.Add("Renta", "Renta");
            reg.Add("Utilidad", "Utilidad");


            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.00;
            double TotalIva = 0.00;
            double TotalPagoCuenta = 0.00;
            double  Rentax =0.00;
            double UtilidadFinal = 0.00;

            try
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {


                    DataRow row = tab.Rows[i];
                    total = total + System.Convert.ToDouble(row["Gravado"].ToString());
                    TotalIva = TotalIva + System.Convert.ToDouble(row["IVA"].ToString());
                    TotalPagoCuenta = TotalPagoCuenta + System.Convert.ToDouble(row["PagoACuenta"].ToString());
                    Rentax = Rentax + System.Convert.ToDouble(row["Renta"].ToString());
                    UtilidadFinal += System.Convert.ToDouble(row["Utilidad"].ToString());
                }
                TxtFinal.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";
                TxtVentaIva.Text = Decimal.Round(System.Convert.ToDecimal(TotalIva), 2) + "";
                TxtPagoCuenta.Text = Decimal.Round(System.Convert.ToDecimal(TotalPagoCuenta), 2) + "  ";
                TxtRenta.Text = Decimal.Round(System.Convert.ToDecimal(Rentax), 2) + "";
                TxtUtilidad.Text = Decimal.Round(System.Convert.ToDecimal(UtilidadFinal), 2) + "  ";
            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                Telerik.WinControls.RadMessageBox.Show("Tuplas de la tabla Ventas tienen un valor de NULL " + ex.HResult + "\n Revice la base de Datos");

            }

        }

        public void BorradorVenta()
        {

            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Ventas";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            crit.Add("MONTH(Fecha)", MesList.SelectedItem.Value.ToString());
            crit.Add("YEAR(Fecha)", AnyoBox.Text);
            crit.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());


            crit.Add("TipoVenta", "Borrador");
            reg.Add("Gravado", "Gravado");
            reg.Add("Fecha", "Fecha");




            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
            double total = 0.00;

            try
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {


                    DataRow row = tab.Rows[i];
                    total = total + System.Convert.ToDouble(row["Gravado"].ToString());

                }
                TxtBorrador.Text = Decimal.Round(System.Convert.ToDecimal(total), 2) + "";

            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                Telerik.WinControls.RadMessageBox.Show("Tuplas de la tabla Ventas tienen un valor de NULL " + ex.HResult + "\n Revice la base de Datos");

            }


        }


        public void AgregarTotales()
        {

            opcionesdb opciones = new opcionesdb();
            String NomTabla = "Totales";
            String TablaVentas = "Ventas";
            Hashtable crit = new Hashtable();
            Hashtable Modificar = new Hashtable();
            Hashtable Actualizar = new Hashtable();
             Hashtable reg = new Hashtable();

             crit.Add("MONTH(Fecha)", MesList.SelectedItem.Value.ToString());
             crit.Add("YEAR(Fecha)", AnyoBox.Text);
             crit.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());


            
            reg.Add("TotalReal", "TotalReal");
            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(TablaVentas, crit, reg);
            
            double Realtotal = 0.00;
            
            String TotalRealx = "";

           try
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {


                    DataRow row = tab.Rows[i];

                    Realtotal = Realtotal + System.Convert.ToDouble(row["TotalReal"].ToString());
                
                TotalRealx = Decimal.Round(System.Convert.ToDecimal(Realtotal), 2) + "";
                    
                }
            }
           catch (Exception ex)
           {
               RadMessageBox.SetThemeName("TelerikMetroBlue");
               Telerik.WinControls.RadMessageBox.Show("Tuplas de la tabla Ventas tienen un valor de NULL " + ex.HResult + "\n Revice la base de Datos");

           }
            
           Modificar.Add("Anio", AnyoBox.Text);
           Modificar.Add("Mes", MesList.SelectedItem.Value.ToString());
           Modificar.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());
           Modificar.Add("TotalReal", TotalRealx);
           Modificar.Add("TotalGravado", TxtFinal.Text);
           Modificar.Add("Iva", TxtVentaIva.Text);
           Modificar.Add("Renta", TxtRenta.Text);
           Modificar.Add("PagoAcuenta", TxtPagoCuenta.Text);
           Modificar.Add("Utilidad", TxtUtilidad.Text);

            // parameto para Actualizar tuplas
           Actualizar.Add("Anio", AnyoBox.Text);
           Actualizar.Add("Mes", MesList.SelectedItem.Value.ToString());
           Actualizar.Add("CodigoSucursal", SucursalList.SelectedItem.Value.ToString());
          

          opciones.InsertarATabla(NomTabla, Modificar);

           opciones.ModificarRegistro(NomTabla,Actualizar,Modificar);
        }

        private void AnyoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {

                e.Handled = true;
               
                return;
            }
        }



        private void radButton1_MouseClick(object sender, MouseEventArgs e)
        {
            lbxactualizar.Text = " Datos Actualizados.....";
                CreditoCompra();
                LibreCompra();
                Ventaconsumidor();
                BorradorVenta();
                AgregarTotales();
        }

        private void AnyoBox_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void AnyoBox_TextChanged(object sender, EventArgs e)
        {
             radButton1.Enabled = (AnyoBox.TextLength > 3);
             lbxactualizar.Text = " ";
            
        }

        private void SucursalList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            lbxactualizar.Text = " ";
        }

        private void MesList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            lbxactualizar.Text = " ";
        }
    }
}
