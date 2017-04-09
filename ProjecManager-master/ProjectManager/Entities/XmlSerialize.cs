using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Exceptions;

namespace Entities
{
    public class XmlSerialize <T>
    {
        /// <summary>
        /// Serializa la lista de datos recibida en XML
        /// </summary>
        /// <param name="t">Lista a serializar</param>
        /// <param name="path">Ruta donde se alojara el archivo</param>
        /// <returns></returns>
        public bool SerializarXML(List<T> t, string path)
        {
            try
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<T>));
                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
                serial.Serialize(writer, t);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Desserializa un archivo XML en una lista recibida por parametros
        /// </summary>
        /// <param name="t">Lista en la que se guardan los datos del XML</param>
        /// <param name="path">Ruta donde esta el archivo a deserializar</param>
        /// <returns></returns>
        public List<T> DesSerializarXML(List<T> t, string path)
        {
            try
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<T>));
                StreamReader streamReader = new StreamReader(path);
                t = (List<T>)serial.Deserialize(streamReader);
                streamReader.Close();
                return t;
            }
            catch (Exception e)
            {
                throw new ArchivoInexistenteException(e.Message);
            }
        }
    }
}
