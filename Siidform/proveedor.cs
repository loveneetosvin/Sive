using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class proveedor
    {
        String codigoProveedor;
        String nombre;

        public proveedor(String codigoProveedo, String nombr)
        {
            this.codigoProveedor = codigoProveedo;
            this.nombre = nombr;
        }

        public String CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
