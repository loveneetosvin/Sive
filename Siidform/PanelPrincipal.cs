using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siidform
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NuevaEmpresa nuevaEmp = new NuevaEmpresa();
            nuevaEmp.MdiParent= this;
            nuevaEmp.Show();
        }

        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ModificarEmpresa ModE = new ModificarEmpresa();
            ModE.MdiParent = this;
            ModE.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            EliminarEmpresa EliminarE = new EliminarEmpresa();
            EliminarE.MdiParent = this;
            EliminarE.Show();
        }

        private void introducirInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
           IntroducirInventario IntInventario = new IntroducirInventario();
           IntInventario.MdiParent = this;
           IntInventario.Show();
        }

        private void modificarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ModificarInventario ModInventario = new ModificarInventario();
            ModInventario.MdiParent = this;
            ModInventario.Show();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NuevoProveedor Nproveedor = new NuevoProveedor();
            Nproveedor.MdiParent = this;
            Nproveedor.Show();
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ModificarProveedor Mproveedor = new ModificarProveedor();
            Mproveedor.MdiParent = this;
            Mproveedor.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            EliminarProveedor Eproveedor = new EliminarProveedor();
            Eproveedor.MdiParent = this;
            Eproveedor.Show();
        }

        private void listarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListarProveedor Lproveedor = new ListarProveedor();
            Lproveedor.MdiParent = this;
            Lproveedor.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NuevoCliente NCliente = new NuevoCliente();
            NCliente.MdiParent = this;
            NCliente.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ModificarCliente MCliente = new ModificarCliente();
            MCliente.MdiParent = this;
            MCliente.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            EliminarCliente ECliente = new EliminarCliente();
            ECliente.MdiParent = this;
            ECliente.Show();
        }

        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListarCliente LCliente = new ListarCliente();
            LCliente.MdiParent = this;
           LCliente.Show();
        }

        private void kardexMesualPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            KardexMensual KMensual = new KardexMensual();
            KMensual.MdiParent = this;
            KMensual.Show();
        }

        private void resumenMensualTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
           ResumenMensual RMensual = new ResumenMensual();
            RMensual.MdiParent = this;
            RMensual.Show();
        }

        private void resumenAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ResumenAnual RAnual = new ResumenAnual();
            RAnual.MdiParent = this;
            RAnual.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NuevoProducto Nproducto = new NuevoProducto();
            Nproducto.MdiParent = this;
            Nproducto.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ModificarProducto Mproducto = new ModificarProducto();
            Mproducto.MdiParent = this;
            Mproducto.Show();
        }

        private void eliminarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            EliminarProducto Eproducto = new EliminarProducto();
            Eproducto.MdiParent = this;
            Eproducto.Show();
        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListarProducto Lproducto = new ListarProducto();
            Lproducto.MdiParent = this;
            Lproducto.Show();
        }

        private void elegirEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ElegirEmpresa ele = new ElegirEmpresa();
            ele.MdiParent = this;
            ele.Show();
        }
    }
}
