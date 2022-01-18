using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Codebot
{
    public class login
    {
        [XmlElement]
        public string usu { get; set; }
        [XmlElement]
        public string tip { get; set; }

        public string Serializar()
        {
            string ruta = "C:\\pos\\login.xml";
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.GetEncoding("ISO-8859-1");
            settings.Indent = true;
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            XmlWriter xmlWriter = XmlWriter.Create( ruta, settings);
            xmlSerializer.Serialize(xmlWriter, (object)this, namespaces);
            xmlWriter.Close();
            return ruta;
        }
    }
}
