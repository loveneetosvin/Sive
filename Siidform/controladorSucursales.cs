using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Siidform
{
    class controladorSucursales
    {
        public sucursal[] obtenerSucursales()
        {
            //Lineas de codigos en comun para todos los metodos.
            opcionesdb opciones = new opcionesdb();
            String NomTabla = "sucursal";
            //Lineas con detalles especificos por metodo.

            DataTable tab = new DataTable();
            tab = opciones.ObtenerTodasTuplas(NomTabla);
            int tamanio = tab.Rows.Count;


            sucursal[] coleccionSucursales = new sucursal[tamanio];

            for (int j = 0; j < tamanio; j++)
            {
                DataRow row = tab.Rows[j];
                sucursal sucur = new sucursal(row["CodigoSucursal"].ToString(), row["nombre"].ToString());
                coleccionSucursales[j] = sucur;
            }
            return coleccionSucursales;
        }
    }
}
