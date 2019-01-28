using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Siidform
{
    class CalcularImpuestos
    {
      public  Double IVA;
      public Double Renta;
      public Double PagoACuenta;
      public Double Percepcion;

      public void ObtenerParametros()
      {
          opcionesdb opcion = new opcionesdb();
          String Nomtabla = "Parametros";

          DataTable tabla = opcion.ObtenerTodasTuplas(Nomtabla);
          DataRow row;
          for (int i = 0; i < tabla.Rows.Count; i++)
          {
              row = tabla.Rows[i];
              if (row["Nombre"].ToString() == "IVA") {
                  IVA = Convert.ToDouble(row["Valor"].ToString().Replace(".", ","));
              }else if (row["Nombre"].ToString() == "Pago a Cuenta") {
                  PagoACuenta = Convert.ToDouble(row["Valor"].ToString().Replace(".", ","));
              }else if (row["Nombre"].ToString() == "Renta") {
                  Renta = Convert.ToDouble(row["Valor"].ToString().Replace(".", ","));
              }
          }


         
      }

      public double CalcularIVA(Double Gravado) {
          Double IVAC;

          IVAC =  Math.Round((Gravado * IVA), 2);
          return IVAC; }

      public double CalcularRentaCalculada(Double UtilidadBruta) {
          Double RentaC;
          RentaC =  Math.Round((UtilidadBruta * Renta), 2);
          return RentaC; }

      public Double CalcularRentaFinal(Double RentaCalculada, Double PagoCuenta)
      {
          Double RentaF;
          RentaF =   Math.Round((RentaCalculada - PagoCuenta), 2);
          if (RentaF > 0) { 
              return RentaF;
          }
          else
          {
              RentaF = 0.0;
              return RentaF;
          }

      }

      public double CalcularPagoAcuenta(Double Gravado) {
          Double PagoACuentaC;
          PagoACuentaC =  Math.Round((Gravado * PagoACuenta), 2);
          return PagoACuentaC; }

      public Double CalcularUtilidadBruta(Double ValorVenta, Double ValorCompra)
      {
          Double UtilidadBruta;

          UtilidadBruta =  Math.Round((ValorVenta - ValorCompra), 2);
          return UtilidadBruta;
      }

      public Double CalcularUtilidad(Double UtilidadBru, Double Renta)
      {
          Double Utilidad;
          Utilidad = Math.Round((UtilidadBru - Renta), 2);
          return Utilidad;
      }

      public double CalcularGravadoVenta(Double Precio)
      {
          double GravadoV;
          GravadoV = Precio/1.13;
          return GravadoV;
      }



      public double CalcularPercepcion() { 
          
          
          return Percepcion; }

    }
}
