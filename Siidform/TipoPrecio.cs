using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class TipoPrecio
    {
        String tipoPrecio;
        String formula;

        public TipoPrecio(String formul, String tipoPreci)
        {
            this.TipoPrecio1 = tipoPreci;
            this.formula = formul;
        }

        public String TipoPrecio1
        {
            get { return tipoPrecio; }
            set { tipoPrecio = value; }
        }

        public String Formula
        {
            get { return formula; }
            set { formula = value; }
        }
    }
}
