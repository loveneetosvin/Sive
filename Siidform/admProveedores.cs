using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Siidform
{
    public partial class admProveedores : Telerik.WinControls.UI.RadForm
    {
        public admProveedores()
        {
            InitializeComponent();
            cargarCombox();
            llenarGridView();
            msj1.Visible = false;
        }

        public void cargarCombox()
        {
            this.radGridView1.MasterTemplate.Rows.Clear();
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
            radDropDownList1.DisplayMember = "Name";
            radDropDownList1.ValueMember = "Value";
            radDropDownList1.DataSource = lista;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if(this.txtCodigo.Text == ""){
            
            MessageBox.Show("Debe llenar el campo Codigo");

            } else if(this.txtNombre.Text == ""){

                MessageBox.Show("Debe llenar el campo Nombre");

            }else{
            controladorProveedores ctProve = new controladorProveedores();
            proveedor prov = new proveedor(txtCodigo.Text, txtNombre.Text);
            ctProve.agregar(prov);
            llenarGridView();
                }
        }

        public void llenarGridView() {
            this.radGridView1.MasterTemplate.Rows.Clear();
            controladorProveedores ctProve = new controladorProveedores();
            proveedor[] coleccionProveedores = ctProve.obtener();
            int contador = ctProve.obtener().Length;
            for (int f = 1; f <= contador; f++)
            {
                radGridView1.Rows.AddNew();
                this.radGridView1.Rows[f-1].Cells[0].Value = coleccionProveedores[f-1].CodigoProveedor+"";
                this.radGridView1.Rows[f - 1].Cells[1].Value = coleccionProveedores[f-1].Nombre + "";
            }
        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            controladorProveedores ctProve = new controladorProveedores();
            proveedor prov = new proveedor(txtCodigo.Text, txtfiltroProveedor.Text);
            proveedor[] coleccionProveedores = ctProve.obtenerFiltro(txtfiltroProveedor.Text);
            int contador = ctProve.obtenerFiltro(txtfiltroProveedor.Text).Length;
            this.radGridView1.MasterTemplate.Rows.Clear();
            for (int f = 1; f <= contador; f++)
            {
                radGridView1.Rows.AddNew();
                this.radGridView1.Rows[f - 1].Cells[0].Value = coleccionProveedores[f - 1].CodigoProveedor + "";
                this.radGridView1.Rows[f - 1].Cells[1].Value = coleccionProveedores[f - 1].Nombre + "";
            }
        }

        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
            txtCodigo.Text = this.radGridView1.Rows[index].Cells[0].Value+"";
            txtNombre.Text = this.radGridView1.Rows[index].Cells[1].Value + "";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {            
            int index = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
           // MessageBox.Show(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
            if(txtCodigo.Text != ""){
                controladorProveedores ctProve = new controladorProveedores();
                proveedor prov = new proveedor(txtCodigo.Text, txtNombre.Text);
                ctProve.modificar(prov);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                llenarGridView();
                msj1.Text = "Moficación exitosa.";
                msj1.Visible = true;            
            }
                
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            controladorProveedores ctProve = new controladorProveedores();
            proveedor prov = new proveedor(txtCodigo.Text, txtNombre.Text);
            ctProve.eliminar(prov);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            llenarGridView();
        }


    }
}
