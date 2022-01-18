using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace Codebot
{
    public class claseBD
    {
        #region variables Internas
        public string _base { get; set; }
        public string _server { get; set; }
        public string _user { get; set; }
        public string _pass { get; set; }
        public string _port { get; set; }
        #endregion
        
        #region Inicializadores de clases
        private string Base{get { return _base;}set { _base = value; }}
        private string Server { get { return _server; } set { _server = value; } }
        private string User { get { return _user; } set { _user = value; } }
        private string Pass { get { return _pass; } set { _pass = value; } }
        private string Port { get { return _port; } set { _port = value; } }
        #endregion
       // public string cad_Coneccion { get; set; }
        public void cargarDatosConexion()
        {
            try
            {
                string cadena_coneccion = "Data Source=" + Server + ";Database=" + Base + ";Uid=" + User + ";Pwd='" + Pass + "';port=" + Port+";";
                conex = new MySqlConnection(cadena_coneccion);

            }
            catch { }
        }
      /*  public static MySqlConnection conex = new MySqlConnection("Server=192.168.0.110;Database=bdfrutosdelpais;Uid=dualsoft;Pwd='76552'");*/
        public static MySqlConnection conex;// new MySqlConnection("Server=;Database=db_patagonia;Uid=root;Pwd=''");
        public MySqlCommand Comando = new MySqlCommand();
        public MySqlDataReader Rec;
        public claseBD()
        {

                cargarDatosConexion();
            if (conex.State == ConnectionState.Open)
            {
                conex.Close();
            }
            conex.Open();
           
        }

        public DataTable Select_datatable(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                AbrirConexion();
                MySqlCommand command = conex.CreateCommand();
                ((DbCommand)command).CommandText = sql;
                ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
                CerrarConexion();
            }
            catch (Exception ex)
            {
            }
            return dataTable;
        }
        public void AbrirConexion()
        {
            //cargarDatosConexion();
            if (conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
                //MessageBox.Show("Conexión Establecida");
            }
            //else if (conex.State == ConnectionState.Open)
            //{
            //    conex.Close();
            //   // conex.Open();
            //}
        }
        public void CerrarConexion()
        {
            if (conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }

        public int EjecutarIUD(string CadSql)
        {
            int Filas = 0;
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Filas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();

            }


            return (Filas);


        }

        public int EjecutarIUD2(string CadSql)
        {
            int Filas = 0;
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Filas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                CerrarConexion();

            }


            return (Filas);


        }
     
        public MySqlDataReader EjecutarConsulta(String CadSql)
        {
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Rec = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Rec = null;
            }
            return (Rec);

        }
        public MySqlDataReader EjecutarConsulta2(String CadSql)
        {
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Rec = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
               
                Rec = null;
                CerrarConexion();
            }
            return (Rec);

        }

       
    }
}
