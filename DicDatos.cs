using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codebot
{
/*
 * clase de  diccionario de datos de mysql, en donde entrega el tipo de dato corresponde a c#
 * 
 * */
    public class DicDatos
    {
        public string tipoData(string data)
        {
            string[] tipo = data.Split('(');
            return DatoEs(tipo[0]);
        }
        private string DatoEs(string dato)
        {
            string tipo = "";
            switch (dato.ToLower())
            {
                case "varchar": tipo = "string"; break;
                case "Varchar": tipo = "string"; break;
                case "Longtext": tipo = "string"; break;
                case "longtext": tipo = "string"; break;
                case "Mediumtext": tipo = "string"; break;
                case "mediumtext": tipo = "string"; break;
                case "Text": tipo = "string"; break;
                case "text": tipo = "string"; break;
                case "Blob": tipo = "string"; break;
                case "blob": tipo = "string"; break;
                case "Enum": tipo = "string"; break;
                case "enum": tipo = "string"; break;
                case "Set": tipo = "string"; break;
                case "set": tipo = "string"; break;
                case "char": tipo = "char"; break;
                case "Char": tipo = "char"; break;
                case "Tinyint": tipo = "uint"; break;
                case "tinyint": tipo = "uint"; break;
                case "float": tipo = "float"; break;
                case "xreal": tipo = "double"; break;
                case "double": tipo = "double"; break;
                case "smallint": tipo = "int"; break;
                case "mediumint": tipo = "int"; break;
                case "integer": tipo = "int"; break;
                case "int": tipo = "int"; break;
                case "bigint": tipo = "int"; break;
                case "date": tipo = "DateTime"; break;
                case "datetime": tipo = "DateTime"; break;
                case "timestamp": tipo = "DateTime"; break;
                case "time": tipo = "DateTime"; break;
                case "year": tipo = "DateTime"; break;
                case "bool": tipo = "bool"; break;
                case "boolean": tipo = "Boolean"; break;
                case "bit": tipo = "bool"; break;
                case "decimal": tipo = "decimal"; break;
                case "longblob": tipo = "string"; break;
            }
            return tipo;
        }
        public object valorBase(string tipo)
        {
            object a = null;
            switch (tipo)
            {
                case "string": a = "\"\""; break;
                case "char": a = "\' \'"; break;
                case "uint": a = "0"; break;
                case "float": a = "0f"; break;
                case "double": a = "0"; break;
                case "int": a = "0"; break;
                case "DateTime": a = "DateTime.Today"; break;
                case "bool": a = "false"; break;
                case "Boolean": a = "false"; break;
                case "decimal": a = "decimal.Zero"; break;
            }
            return a;
        }
        public object ConvercionBase(string tipo)
        {
            object a = null;
            switch (tipo)
            {
                case "float": a = "("; break;
                case "string": a = "Convert.ToString("; break;
                case "char": a = "Convert.ToChar("; break;
                case "uint": a = "Convert.ToUInt32("; break;
                case "double": a = "Convert.ToDouble("; break;
                case "int": a = "Convert.ToInt32("; break;
                case "DateTime": a = "Convert.ToDateTime("; break;
                case "bool": a = "Convert.ToBoolean("; break;
                case "Boolean": a = "Convert.ToBoolean("; break;
                case "decimal": a = "Convert.ToDecimal("; break;
            }
            return a;
        }
    }
}
