using System;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System.Data;

namespace Codebot
{
    public partial class frmPrincipal : Form
    {
        private frmPrincipal instance;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        //frmInicioSesion IS = new frmInicioSesion();

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.timer1.Start();
            try
            {
                cargarDatosConexion();
            }
            catch
            {

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        internal DataTable crearTablaColumnas()
        {
            DataTable alfa = new DataTable();
            alfa.Columns.Add("Selecionar", typeof(bool)).ReadOnly = false;
            alfa.Columns.Add("Columnas", typeof(string)).ReadOnly = true;
            alfa.Columns.Add("Tipo", typeof(string)).ReadOnly = true;
            alfa.Columns.Add("Unique", typeof(string)).ReadOnly = true;
            return alfa;
        }
        private void llenarDgvColumns()
        {
            dgvcolumnas.DataSource = null;


            string query = "show fields from " + txtDb.Text + "." + dgvtablas.CurrentRow.Cells[""].Value.ToString() + "; ";
            MySqlCommand coma = Conexion.getConecta().ConexionMySql.CreateCommand();
            coma.CommandText = query;
            coma.CommandType = CommandType.Text;
            MySqlDataReader Rec = coma.ExecuteReader();

                    DataTable alfa = new DataTable();
                    alfa.Columns.Add("Selecionar", typeof(bool)).ReadOnly = false ;
                    alfa.Columns.Add("Columnas", typeof(string)).ReadOnly = true;
                    alfa.Columns.Add("Tipo", typeof(string)).ReadOnly = true;
                    alfa.Columns.Add("Unique", typeof(string)).ReadOnly = true;
                    while (Rec.Read())
                    {
                        DataRow beta =  alfa.NewRow();
                        beta["Columnas"] = Rec["Field"].ToString();
                        beta["Tipo"] = Rec["Type"].ToString();
                        beta["Unique"] = Rec["Key"].ToString();
                        alfa.Rows.Add(beta);

                    }
            Rec.Close();
                    dgvcolumnas.DataSource = alfa;

        }
        //claseBD cbd = new claseBD();
        //        string insertar = "insert into estadofact values ('" + mskRUT.Text + "','" + lblNumFact.Text + "','"+comboBox2.Text+"','$0','" + dateTimePicker1.Text+ "','" + txtVencimiento.Text + "')";
        //        cbd.EjecutarIUD2(insertar);
        private void llenarDgv()
        {
            string CadSql ="" ;

            //claseBD CBd = new claseBD() { 
            //    _base = txtDb.Text, 
            //    _pass = txtpass.Text, 
            //    _port = txtport.Text, 
            //    _server = txtIp.Text,
            //    _user = txtuser.Text
            //};
            int fila;

                 string query  =  "show tables from " + txtDb.Text + "";
            MySqlCommand coma = Conexion.getConecta().ConexionMySql.CreateCommand();
            coma.CommandText = query;
            coma.CommandType = CommandType.Text;

            MySqlDataReader Rec = coma.ExecuteReader();
                dgvtablas.RowCount = 0;
                while (Rec.Read())
                {
                    dgvtablas.RowCount = dgvtablas.RowCount + 1;
                    fila = dgvtablas.RowCount - 1;
                    dgvtablas.Rows[fila].Cells[0].Value = Rec["Tables_in_"+txtDb.Text].ToString();


                }
            Rec.Close();

        }
        public string cad_coneccion {get; set;}
        internal bool valida()
        {

            bool _bas = (txtDb.Text.Length > 0 && txtDb.Text != "" && txtDb.Text != null ? true : false);
            bool _ip = (txtIp.Text.Length > 0 && txtIp.Text != "" && txtIp.Text != null ? true : false);
            bool _port = (txtport.Text.Length > 0 && txtport.Text != "" && txtport.Text != null ? true : false);
            bool _pass = (txtpass.Text.Length > 0 && txtpass.Text != "" && txtpass.Text != null ? true : false);
            bool _use = (txtuser.Text.Length > 0 && txtuser.Text != "" && txtuser.Text != null ? true : false);
            bool salida = false;
            if (_bas && _ip && _port && _pass && _use)
            {
                salida = true;
            }
            return salida;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                datos dato = new datos();
                dato.Conexion.Base = txtDb.Text;
                dato.Conexion.Empresa = "";
                dato.Conexion.Pass = txtpass.Text;
                dato.Conexion.Port = txtport.Text;
                dato.Conexion.Server = txtIp.Text;
                dato.Conexion.User = txtuser.Text;
                dato.Serializar();

                if (Conexion.getConecta().pruebaConexion().ConexionMySql.State == ConnectionState.Open)
                {
                    MessageBox.Show("conectado");
                    llenarDgv();
                }
                else
                {
                    MessageBox.Show("No conectado");
                }
            }
            else
            {
                MessageBox.Show("hay Campos En Blanco");
            }
        }

        private void dgvtablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDgvColumns();
            lbltabla.Text = dgvtablas.CurrentRow.Cells[""].Value.ToString();
            checkBox5.Checked = false;
        }

        private void dgvtablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDgvColumns();
            try
            {
                lbltabla.Text = dgvtablas.CurrentRow.Cells["TABLA"].Value.ToString();
            }
            catch { }
            checkBox5.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (chkSelect.Checked || chkdelete.Checked || chkupdate.Checked || chkinsert.Checked)
            {
                SelecionDeFunciones(chkinsert.Checked, chkdelete.Checked, chkSelect.Checked, chkupdate.Checked);
            }
            else
            {
                MessageBox.Show("Debe Selecionar Al Menos Una Funcion");
            }
        }
        internal void SelecionDeFunciones(bool insert, bool delete, bool select, bool update)
        {
            try {
                string codigo = "";
                if (insert)
                {
                    setFuncion("insert");
                    codigo += code.Text + "\r";
                    code.Clear();
                }
                if (select)
                {
                    setFuncion("select");
                    codigo += code.Text + "\r";
                    code.Clear();
                }
                if (delete)
                {
                    setFuncion("delete");
                    codigo += code.Text + "\r";
                    code.Clear();
                }
                if (update)
                {
                    setFuncion("update");
                    codigo += code.Text + "\r";
                    code.Clear();
                }

                code.Text = ("public class Data" + lbltabla.Text + "{\r") + codigo + "\r}";
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void setFuncion(string who) {
            switch (who)
            {
                case "select" :
                    crearSelect();
                    break;
                case "delete":
                    crearDelete();
                    break;
                case "update":
                    crearUpdate();
                    break;
                case "insert":
                    crearInsert();
                    break;
            }
        }

        string serializar = "public string Serializar(){\r string name = \"\";\r" +
            "SaveFileDialog sf = new SaveFileDialog();\rsf.Filter = \"Archivo xml|*.xml\";"+
            "\rsf.AddExtension = true;\rif(sf.ShowDialog() == DialogResult.OK)\r{\r name = sf.FileName;\r"+
"XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();\r" +
"namespaces.Add(string.Empty, string.Empty);\r" +
"XmlWriterSettings settings = new XmlWriterSettings();\r" +
"settings.Encoding = Encoding.GetEncoding(\"ISO-8859-1\");\r" +
"settings.Indent = true;\r" +
"XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());\r" +
"XmlWriter xmlWriter = XmlWriter.Create(name, settings);\r" +
"xmlSerializer.Serialize(xmlWriter, (object)this, namespaces);\r" +
"xmlWriter.Close();\r\r }" +
"return (string)null;}\r";
        #region Funciones
        internal void crearInsert()
        {
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand command = Conexion.getConecta().ConexionMySql.CreateCommand(); "+ "\n command.CommandText = query; \ncommand.CommandType = CommandType.Text; ";
            string  ejecuta = "command.ExecuteNonQuery();";
            string rec = "while(Filas.Read()){"; string endread = "}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string serializarXml = lbltabla.Text + " a  = new " + lbltabla.Text + "();\n";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";


                        serializarXml += "a." + dr["Columnas"] + "= " + (new DicDatos().valorBase(new DicDatos().tipoData(dr["Tipo"].ToString()))).ToString() + ";\n";

                        valores += "@" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\n\rpublic "/* + lbltabla.Text */+ "void Insertar" + lbltabla.Text + "( " + lbltabla.Text
             + " datos )\r\n{\r\n" /*+ instanciaClase */+
            ///tipo de query
            " string query = \r\n\" insert into "
            ///
            + lbltabla.Text +
            " (" + campos + ") values (" +
            valores
            + ");\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta + /*"\r\n" + rec + endread + captura + "\r\n return datos;*/"\r\n}";
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text = ClaseData + "\r\n" + dataTipe + "\r\n"+serializar+"\r}";
            Serializar.Text = serializarXml;
        }
        internal void crearSelect()
        {
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand command = Conexion.getConecta().ConexionMySql.CreateCommand(); " + "\n command.CommandText = query; \ncommand.CommandType = CommandType.Text; ";
            string ejecuta = "MySqlDataReader Filas = command.ExecuteReader();";
            string rec = "while(Filas.Read()){"; string endread = " Filas.Close();}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string trys = "try{";
            string serializarXml = lbltabla.Text + " a  = new " + lbltabla.Text + "();\n";
            string captura = "}catch(Exception ex){MessageBox.show(ex.message);}";
            string linea = "";
            string ClaseData = "public class "+lbltabla.Text+"{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text +" datos = new "+lbltabla.Text+"();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public "+ new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valores += "@" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") +commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";

                        serializarXml += "a." + dr["Columnas"] + "= " + (new DicDatos().valorBase(new DicDatos().tipoData(dr["Tipo"].ToString()))).ToString() + ";\n";

                        //convert automaticos

                        string convert = new DicDatos().ConvercionBase( new DicDatos().tipoData( dr["Tipo"].ToString())).ToString() ;///  ? "Convert.ToInt32(" : "");

                        //para los select
                        rec += (salto <1 ? "\r":"")+ "datos."+dr["Columnas"] +"= "+
                            convert+" Filas[\"" + dr["Columnas"] + "\"].ToString()"+
                            (convert.Length >0 ? ")":"")+";\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\n\rpublic " + lbltabla.Text+ " Selecionar" + lbltabla.Text + "(" + /*
            parametros + */")\r\n{\r\n" +instanciaClase +
            ///tipo de query
            " string query = \" select * from " 
            ///
            + lbltabla.Text/* +
            " (" + campos + ")\r\nvalues (" +
            valores*/
            + "\";\r\n" + completemento + "\r\n" +/* linea + "\r\n" +*/
            ejecuta +"\r\n"+ rec + endread + "\r\n return datos;\r\n}"; 
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text= ClaseData + "\r\n" + dataTipe + "\r\n"+serializar+"\r}";
            Serializar.Text = serializarXml;
        }
        internal void crearUpdate()
        {
            //crear metodo 
            //Crear metodo de eliminacion mediante la  primary key
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";
            string valoresWhere = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand command = Conexion.getConecta().ConexionMySql.CreateCommand(); " + "\n command.CommandText = query; \ncommand.CommandType = CommandType.Text; ";
            string ejecuta = " command.ExecuteNonQuery();";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            string serializarXml = lbltabla.Text+ " a  = new "+lbltabla.Text+"();\n";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false && dr["Unique"].ToString() == "PRI")
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        serializarXml += "a."+ dr["Columnas"] + "= " +  (new DicDatos().valorBase(new DicDatos().tipoData(dr["Tipo"].ToString()))).ToString()+";\n";

                        valoresWhere += (dr["Unique"].ToString() == "PRI" ? dr["Columnas"] + "= @" + dr["Columnas"] : "") + ",";
                        valores += dr["Columnas"] + "= @" + dr["Columnas"] + ",";
                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";
                        salto++;
                    }
                    else
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        serializarXml += "a." + dr["Columnas"] + "= " + (new DicDatos().valorBase(new DicDatos().tipoData(dr["Tipo"].ToString()))).ToString() + ";\n";

                        valores += dr["Columnas"] + "= @" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";

                        salto++;
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            try {
                valores = valores.Substring(0, valores.Length - 1);
                parametros = parametros.Substring(0, parametros.Length - 1);
                campos = campos.Substring(0, campos.Length - 1);
                valoresWhere = valoresWhere.Substring(0, valoresWhere.Length - 1);
            }catch { MessageBox.Show("Es Necesaria Una Primary key Para hacer La Funcion UPDATE"); code.Clear(); return; }
            //se arma el metodo a usar 
            code.Text =
            "\n\rpublic "/* + lbltabla.Text*/ + "void Update"+ lbltabla.Text+" (" +
            lbltabla.Text + " datos)\r\n{\r\n"  +
            ///tipo de query
            " string query = \" update  "
            ///
            + lbltabla.Text +
            " set "+ valores+" where " +
            valoresWhere
            + ";\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta +"\r\n}";
            ClassDat.Text = ClaseData + "\r\n" + dataTipe  +"\r\n" + serializar + "\r}"; ;
            Serializar.Text = serializarXml;
        }
        internal void crearDelete()
        {
            //Crear metodo de eliminacion mediante la  primary key
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand command = Conexion.getConecta().ConexionMySql.CreateCommand(); " + "\n command.CommandText = query; \ncommand.CommandType = CommandType.Text; ";
            string ejecuta = "command.ExecuteNonQuery();";
            string rec = "while(Filas.Read()){"; string endread = "}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string trys = "try{";
            string serializarXml = lbltabla.Text + " a  = new " + lbltabla.Text + "();\n";
            string captura = "}catch(Exception ex){MessageBox.show(ex.message);}";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false && dr["Unique"].ToString() == "PRI")
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";
                        serializarXml += "a." + dr["Columnas"] + "= " + (new DicDatos().valorBase(new DicDatos().tipoData(dr["Tipo"].ToString()))).ToString() + ";\n";

                        valores += (dr["Unique"].ToString() == "PRI" ? "@" + dr["Columnas"] : "") + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\"," + dr["Columnas"] + colaComando + "\r";

                        //convert automaticos

                        // string convert = (new DicDatos().tipoData(dr["Tipo"].ToString()) == "int" ? "Convert.ToInt32(" : "");

                        //para los select
                        //rec += (salto < 1 ? "\r" : "") + "datos." + dr["Columnas"] + "= " +
                        //    convert + " Filas[\"" + dr["Columnas"] + "\"].ToString()" +
                        //    (convert.Length > 0 ? ")" : "") + ";\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            try
            {
                //se eliminan caracteres sobrantes
                valores = valores.Substring(0, valores.Length - 1);
    
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            }catch { MessageBox.Show("Es Necesaria Una Primary key Para hacer La Funcion DELETE"); code.Clear();   return; }
    //se arma el metodo a usar 
            code.Text =
            "\n\rpublic "/* + lbltabla.Text*/ + "void Eliminar(" +
            parametros + ")\r\n{\r\n"+ instanciaClase +
            ///tipo de query
            "\r\n string query = \" Delete from  "
            ///
            + lbltabla.Text +
            " where " + campos + " = " +
            valores
            + ";\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta + /*"\r\n" + rec + endread + captura + "\r\n return datos;*/"\r\n}";
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text = ClaseData + "\r\n" + dataTipe + "\r\n" + serializar + "\r}";
            Serializar.Text = serializarXml;
        }
        #endregion
        private void dgvcolumnas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDefaul_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadDefaul.Checked == true)
            {
                cargarDatosConexion();
            }
            else
            {
                //txtcode.Clear();
                txtDb.Clear();
                txtIp.Clear();
                txtpass.Clear();
                txtport.Clear();
                txtuser.Clear();
            }
        }
        public void cargarDatosConexion()
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\CodeBot\xml\config.xml");
                string filterExpression = "";
                DataRow[] row = dataSet.Tables["Conexion"].Select(filterExpression);
                txtDb.Text = row[0]["Base"].ToString();
                txtpass.Text = (row[0]["Pass"].ToString().Length > 0 ? row[0]["Pass"].ToString() : "");
                txtport.Text= row[0]["Port"].ToString();
                txtIp.Text = row[0]["Server"].ToString();
                txtuser.Text = row[0]["User"].ToString();


            }
            catch { }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void code_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }

        private void fastColoredTextBox2_Load(object sender, EventArgs e)
        {
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable temp = (DataTable)dgvcolumnas.DataSource;
                if (checkBox5.Checked)
                {
                    DataTable outT = crearTablaColumnas();
                    foreach (DataRow a in temp.Rows)
                    {
                        outT.Rows.Add(true, a[1], a[2], a[3]);
                    }
                    dgvcolumnas.DataSource = outT;
                }
                else
                {
                    DataTable outT = crearTablaColumnas();
                    foreach (DataRow a in temp.Rows)
                    {
                        outT.Rows.Add(false, a[1], a[2],a[3]);
                    }
                    dgvcolumnas.DataSource = outT;
                }
            }
            catch { }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmGestionReporte().ShowDialog();
        }
    }
}
