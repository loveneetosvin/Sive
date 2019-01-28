using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    public class producto
    {
        String codigoBarra;
        String nombre;

        public producto(string codigoBarra, string nombre)
        {
            this.codigoBarra = codigoBarra;
            this.nombre = nombre;
        }

        public String CodigoBarra
        {
            get { return codigoBarra; }
            set { codigoBarra = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
