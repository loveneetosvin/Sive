using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Siidform
{
    class controladorProducto
    {
        public void agregar(producto product)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "productos";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoBarra", product.CodigoBarra.ToString());
            crit.Add("Nombre", product.Nombre.ToString());

            opciones.InsertarRegistro(NomTabla, crit);

        }

        public producto obtener(String CodBarra)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "productos";
            Hashtable crit = new Hashtable();
            Hashtable reg = new Hashtable();
            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoBarra", CodBarra);
            reg.Add("CodigoBarra", "CodigoBarra");
            reg.Add("nombre", "nombre");

            DataTable tab = new DataTable();
            tab = opciones.BuscarRegistro(NomTabla, crit, reg);
                producto pro = new producto("", "");
                if (tab.Rows.Count > 0)
                {
                    DataRow row = tab.Rows[0];
                    pro = new producto(row["CodigoBarra"].ToString(), row["nombre"].ToString());
                    //   MessageBox.Show(row["nombre"].ToString());            
                    return pro;
                }
                else {
                    return pro;
                }
        }


        public void modificar(producto product)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "productos";
            Hashtable crit = new Hashtable();

            Hashtable reg = new Hashtable();

            //Lineas con detalles especificos por metodo.
            reg.Add("CodigoBarra", product.CodigoBarra.ToString());
            reg.Add("Nombre", product.Nombre.ToString());

            //Nuevos valores de la tupla a actualizar.
            crit.Add("CodigoBarra", product.CodigoBarra.ToString());

            opciones.ModificarRegistro(NomTabla, crit, reg);
        }

        public void eliminar(producto product)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "productos";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("CodigoBarra", product.CodigoBarra.ToString());
            crit.Add("Nombre", product.Nombre.ToString());

            opciones.EliminarRegistro(NomTabla, crit);
        }
    }
}
