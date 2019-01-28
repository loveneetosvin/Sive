using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Siidform
{
    class parametros
    {
        String Nombre;
        String Valor;


        public parametros(String nombre, String valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;

        }
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public String valor
        {
            get { return Valor; }
            set { Valor = value; }
        }


       

    }
}
