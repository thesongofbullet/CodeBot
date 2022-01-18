using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebot
{
    public class Conexion
    {
        private static Conexion conecta = (Conexion)null;
        private MySqlConnection conexionMySql;
        private string _server;
        private string _user;
        private string _pass;
        private string _base;
        private string _port;
        private static string _empresa;

        public MySqlConnection ConexionMySql
        {
            get
            {
                return this.conexionMySql;
            }
            set
            {
                this.conexionMySql = value;
            }
        }

        private Conexion()
        {
            this.cargarDatos();
            this.conexionMySql = new MySqlConnection("Database=" + this._base + "; Data Source=" + this._server + "; User Id=" + this._user + "; Password=" + this._pass + "; port=" + this._port + ";");
            ((DbConnection)this.conexionMySql).Open();
        }
        //public conexion()
        //{
        //    this.cargarDatos();
        //    this.conexionMySql = new MySqlConnection("Database=" + this._base + "; Data Source=" + this._server + "; User Id=" + this._user + "; Password=" + this._pass + "; port=" + this._port + ";");
        //    ((DbConnection)this.conexionMySql).Open();
        //}

        public Conexion(string s, string b, string u, string p, string port)
        {
            this.conexionMySql = new MySqlConnection("Database=" + b + "; Data Source=" + s + "; User Id=" + u + "; Password=" + p + "; port=" + port + ";");
            ((DbConnection)this.conexionMySql).Open();
        }

        private bool cargarDatos()
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\CodeBot\xml\config.xml");
                string filterExpression = "";
                DataRow[] dataRowArray = dataSet.Tables["Conexion"].Select(filterExpression);
                for (int index = 0; index < dataRowArray.Length; ++index)
                {
                    this._server = dataRowArray[index]["Server"].ToString();
                    this._base = dataRowArray[index]["Base"].ToString();
                    this._user = dataRowArray[index]["User"].ToString();
                    this._pass = dataRowArray[index]["Pass"].ToString();
                    this._port = (dataRowArray[index]["Port"].ToString().Length > 0 ? dataRowArray[index]["port"].ToString() : "3306");
                    Conexion._empresa = dataRowArray[index]["Empresa"].ToString();
                }
                return true;
            }
            catch
            {
                this.creaXML();
                return false;
            }
        }

        private void creaXML()
        {
            new datos().Serializar();
        }

        public static Conexion getConecta()
        {
            if (Conexion.conecta == null)
                Conexion.conecta = new Conexion();
            if (((DbConnection)Conexion.conecta.conexionMySql).State != ConnectionState.Open)
                Conexion.conecta = new Conexion();
            return Conexion.conecta;
        }

        public static Conexion reconexion()
        {
            Conexion.conecta.cerrarConexion();
            Conexion.conecta = new Conexion();
            return Conexion.conecta;
        }

        public Conexion pruebaConexion()
        {
            if (Conexion.conecta == null)
                Conexion.conecta = new Conexion();
            return Conexion.conecta;
        }
        //public static Conexion pruebaConexion(string s, string b, string u, string p, string port)
        //{
        //    if (Conexion.conecta == null)
        //        Conexion.conecta = new Conexion(s, b, u, p, port);
        //    return Conexion.conecta;
        //}
        public void cerrarConexion()
        {
            ((DbConnection)this.conexionMySql).Close();
            Conexion.conecta = (Conexion)null;
        }
    }
}
