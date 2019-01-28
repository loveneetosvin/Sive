using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections.Generic;
using System.Collections;

namespace Siidform
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            panelAdmPrecios.Visible = true;
            panelAdmProd.Visible = false;
            panelAdmPara.Visible = false;
            panelAdmSucursal.Visible = false;
            cargarCombox();
            labelMensajes.Text = "";
            msj2.Text = "";
        }

        public void cargarCombox()
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "TipoPrecio";

            DataTable tabla = opciones.ObtenerTodasTuplas(NomTabla);
            List<Item> lista = new List<Item>();

            DataRow row;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                row = tabla.Rows[i];
                lista.Add(new Item(row["TipoPrecio"].ToString(), System.Convert.ToInt32(row["Formula"])));
            }
            radDropDownList1.DisplayMember = "Name";
            radDropDownList1.ValueMember = "Value";
            radDropDownList1.DataSource = lista;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            panelAdmPrecios.Visible = true;
            panelAdmProd.Visible = false;
            panelAdmPara.Visible = false;
            panelAdmSucursal.Visible = false;
        }

        public void cargarProductos()
        {
            this.radGridView1.MasterTemplate.Rows.Clear();
            opcionesdb opcione = new opcionesdb();
            DataTable tabla = opcione.ObtenerTodasTuplas("Productos");
            DataRow row;
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView1.Rows.AddNew();
                int x = radGridView1.Rows.Count;
                this.radGridView1.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
                this.radGridView1.Rows[x - 1].Cells[1].Value = row["Nombre"].ToString();
            }
            txtNombreP.Text = "";
            txtCodBarra.Text = "";
        }
        public void cargarSucursales()
        {
            this.radGridView3.MasterTemplate.Rows.Clear();
            opcionesdb opcione = new opcionesdb();
            DataTable tabla = opcione.ObtenerTodasTuplas("Sucursal");
            DataRow row;
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView3.Rows.AddNew();
                int x = radGridView3.Rows.Count;
                this.radGridView3.Rows[x - 1].Cells[0].Value = row["CodigoSucursal"].ToString();
                this.radGridView3.Rows[x - 1].Cells[1].Value = row["Nombre"].ToString();
            }
            txtCodSucur.Text = "";
            txtNombreSucur.Text = "";
        }

        public void cargarParametros()
        {
            this.radGridView2.MasterTemplate.Rows.Clear();
            opcionesdb opcione = new opcionesdb();
            DataTable tabla = opcione.ObtenerTodasTuplas("Parametros");
            DataRow row;
            for (int f = 0; f < tabla.Rows.Count; f++)
            {
                row = tabla.Rows[f];
                radGridView2.Rows.AddNew();
                int x = radGridView2.Rows.Count;
                this.radGridView2.Rows[x - 1].Cells[0].Value = row["Nombre"].ToString();
                this.radGridView2.Rows[x - 1].Cells[1].Value = row["Valor"].ToString();
            }
            txtnombreparam.Text = "";
            txtvalorparam.Text = "";
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            panelAdmProd.Visible = true;
            panelAdmPrecios.Visible = false;

            panelAdmPara.Visible = false;
            panelAdmSucursal.Visible = false;
            cargarProductos();

            //RadGridView segun interfaces:
            //opcionesdb opcione = new opcionesdb();

            //DataTable tabla = opcione.productoJOIN();
            //DataRow row;
            //for (int f = 0; f < tabla.Rows.Count; f++)
            //{
            //    row = tabla.Rows[f];
            //    radGridView1.Rows.AddNew();
            //    int x = radGridView1.Rows.Count;
            //    this.radGridView1.Rows[x - 1].Cells[0].Value = row["CodigoBarra"].ToString();
            //    this.radGridView1.Rows[x - 1].Cells[1].Value = row["Correlativo"].ToString();
            //    this.radGridView1.Rows[x - 1].Cells[2].Value = row["Nombre"].ToString();
            //    this.radGridView1.Rows[x - 1].Cells[3].Value = row["Gravado"].ToString();
            //    this.radGridView1.Rows[x - 1].Cells[4].Value = row["NombreP"].ToString();
            //}


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {

                MessageBox.Show("Debe llenar el campo Nombre");
            }
            else if (this.txtGananciaNueva.Text == "")
            {

                MessageBox.Show("Debe llenar el campo Ganancia");

            }
            else
            {
                //Lineas de codigos en comun para todos los metodos.
                opcionesdb opciones = new opcionesdb();
                String NomTabla = "TipoPrecio";
                Hashtable crit = new Hashtable();

                //Lineas con detalles especificos por metodo.
                crit.Add("TipoPrecio", txtNombre.Text);
                crit.Add("Formula", txtGananciaNueva.Text);

                opciones.InsertarRegistro(NomTabla, crit);

                txtNombre.Text = "";
                txtGananciaNueva.Text = "";
                labelMensajes.Text = "Nueva categoria creada exitosamente.";
                txtGananciaModificar.Text = "";
                cargarCombox();
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                txtGananciaModificar.Text = radDropDownList1.SelectedValue.ToString();
            }
            catch (Exception eee)
            {

            }
            finally
            {

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TipoPrecio TipoPrec = new TipoPrecio(txtGananciaModificar.Text, radDropDownList1.SelectedText.ToString());
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "TipoPrecio";
            Hashtable crit = new Hashtable();

            Hashtable reg = new Hashtable();

            //Lineas con detalles especificos por metodo.
            reg.Add("TipoPrecio", TipoPrec.TipoPrecio1.ToString());
            reg.Add("Formula", TipoPrec.Formula.ToString());

            //Nuevos valores de la tupla a actualizar.
            crit.Add("TipoPrecio", TipoPrec.TipoPrecio1.ToString());

            opciones.ModificarRegistro(NomTabla, crit, reg);
            msj2.Text = "Modificado exitosamente.";
            cargarCombox();
        }
        int indexGlobal2 = 0;
        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            btnPModificar.Enabled = true;
            btnEliminar.Enabled = true;
            indexGlobal2 = System.Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentIndex.ToString());
            txtCodBarra.Text = radGridView1.Rows[indexGlobal2].Cells[0].Value.ToString();
            txtNombreP.Text = radGridView1.Rows[indexGlobal2].Cells[1].Value.ToString();
        }

        private void btnPModificar_Click(object sender, EventArgs e)
        {
            if (this.txtCodBarra.Text == "") { MessageBox.Show("Debe llenar el campo Codigo o elija un registro de la tabla"); }
            else if (this.txtNombreP.Text == "") { MessageBox.Show("Debe llenar el campo Nombre o elija un registro de la tabla"); }
            else
            {
                producto pro = new producto(txtCodBarra.Text, txtNombreP.Text);
                controladorProducto control = new controladorProducto();
                control.modificar(pro);
                cargarProductos();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtCodBarra.Text == "") { MessageBox.Show("Debe llenar el campo Codigo de Barra"); }
            else if (this.txtNombreP.Text == "") { MessageBox.Show("Debe llenar el Nombre del Producto"); }
            else
            {
                producto pro = new producto(txtCodBarra.Text, txtNombreP.Text);
                controladorProducto control = new controladorProducto();
                control.agregar(pro);
                cargarProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.txtCodBarra.Text == "") { MessageBox.Show("Debe llenar el campo Codigo o elija un registro de la tabla"); }
            else if (this.txtNombreP.Text == "") { MessageBox.Show("Debe llenar el campo Nombre o elija un registro de la tabla"); }
            else
            {
                producto pro = new producto(txtCodBarra.Text, txtNombreP.Text);
                controladorProducto control = new controladorProducto();
                control.eliminar(pro);
                cargarProductos();
            }
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIIDBetaDataSet.sucursales' Puede moverla o quitarla según sea necesario.
           // this.sucursalesTableAdapter.Fill(this.sIIDBetaDataSet.sucursales);

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            panelAdmPara.Visible = true;
            panelAdmPrecios.Visible = false;
            panelAdmProd.Visible = false;

            panelAdmSucursal.Visible = false;
            this.cargarParametros();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            panelAdmSucursal.Visible = true;
            panelAdmPrecios.Visible = false;
            panelAdmProd.Visible = false;
            panelAdmPara.Visible = false;

            this.cargarSucursales();

        }



        private void radGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            btnmodificarsucursal.Enabled = true;
            btneliminarsucursal.Enabled = true;
            indexGlobal2 = System.Convert.ToInt32(radGridView3.MasterGridViewInfo.CurrentIndex.ToString());
            txtCodSucur.Text = radGridView3.Rows[indexGlobal2].Cells[0].Value.ToString();
            txtNombreSucur.Text = radGridView3.Rows[indexGlobal2].Cells[1].Value.ToString();
        }

        private void radGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            btnGCambPara.Enabled = true;
            indexGlobal2 = System.Convert.ToInt32(radGridView2.MasterGridViewInfo.CurrentIndex.ToString());
            txtnombreparam.Text = radGridView2.Rows[indexGlobal2].Cells[0].Value.ToString();
            txtvalorparam.Text = radGridView2.Rows[indexGlobal2].Cells[1].Value.ToString();
        }

        private void btnGCambPara_Click(object sender, EventArgs e)
        {
            if (this.txtnombreparam.Text == "") { MessageBox.Show("Debe llenar el campo Nombre o elija un registro de la tabla"); }
            else if (this.txtvalorparam.Text == "") { MessageBox.Show("Debe llenar el campo Valor o elija un registro de la tabla"); }
            else
            {
                parametros para = new parametros(txtnombreparam.Text, txtvalorparam.Text);

                //Lineas de codigos en comun para todos los metodos.
                opcionesdb opciones = new opcionesdb();
                String NomTabla = "Parametros";
                Hashtable crit = new Hashtable();

                Hashtable reg = new Hashtable();

                //Lineas con detalles especificos por metodo.
                reg.Add("Nombre", para.nombre.ToString());
                reg.Add("Valor", para.valor.ToString());

                //Nuevos valores de la tupla a actualizar.
                crit.Add("Nombre", para.nombre.ToString());

                opciones.ModificarRegistro(NomTabla, crit, reg);
                //    MessageBox.Show("Parametro Modificado Satisfactoriamente'¡¡¡¡¡");
                cargarParametros();
            }
        }
        private void btnmodificarsucursal_Click(object sender, EventArgs e)
        {
            if (this.txtCodSucur.Text == "") { MessageBox.Show("Debe llenar el campo Codigo o elija un registro de la tabla"); }
            else if (this.txtNombreSucur.Text == "") { MessageBox.Show("Debe llenar el campo Nombre o elija un registro de la tabla"); }
            else
            {
                sucursal sucu = new sucursal(txtCodSucur.Text, txtNombreSucur.Text);

                //Lineas de codigos en comun para todos los metodos.
                opcionesdb opciones = new opcionesdb();
                String NomTabla = "Sucursal";
                Hashtable crit = new Hashtable();

                Hashtable reg = new Hashtable();

                //Lineas con detalles especificos por metodo.
                reg.Add("CodigoSucursal", sucu.Codigosucursal.ToString());
                reg.Add("Nombre", sucu.Nombre.ToString());

                //Nuevos valores de la tupla a actualizar.
                crit.Add("CodigoSucursal", sucu.Codigosucursal.ToString());

                opciones.ModificarRegistro(NomTabla, crit, reg);
                //   MessageBox.Show("Sucursal Modificada Satisfactoriamente'¡¡¡¡¡");
                cargarSucursales();
            }
        }

        private void btnagregarsucursal_Click(object sender, EventArgs e)
        {
            if (this.txtCodSucur.Text == "") { MessageBox.Show("Debe llenar el campo Codigo"); }
            else if (this.txtNombreSucur.Text == "") { MessageBox.Show("Debe llenar el campo Nombre"); }
            else
            {
                sucursal sucu = new sucursal(txtCodSucur.Text, txtNombreSucur.Text);
                //Lineas de codigos en comun para todos los metodos.
                opcionesdb opciones = new opcionesdb();
                String NomTabla = "Sucursal";
                Hashtable crit = new Hashtable();

                //Lineas con detalles especificos por metodo.
                crit.Add("CodigoSucursal", sucu.Codigosucursal.ToString());
                crit.Add("Nombre", sucu.Nombre.ToString());

                opciones.InsertarRegistro(NomTabla, crit);
                //   MessageBox.Show("Sucursal Agregada Satisfactoriamente'¡¡¡¡¡");
                cargarSucursales();

            }
        }

        private void btneliminarsucursal_Click(object sender, EventArgs e)
        {
            if (this.txtCodSucur.Text == "") { MessageBox.Show("Debe llenar el campo Codigo o elija un registro de la tabla"); }
            else if (this.txtNombreSucur.Text == "") { MessageBox.Show("Debe llenar el campo Nombre o elija un registro de la tabla"); }
            else
            {
                sucursal sucu = new sucursal(txtCodSucur.Text, txtNombreSucur.Text);
                //Lineas de codigos en comun para todos los metodos.
                opcionesdb opciones = new opcionesdb();
                String NomTabla = "Sucursal";
                Hashtable crit = new Hashtable();

                //Lineas con detalles especificos por metodo.
                crit.Add("CodigoSucursal", sucu.Codigosucursal.ToString());
                crit.Add("Nombre", sucu.Nombre.ToString());

                opciones.EliminarRegistro(NomTabla, crit);
                //    MessageBox.Show("Sucursal Eliminada Satisfactoriamente'¡¡¡¡¡");
                cargarSucursales();
            }
        }
    }
}
