using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace Siidform
{
    class controladorTipoPrecio
    {
        public TipoPrecio[] obtener()
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "TipoPrecio";
            //Lineas con detalles especificos por metodo.

            DataTable tab = new DataTable();
            tab = opciones.ObtenerTodasTuplas(NomTabla);
            int tamanio = tab.Rows.Count;


            TipoPrecio[] coleccionTipoPrecio = new TipoPrecio[tamanio];

            for (int j = 0; j < tamanio; j++)
            {
                DataRow row = tab.Rows[j];
                TipoPrecio tipoPrec = new TipoPrecio(row["TipoPrecio"].ToString(), row["Formula"].ToString());
                coleccionTipoPrecio[j] = tipoPrec;
            }
            return coleccionTipoPrecio;
        }

        public void modificar(TipoPrecio TipoPrec)
        {
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
        }

        public void eliminar(TipoPrecio TipoPrec)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "TipoPrecio";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("TipoPrecio", TipoPrec.TipoPrecio1.ToString());
            crit.Add("Formula", TipoPrec.Formula.ToString());

            opciones.EliminarRegistro(NomTabla, crit);
        }

        public void agregar(TipoPrecio TipoPrec)
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "TipoPrecio";
            Hashtable crit = new Hashtable();

            //Lineas con detalles especificos por metodo.
            crit.Add("TipoPrecio", TipoPrec.TipoPrecio1.ToString());
            crit.Add("Formula", TipoPrec.Formula.ToString());

            opciones.InsertarRegistro(NomTabla, crit);
        }
    }
}
