using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class precio
    {
        TipoPrecio[] tipoPrecio;
        double monto;

        internal TipoPrecio[] TipoPrecio
        {
            get { return tipoPrecio; }
            set { tipoPrecio = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

    }
}
