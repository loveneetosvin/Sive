using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siidform
{
    class arrayRadGridView
    {
        public rowGridView[] radGridView { get; set; }
        public arrayRadGridView(params rowGridView[] tabla)
        {
            this.radGridView = tabla;
        }


    }
}
