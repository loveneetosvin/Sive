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
    public partial class vistaPreviaCompras : Telerik.WinControls.UI.RadForm
    {
        Hashtable[] vistaCompras;
        public vistaPreviaCompras(Hashtable[] vistaCompra)
        {
            InitializeComponent();
            vistaCompras = vistaCompra;
            mostrar();
        }
        Boolean agregarColumna = true;
        public void agregarColumnasPrecios(int cantidadTiposPrecios)
        {
            //  fila = new rowGridView[cantidadTiposPrecios];
            for (int i = 0; i < cantidadTiposPrecios; i++)
            {
              //  radGridView1.Columns.Add(radGridView2.Rows[i].Cells[0].Value + "", radGridView2.Rows[i].Cells[0].Value + "");
              //  radGridView1.Columns[4 + i].Width = 80;
                //    fila[i].Cells0 = radGridView2.Rows[i].Cells[0].Value + "";
            }
            agregarColumna = false;

        }
        public void mostrar() {
            for (int i = 0; i < vistaCompras.Length; i++ )
            {
                  Hashtable vistaComp = vistaCompras[i];
                foreach (DictionaryEntry r in vistaComp)
                {
//                        MessageBox.Show("Codigo de Barra:  " + r.Value + " Correlativo:   " + r.Key);
                        string s = r.Key+"";
                        string[] words = s.Split('*');
                    //    MessageBox.Show("Codigo de Barra: " + words[1] + "  Correlativo: " + words[0]);
                        radGridView1.Rows.AddNew();
                        int f = radGridView1.Rows.Count;
                        this.radGridView1.Rows[f - 1].Cells[0].Value = words[1];
                        this.radGridView1.Rows[f - 1].Cells[1].Value = words[0];
                    //------------------------------
                        opcionesdb opciones = new opcionesdb();
                        String NomTabla = "inventario";
                        Hashtable crit = new Hashtable();
                        Hashtable reg = new Hashtable();
                        //Lineas con detalles especificos por metodo.
                        crit.Add("CodigoBarra", words[1]);
                        crit.Add("correlativo", words[0]);

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

                         //   costoProductoTemporal = System.Convert.ToDouble(row["Gravado"]);
                            this.radGridView1.Rows[f - 1].Cells[3].Value = System.Convert.ToDouble(row["Gravado"]);
                            DataTable tabr = new DataTable();
                            tabr = opciones.BuscarRegistro("productos", crity, regy);

                            DataRow rowre = tabr.Rows[0];
                            pro = new producto(rowre["CodigoBarra"].ToString(), rowre["nombre"].ToString());
                            //radTextBox3.Text = pro.Nombre;
                            this.radGridView1.Rows[f - 1].Cells[2].Value = pro.Nombre;

                        }
                        else
                        {
                            MessageBox.Show("No hay producto con ese correlativo y codigo de Barra");
                        }

                        //---------------------------------------------

                        Hashtable critt = new Hashtable();
                        Hashtable regt = new Hashtable();
                        //Lineas con detalles especificos por metodo.
                        critt.Add("CodigoBarra", words[1]);
                        critt.Add("correlativo", words[0]);

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
                            //  radGridView2.Rows.AddNew();                           P.V.Minimo
//                            int f = radGridView2.Rows.Count;
  //                          this.radGridView2.Rows[f - 1].Cells[0].Value = rowt["TipoPrecio"];
                            if (radGridView1.Columns.Count != (4 + tabt.Rows.Count))
                            {
                                radGridView1.Columns.Add("P.V." + rowt["TipoPrecio"] + "", "P.V." + rowt["TipoPrecio"] + "");
                                radGridView1.Columns[radGridView1.Columns.Count-1].Width = 80;
                            }
                            

                            this.radGridView1.Rows[f - 1].Cells[4+y].Value = Decimal.Round(System.Convert.ToDecimal(rowt["Gravado"]), 2);

//                            this.radGridView2.Rows[f - 1].Cells[1].Value = Decimal.Round(System.Convert.ToDecimal(rowt["Gravado"]), 2);

                        }


                    //------------------------------
//                        this.radGridView1.Rows[f - 1].Cells[2].Value = txtCosto.Text;
//                        this.radGridView1.Rows[f - 1].Cells[3].Value = txtCantidad.Text;



                }

                
             }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
