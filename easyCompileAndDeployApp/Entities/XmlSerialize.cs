using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    public class XmlSerialize <T>
    {
        
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
                throw new Exception(e.Message);
            }
        }
    }
}
