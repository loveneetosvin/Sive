using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;


namespace Siidform
{
    class controladorProveedores
    {
        public void agregar(proveedor proveedo)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "proveedores";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoProvedor", proveedo.CodigoProveedor.ToString());
            crit.Add("Nombre", proveedo.Nombre.ToString());

            opciones.InsertarRegistro(NomTabla, crit);
        }

        public proveedor[] obtener()
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "proveedores";
            //Lineas con detalles especificos por metodo.

            DataTable tab = new DataTable();
            tab = opciones.ObtenerTodasTuplas(NomTabla);
            int tamanio = tab.Rows.Count;


            proveedor[] coleccionProveedores = new proveedor[tamanio];

            for (int j = 0; j < tamanio; j++)
            {
                DataRow row = tab.Rows[j];
                proveedor prove = new proveedor(row["CodigoProvedor"].ToString(), row["Nombre"].ToString());
                coleccionProveedores[j] = prove;
            }
            return coleccionProveedores;
        }

        public void modificar(proveedor proveedo)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "proveedores";
            Hashtable crit = new Hashtable();

            Hashtable reg = new Hashtable();

            //Lineas con detalles especificos por metodo.
            reg.Add("CodigoProvedor", proveedo.CodigoProveedor.ToString());
            reg.Add("Nombre", proveedo.Nombre.ToString());

            //Nuevos valores de la tupla a actualizar.
            crit.Add("CodigoProvedor", proveedo.CodigoProveedor.ToString());

            opciones.ModificarRegistro(NomTabla, crit, reg);
        }

        public void eliminar(proveedor proveedo)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "proveedores";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoProvedor", proveedo.CodigoProveedor.ToString());
            crit.Add("Nombre", proveedo.Nombre.ToString());

            opciones.EliminarRegistro(NomTabla, crit);
        }
        public proveedor[] obtenerFiltro(string tex)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "proveedores";
            String NomCampo = "Nombre";
            ArrayList array = new ArrayList();
            array.Add("CodigoProvedor");
            array.Add("Nombre");
            //Lineas con detalles especificos por metodo.

            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistroAutoincremetable(NomTabla,NomCampo,array,tex);
            int tamanio = tab.Rows.Count;


            proveedor[] coleccionProveedores = new proveedor[tamanio];

            for (int j = 0; j < tamanio; j++)
            {
                DataRow row = tab.Rows[j];
                proveedor prove = new proveedor(row["CodigoProvedor"].ToString(), row["Nombre"].ToString());
                coleccionProveedores[j] = prove;
            }
            return coleccionProveedores;
        }
    }
}
