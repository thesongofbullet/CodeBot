using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Codebot.data;
using CrystalDecisions.CrystalReports.Engine;

namespace Codebot
{
    public partial class frmGestionReporte : Form
    {
        public frmGestionReporte()
        {
            InitializeComponent();
        }
        List<dataparametros> parametros = new List<dataparametros>();
        List<dataTabla> tablas = new List<dataTabla>();
        private void button1_Click(object sender, EventArgs e)
        {

            parametros.Clear();
            tablas.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos Rpt| *.rpt";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = op.FileName;
                ReportDocument rpt = new ReportDocument();
                rpt.Load(op.FileName);
                try
                {
                    for (int b = 0; b < rpt.Database.Tables.Count; b++)
                    {
                        dataTabla h = new dataTabla();
                        h.index = b;
                        h.nombre = rpt.Database.Tables[b].Name;
                        tablas.Add(h);
                    }
                    for (int b = 0; b < rpt.ParameterFields.Count; b++)
                    {
                        dataparametros h = new dataparametros();
                        h.index = b;
                        h.nombre = rpt.ParameterFields[b].Name;
                        parametros.Add(h);
                    }
                }
                catch { }
                dgvTable.DataSource = null;
                dgvparametros.DataSource = null;
                dgvparametros.DataSource = parametros;
                dgvTable.DataSource = tablas;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codig();
        }
        internal void codig()
        {
            string metodo = "\rinternal void reporte_datatable( string ruta)\r{\rtry\r{\r" + "-" + "}catch(Exception ex){\rMessageBox.Show(ex.Message);\r}\r}";
            string load = "ReportDocument rpt = new ReportDocument();\rrpt.Load(ruta);\r";
            string cabecera = "rpt.SetParameterValue("+"-"+", (object)"+"-"+");";
            string cabeceraDatatable = "rpt.Database.Tables["+"+"+"].SetDataSource("+"+"+");";
            string data = "";
            if (tablas.Count > 0)
            {
                foreach (dataTabla a in tablas)
                {
                    string[] tmp = cabeceraDatatable.Split('+');
                    data += tmp[0] + a.index.ToString() + tmp[1] +a.nombre.ToString()+tmp[2] + "\r";
                }

            }
            if (parametros.Count >0)
            {
                foreach(dataparametros a in parametros)
                {
                    string[] tmp = cabecera.Split('-');
                    data += tmp[0] +a.nombre.ToString() + tmp[1]+"\"\"/* Tu parametro */);" +"\r";
                }

            }

            string codigo_class = "Public class reporte"+"-"+"}";
            code.Clear();
            string[] v = codigo_class.Split('-');
            string[] b = metodo.Split('-');
            code.Text = v[0] + b[0] + load + data + "/* aqui envia al visor de cristal report una vez que este todo completo */\r"+b[1] + v[1];
        }
    }
}
