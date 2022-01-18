using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Codebot
{
    [XmlRoot(ElementName = "Conexion")]
    public class Conexiondb
    {
        public string Empresa { get; set; }
        public string Server { get; set; }
        public string Base { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Port { get; set; }
        public Conexiondb()
        {
            this.Empresa = "";
            this.Pass = "";
            this.Port = "";
            this.Server = "";
            this.User = "";
            this.Base = "";
        }
    }
}
