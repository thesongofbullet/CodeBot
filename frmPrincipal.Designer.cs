using FastColoredTextBoxNS;
namespace Codebot
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.chkdelete = new System.Windows.Forms.CheckBox();
            this.chkupdate = new System.Windows.Forms.CheckBox();
            this.dgvcolumnas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltabla = new System.Windows.Forms.Label();
            this.dgvtablas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LoadDefaul = new System.Windows.Forms.CheckBox();
            this.chkinsert = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox2 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassDat = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Serializar = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDat)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Serializar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(15, 34);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(56, 17);
            this.chkSelect.TabIndex = 0;
            this.chkSelect.Text = "Select";
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // chkdelete
            // 
            this.chkdelete.AutoSize = true;
            this.chkdelete.Location = new System.Drawing.Point(144, 34);
            this.chkdelete.Name = "chkdelete";
            this.chkdelete.Size = new System.Drawing.Size(57, 17);
            this.chkdelete.TabIndex = 1;
            this.chkdelete.Text = "Delete";
            this.chkdelete.UseVisualStyleBackColor = true;
            // 
            // chkupdate
            // 
            this.chkupdate.AutoSize = true;
            this.chkupdate.Location = new System.Drawing.Point(207, 34);
            this.chkupdate.Name = "chkupdate";
            this.chkupdate.Size = new System.Drawing.Size(61, 17);
            this.chkupdate.TabIndex = 2;
            this.chkupdate.Text = "Update";
            this.chkupdate.UseVisualStyleBackColor = true;
            // 
            // dgvcolumnas
            // 
            this.dgvcolumnas.AllowUserToAddRows = false;
            this.dgvcolumnas.AllowUserToDeleteRows = false;
            this.dgvcolumnas.AllowUserToResizeColumns = false;
            this.dgvcolumnas.AllowUserToResizeRows = false;
            this.dgvcolumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcolumnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcolumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcolumnas.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcolumnas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcolumnas.Location = new System.Drawing.Point(26, 40);
            this.dgvcolumnas.MultiSelect = false;
            this.dgvcolumnas.Name = "dgvcolumnas";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcolumnas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcolumnas.RowHeadersVisible = false;
            this.dgvcolumnas.Size = new System.Drawing.Size(394, 123);
            this.dgvcolumnas.TabIndex = 3;
            this.dgvcolumnas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcolumnas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TABLA";
            // 
            // lbltabla
            // 
            this.lbltabla.AutoSize = true;
            this.lbltabla.Location = new System.Drawing.Point(141, 1);
            this.lbltabla.Name = "lbltabla";
            this.lbltabla.Size = new System.Drawing.Size(40, 13);
            this.lbltabla.TabIndex = 5;
            this.lbltabla.Text = "lbltabla";
            // 
            // dgvtablas
            // 
            this.dgvtablas.AllowUserToAddRows = false;
            this.dgvtablas.AllowUserToDeleteRows = false;
            this.dgvtablas.AllowUserToResizeColumns = false;
            this.dgvtablas.AllowUserToResizeRows = false;
            this.dgvtablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtablas.ColumnHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtablas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvtablas.Location = new System.Drawing.Point(26, 35);
            this.dgvtablas.MultiSelect = false;
            this.dgvtablas.Name = "dgvtablas";
            this.dgvtablas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtablas.RowHeadersVisible = false;
            this.dgvtablas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvtablas.ShowCellErrors = false;
            this.dgvtablas.ShowCellToolTips = false;
            this.dgvtablas.ShowEditingIcon = false;
            this.dgvtablas.ShowRowErrors = false;
            this.dgvtablas.Size = new System.Drawing.Size(394, 124);
            this.dgvtablas.TabIndex = 7;
            this.dgvtablas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablas_CellClick);
            this.dgvtablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablas_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TABLAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar Codigo C#";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datos Del Servidor";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(151, 68);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(208, 20);
            this.txtDb.TabIndex = 15;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(151, 42);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(208, 20);
            this.txtIp.TabIndex = 16;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(151, 94);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(208, 20);
            this.txtuser.TabIndex = 17;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(151, 121);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(208, 20);
            this.txtpass.TabIndex = 18;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(151, 146);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(208, 20);
            this.txtport.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Direccion Del Servidor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre Base De Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Usuario Servidor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Contraseña Servidor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Puerto";
            // 
            // LoadDefaul
            // 
            this.LoadDefaul.AutoSize = true;
            this.LoadDefaul.Location = new System.Drawing.Point(151, 7);
            this.LoadDefaul.Name = "LoadDefaul";
            this.LoadDefaul.Size = new System.Drawing.Size(117, 17);
            this.LoadDefaul.TabIndex = 25;
            this.LoadDefaul.Text = "Cargar Por Defecto";
            this.LoadDefaul.UseVisualStyleBackColor = true;
            this.LoadDefaul.Visible = false;
            this.LoadDefaul.CheckedChanged += new System.EventHandler(this.LoadDefaul_CheckedChanged);
            // 
            // chkinsert
            // 
            this.chkinsert.AutoSize = true;
            this.chkinsert.Location = new System.Drawing.Point(74, 34);
            this.chkinsert.Name = "chkinsert";
            this.chkinsert.Size = new System.Drawing.Size(52, 17);
            this.chkinsert.TabIndex = 26;
            this.chkinsert.Text = "Insert";
            this.chkinsert.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 271);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.code);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Metodo nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // code
            // 
            this.code.AutoCompleteBrackets = true;
            this.code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.code.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.code.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.code.BackBrush = null;
            this.code.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.code.IsReplaceMode = false;
            this.code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.code.LeftBracket = '(';
            this.code.LeftBracket2 = '{';
            this.code.Location = new System.Drawing.Point(3, 3);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.ReadOnly = true;
            this.code.RightBracket = ')';
            this.code.RightBracket2 = '}';
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("code.ServiceColors")));
            this.code.ShowFoldingLines = true;
            this.code.Size = new System.Drawing.Size(863, 239);
            this.code.TabIndex = 28;
            this.code.UseWaitCursor = true;
            this.code.WideCaret = true;
            this.code.WordWrap = true;
            this.code.Zoom = 100;
            this.code.Load += new System.EventHandler(this.code_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fastColoredTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(869, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clase mysql";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox2
            // 
            this.fastColoredTextBox2.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox2.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.fastColoredTextBox2.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox2.BackBrush = null;
            this.fastColoredTextBox2.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox2.CharHeight = 14;
            this.fastColoredTextBox2.CharWidth = 8;
            this.fastColoredTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox2.IsReplaceMode = false;
            this.fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox2.LeftBracket = '(';
            this.fastColoredTextBox2.LeftBracket2 = '{';
            this.fastColoredTextBox2.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox2.Name = "fastColoredTextBox2";
            this.fastColoredTextBox2.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox2.RightBracket = ')';
            this.fastColoredTextBox2.RightBracket2 = '}';
            this.fastColoredTextBox2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox2.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox2.ServiceColors")));
            this.fastColoredTextBox2.Size = new System.Drawing.Size(869, 245);
            this.fastColoredTextBox2.TabIndex = 0;
            this.fastColoredTextBox2.Zoom = 100;
            this.fastColoredTextBox2.Load += new System.EventHandler(this.fastColoredTextBox2_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClassDat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 245);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Clase Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassDat
            // 
            this.ClassDat.AutoCompleteBrackets = true;
            this.ClassDat.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ClassDat.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.ClassDat.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.ClassDat.BackBrush = null;
            this.ClassDat.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ClassDat.CharHeight = 14;
            this.ClassDat.CharWidth = 8;
            this.ClassDat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ClassDat.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClassDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassDat.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.ClassDat.IsReplaceMode = false;
            this.ClassDat.Language = FastColoredTextBoxNS.Language.CSharp;
            this.ClassDat.LeftBracket = '(';
            this.ClassDat.LeftBracket2 = '{';
            this.ClassDat.Location = new System.Drawing.Point(3, 3);
            this.ClassDat.Name = "ClassDat";
            this.ClassDat.Paddings = new System.Windows.Forms.Padding(0);
            this.ClassDat.ReadOnly = true;
            this.ClassDat.RightBracket = ')';
            this.ClassDat.RightBracket2 = '}';
            this.ClassDat.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClassDat.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ClassDat.ServiceColors")));
            this.ClassDat.ShowFoldingLines = true;
            this.ClassDat.Size = new System.Drawing.Size(863, 239);
            this.ClassDat.TabIndex = 29;
            this.ClassDat.UseWaitCursor = true;
            this.ClassDat.WideCaret = true;
            this.ClassDat.WordWrap = true;
            this.ClassDat.Zoom = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Serializar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(869, 245);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Inicializador de datos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Serializar
            // 
            this.Serializar.AutoCompleteBrackets = true;
            this.Serializar.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Serializar.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.Serializar.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.Serializar.BackBrush = null;
            this.Serializar.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Serializar.CharHeight = 14;
            this.Serializar.CharWidth = 8;
            this.Serializar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Serializar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Serializar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Serializar.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.Serializar.IsReplaceMode = false;
            this.Serializar.Language = FastColoredTextBoxNS.Language.CSharp;
            this.Serializar.LeftBracket = '(';
            this.Serializar.LeftBracket2 = '{';
            this.Serializar.Location = new System.Drawing.Point(3, 3);
            this.Serializar.Name = "Serializar";
            this.Serializar.Paddings = new System.Windows.Forms.Padding(0);
            this.Serializar.ReadOnly = true;
            this.Serializar.RightBracket = ')';
            this.Serializar.RightBracket2 = '}';
            this.Serializar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Serializar.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Serializar.ServiceColors")));
            this.Serializar.ShowFoldingLines = true;
            this.Serializar.Size = new System.Drawing.Size(863, 239);
            this.Serializar.TabIndex = 30;
            this.Serializar.UseWaitCursor = true;
            this.Serializar.WideCaret = true;
            this.Serializar.WordWrap = true;
            this.Serializar.Zoom = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LoadDefaul);
            this.panel1.Controls.Add(this.txtDb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtport);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(16, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 197);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Selecione Funcion";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 17);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(227, 17);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "Seleccionar Todos Los campos de la tabla";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvtablas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(454, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 166);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkupdate);
            this.panel3.Controls.Add(this.chkSelect);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.chkdelete);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.chkinsert);
            this.panel3.Location = new System.Drawing.Point(16, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 107);
            this.panel3.TabIndex = 34;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Location = new System.Drawing.Point(16, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 271);
            this.panel4.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CAMPOS";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvcolumnas);
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lbltabla);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(454, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(439, 178);
            this.panel5.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Apoyo Para Crystal Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(926, 651);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassDat)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Serializar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.CheckBox chkdelete;
        private System.Windows.Forms.CheckBox chkupdate;
        private System.Windows.Forms.DataGridView dgvcolumnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltabla;
        private System.Windows.Forms.DataGridView dgvtablas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox LoadDefaul;
        public System.Windows.Forms.TextBox txtDb;
        public System.Windows.Forms.TextBox txtIp;
        public System.Windows.Forms.TextBox txtuser;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.CheckBox chkinsert;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private FastColoredTextBox fastColoredTextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TabPage tabPage1;
        private FastColoredTextBox code;
        private System.Windows.Forms.TabPage tabPage2;
        private FastColoredTextBox ClassDat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPage4;
        private FastColoredTextBox Serializar;
        private System.Windows.Forms.Button button3;
    }
}

