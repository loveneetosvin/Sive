using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Siidform
{
    class coneccionAbaseDeDatos
    {
        private SqlConnection Con; // Obj Conexion

        public coneccionAbaseDeDatos()
        {
            string DtsConection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Inventario; " + "Integrated Security=True;";
            Con = new SqlConnection(DtsConection);
        }

        public void conectar() // Metodo para Abrir la Conexion
        {
            Con.Open();
        }

        public void desconectar() // Metodo para Cerrar la Conexion
        {
            if (Con != null)
            {
                Con.Close();
            }
        }

        public SqlConnection ConexBase
        {
            get { return this.Con; }
        }

        //public DataSet Ejecutar(string Comando, string Tabla) // Metodo para Ejecutar Comandos
        //{
        //    SqlDataAdapter CMD = new SqlDataAdapter(Comando, Con); // Creamos un DataAdapter con el Comando y la Conexion
        //    DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
        //    CMD.Fill(DS, Tabla); // Ejecutamos el Comando en la Tabla
        //    return DS; // Regresamos el DataSet
        //}

    }
}
