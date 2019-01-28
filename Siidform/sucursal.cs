using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class sucursal
    {
        String codigosucursal;
        String nombre;

        public sucursal(String codigosucursa, String nombr)
        {
            this.codigosucursal = codigosucursa;
            this.nombre = nombr;
        }

        public String Codigosucursal
        {
            get { return codigosucursal; }
            set { codigosucursal = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
