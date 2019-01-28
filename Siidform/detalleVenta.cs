using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class detalleVenta
    {
        producto[] pro;
        int correlativo;
        double costo;
        double precioVenta;
        double precioMenorVenta;

        public double PrecioMenorVenta
        {
            get { return precioMenorVenta; }
            set { precioMenorVenta = value; }
        }

        public producto[] Pro
        {
            get { return pro; }
            set { pro = value; }
        }

        public int Correlativo
        {
            get { return correlativo; }
            set { correlativo = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }


    }
}