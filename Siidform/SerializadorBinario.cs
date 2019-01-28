using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Siidform
{
    public class SerializadorBinario
    {
        private FileStream archivo;
        private BinaryFormatter serializador;
        private String logerror;


        public bool SerializarArchivo(String ruta, Object obj)
        {
            try
            {
                serializador = new BinaryFormatter();

                archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.Write);
                serializador.Serialize(archivo, obj);

                return true;
            }
            catch (Exception ex)
            {
                this.logerror = ex.Message;
                return false;
            }
        }

        public Object DesserializarArchivo(String ruta)
        {
            try
            {
                serializador = new BinaryFormatter();
                FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Write);
                Object obj;
                obj = serializador.Deserialize(archivo);
                return obj;
            }
            catch (Exception ex)
            {
                this.logerror = ex.Message;
                return new object();
            }

        }

        public String Logerror
        {
            get { return logerror; }
            set { logerror = value; }
        }

    }
}
