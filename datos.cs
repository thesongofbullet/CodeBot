using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Codebot
{
    public class datos
    {
        private Conexiondb _conecciondb = new Conexiondb();

        public Conexiondb Conexion
        {
            get { return this._conecciondb; }
            set { this._conecciondb = value; }
        }
        public string Serializar()
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.GetEncoding("ISO-8859-1");
            settings.Indent = true;
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            string str = @"C:\CodeBot\xml\";
            XmlWriter xmlWriter = XmlWriter.Create(str + "config.XML", settings);
            xmlSerializer.Serialize(xmlWriter, (object)this, namespaces);
            xmlWriter.Close();
            return (string)null;
        }
    }
}
