namespace Codebot
{
    partial class frmGestionReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionReporte));
            this.txtruta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.dgvparametros = new System.Windows.Forms.DataGridView();
            this.code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.SuspendLayout();
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(12, 12);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(652, 20);
            this.txtruta.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "buscar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tablas Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parametros";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 77);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTable.ShowCellErrors = false;
            this.dgvTable.ShowCellToolTips = false;
            this.dgvTable.ShowEditingIcon = false;
            this.dgvTable.ShowRowErrors = false;
            this.dgvTable.Size = new System.Drawing.Size(199, 150);
            this.dgvTable.TabIndex = 6;
            // 
            // dgvparametros
            // 
            this.dgvparametros.AllowUserToAddRows = false;
            this.dgvparametros.AllowUserToDeleteRows = false;
            this.dgvparametros.AllowUserToResizeColumns = false;
            this.dgvparametros.AllowUserToResizeRows = false;
            this.dgvparametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvparametros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvparametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvparametros.Location = new System.Drawing.Point(217, 77);
            this.dgvparametros.Name = "dgvparametros";
            this.dgvparametros.ReadOnly = true;
            this.dgvparametros.RowHeadersVisible = false;
            this.dgvparametros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvparametros.ShowCellErrors = false;
            this.dgvparametros.ShowCellToolTips = false;
            this.dgvparametros.ShowEditingIcon = false;
            this.dgvparametros.ShowRowErrors = false;
            this.dgvparametros.Size = new System.Drawing.Size(199, 150);
            this.dgvparametros.TabIndex = 7;
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
            this.code.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.code.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.code.IsReplaceMode = false;
            this.code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.code.LeftBracket = '(';
            this.code.LeftBracket2 = '{';
            this.code.Location = new System.Drawing.Point(0, 246);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.ReadOnly = true;
            this.code.RightBracket = ')';
            this.code.RightBracket2 = '}';
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("code.ServiceColors")));
            this.code.ShowFoldingLines = true;
            this.code.Size = new System.Drawing.Size(820, 202);
            this.code.TabIndex = 29;
            this.code.UseWaitCursor = true;
            this.code.WideCaret = true;
            this.code.WordWrap = true;
            this.code.Zoom = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 101);
            this.button2.TabIndex = 30;
            this.button2.Text = "Generar Codigo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGestionReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.code);
            this.Controls.Add(this.dgvparametros);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtruta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionReporte";
            this.Text = "Gestion Crystal Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridView dgvparametros;
        private FastColoredTextBoxNS.FastColoredTextBox code;
        private System.Windows.Forms.Button button2;
    }
}