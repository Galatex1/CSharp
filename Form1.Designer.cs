namespace MySQL
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.gpConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisc = new System.Windows.Forms.Button();
            this.tabData = new System.Windows.Forms.TabPage();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpFiltry = new System.Windows.Forms.GroupBox();
            this.txtFilter7 = new System.Windows.Forms.TextBox();
            this.cbOperand7 = new System.Windows.Forms.ComboBox();
            this.cbFilter7 = new System.Windows.Forms.ComboBox();
            this.txtFilter6 = new System.Windows.Forms.TextBox();
            this.cbOperand6 = new System.Windows.Forms.ComboBox();
            this.cbFilter6 = new System.Windows.Forms.ComboBox();
            this.txtFilter5 = new System.Windows.Forms.TextBox();
            this.cbOperand5 = new System.Windows.Forms.ComboBox();
            this.cbFilter5 = new System.Windows.Forms.ComboBox();
            this.txtFilter4 = new System.Windows.Forms.TextBox();
            this.cbOperand4 = new System.Windows.Forms.ComboBox();
            this.cbFilter4 = new System.Windows.Forms.ComboBox();
            this.txtFilter3 = new System.Windows.Forms.TextBox();
            this.cbOperand3 = new System.Windows.Forms.ComboBox();
            this.cbFilter3 = new System.Windows.Forms.ComboBox();
            this.txtFilter2 = new System.Windows.Forms.TextBox();
            this.cbOperand2 = new System.Windows.Forms.ComboBox();
            this.cbFilter2 = new System.Windows.Forms.ComboBox();
            this.txtFilter1 = new System.Windows.Forms.TextBox();
            this.cbOperand1 = new System.Windows.Forms.ComboBox();
            this.cbFilter1 = new System.Windows.Forms.ComboBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnFilters = new System.Windows.Forms.Button();
            this.tabPanel.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.gpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpFiltry.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabConnection);
            this.tabPanel.Controls.Add(this.tabData);
            this.tabPanel.Location = new System.Drawing.Point(10, 12);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(1242, 580);
            this.tabPanel.TabIndex = 0;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.gpConnection);
            this.tabConnection.Controls.Add(this.btnDisc);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(759, 554);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // gpConnection
            // 
            this.gpConnection.Controls.Add(this.btnConnect);
            this.gpConnection.Controls.Add(this.numPort);
            this.gpConnection.Controls.Add(this.label4);
            this.gpConnection.Controls.Add(this.txtPassword);
            this.gpConnection.Controls.Add(this.label3);
            this.gpConnection.Controls.Add(this.txtUser);
            this.gpConnection.Controls.Add(this.label2);
            this.gpConnection.Controls.Add(this.txtServer);
            this.gpConnection.Controls.Add(this.label1);
            this.gpConnection.Location = new System.Drawing.Point(168, 219);
            this.gpConnection.Name = "gpConnection";
            this.gpConnection.Size = new System.Drawing.Size(430, 182);
            this.gpConnection.TabIndex = 0;
            this.gpConnection.TabStop = false;
            this.gpConnection.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(98, 131);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(248, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(98, 105);
            this.numPort.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(248, 20);
            this.numPort.TabIndex = 7;
            this.numPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(98, 53);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(98, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(248, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // btnDisc
            // 
            this.btnDisc.Location = new System.Drawing.Point(259, 274);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(248, 51);
            this.btnDisc.TabIndex = 9;
            this.btnDisc.Text = "Disconnect";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dataTable);
            this.tabData.Controls.Add(this.panel1);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(1234, 554);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(191, 6);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(1037, 548);
            this.dataTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpFiltry);
            this.panel1.Controls.Add(this.tree);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 564);
            this.panel1.TabIndex = 2;
            // 
            // gpFiltry
            // 
            this.gpFiltry.Controls.Add(this.btnFilters);
            this.gpFiltry.Controls.Add(this.txtFilter7);
            this.gpFiltry.Controls.Add(this.cbOperand7);
            this.gpFiltry.Controls.Add(this.cbFilter7);
            this.gpFiltry.Controls.Add(this.txtFilter6);
            this.gpFiltry.Controls.Add(this.cbOperand6);
            this.gpFiltry.Controls.Add(this.cbFilter6);
            this.gpFiltry.Controls.Add(this.txtFilter5);
            this.gpFiltry.Controls.Add(this.cbOperand5);
            this.gpFiltry.Controls.Add(this.cbFilter5);
            this.gpFiltry.Controls.Add(this.txtFilter4);
            this.gpFiltry.Controls.Add(this.cbOperand4);
            this.gpFiltry.Controls.Add(this.cbFilter4);
            this.gpFiltry.Controls.Add(this.txtFilter3);
            this.gpFiltry.Controls.Add(this.cbOperand3);
            this.gpFiltry.Controls.Add(this.cbFilter3);
            this.gpFiltry.Controls.Add(this.txtFilter2);
            this.gpFiltry.Controls.Add(this.cbOperand2);
            this.gpFiltry.Controls.Add(this.cbFilter2);
            this.gpFiltry.Controls.Add(this.txtFilter1);
            this.gpFiltry.Controls.Add(this.cbOperand1);
            this.gpFiltry.Controls.Add(this.cbFilter1);
            this.gpFiltry.Location = new System.Drawing.Point(4, 317);
            this.gpFiltry.Name = "gpFiltry";
            this.gpFiltry.Size = new System.Drawing.Size(172, 225);
            this.gpFiltry.TabIndex = 1;
            this.gpFiltry.TabStop = false;
            this.gpFiltry.Text = "Filters";
            // 
            // txtFilter7
            // 
            this.txtFilter7.Location = new System.Drawing.Point(114, 177);
            this.txtFilter7.Name = "txtFilter7";
            this.txtFilter7.Size = new System.Drawing.Size(58, 20);
            this.txtFilter7.TabIndex = 19;
            // 
            // cbOperand7
            // 
            this.cbOperand7.FormattingEnabled = true;
            this.cbOperand7.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand7.Location = new System.Drawing.Point(77, 176);
            this.cbOperand7.Name = "cbOperand7";
            this.cbOperand7.Size = new System.Drawing.Size(31, 21);
            this.cbOperand7.TabIndex = 17;
            // 
            // cbFilter7
            // 
            this.cbFilter7.FormattingEnabled = true;
            this.cbFilter7.Location = new System.Drawing.Point(0, 176);
            this.cbFilter7.Name = "cbFilter7";
            this.cbFilter7.Size = new System.Drawing.Size(71, 21);
            this.cbFilter7.TabIndex = 18;
            // 
            // txtFilter6
            // 
            this.txtFilter6.Location = new System.Drawing.Point(114, 151);
            this.txtFilter6.Name = "txtFilter6";
            this.txtFilter6.Size = new System.Drawing.Size(58, 20);
            this.txtFilter6.TabIndex = 16;
            // 
            // cbOperand6
            // 
            this.cbOperand6.FormattingEnabled = true;
            this.cbOperand6.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand6.Location = new System.Drawing.Point(77, 150);
            this.cbOperand6.Name = "cbOperand6";
            this.cbOperand6.Size = new System.Drawing.Size(31, 21);
            this.cbOperand6.TabIndex = 14;
            // 
            // cbFilter6
            // 
            this.cbFilter6.FormattingEnabled = true;
            this.cbFilter6.Location = new System.Drawing.Point(0, 150);
            this.cbFilter6.Name = "cbFilter6";
            this.cbFilter6.Size = new System.Drawing.Size(71, 21);
            this.cbFilter6.TabIndex = 15;
            // 
            // txtFilter5
            // 
            this.txtFilter5.Location = new System.Drawing.Point(114, 125);
            this.txtFilter5.Name = "txtFilter5";
            this.txtFilter5.Size = new System.Drawing.Size(58, 20);
            this.txtFilter5.TabIndex = 13;
            // 
            // cbOperand5
            // 
            this.cbOperand5.FormattingEnabled = true;
            this.cbOperand5.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand5.Location = new System.Drawing.Point(77, 124);
            this.cbOperand5.Name = "cbOperand5";
            this.cbOperand5.Size = new System.Drawing.Size(31, 21);
            this.cbOperand5.TabIndex = 11;
            // 
            // cbFilter5
            // 
            this.cbFilter5.FormattingEnabled = true;
            this.cbFilter5.Location = new System.Drawing.Point(0, 124);
            this.cbFilter5.Name = "cbFilter5";
            this.cbFilter5.Size = new System.Drawing.Size(71, 21);
            this.cbFilter5.TabIndex = 12;
            // 
            // txtFilter4
            // 
            this.txtFilter4.Location = new System.Drawing.Point(114, 99);
            this.txtFilter4.Name = "txtFilter4";
            this.txtFilter4.Size = new System.Drawing.Size(58, 20);
            this.txtFilter4.TabIndex = 10;
            // 
            // cbOperand4
            // 
            this.cbOperand4.FormattingEnabled = true;
            this.cbOperand4.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand4.Location = new System.Drawing.Point(77, 98);
            this.cbOperand4.Name = "cbOperand4";
            this.cbOperand4.Size = new System.Drawing.Size(31, 21);
            this.cbOperand4.TabIndex = 8;
            // 
            // cbFilter4
            // 
            this.cbFilter4.FormattingEnabled = true;
            this.cbFilter4.Location = new System.Drawing.Point(0, 98);
            this.cbFilter4.Name = "cbFilter4";
            this.cbFilter4.Size = new System.Drawing.Size(71, 21);
            this.cbFilter4.TabIndex = 9;
            // 
            // txtFilter3
            // 
            this.txtFilter3.Location = new System.Drawing.Point(114, 73);
            this.txtFilter3.Name = "txtFilter3";
            this.txtFilter3.Size = new System.Drawing.Size(58, 20);
            this.txtFilter3.TabIndex = 7;
            // 
            // cbOperand3
            // 
            this.cbOperand3.FormattingEnabled = true;
            this.cbOperand3.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand3.Location = new System.Drawing.Point(77, 72);
            this.cbOperand3.Name = "cbOperand3";
            this.cbOperand3.Size = new System.Drawing.Size(31, 21);
            this.cbOperand3.TabIndex = 5;
            // 
            // cbFilter3
            // 
            this.cbFilter3.FormattingEnabled = true;
            this.cbFilter3.Location = new System.Drawing.Point(0, 72);
            this.cbFilter3.Name = "cbFilter3";
            this.cbFilter3.Size = new System.Drawing.Size(71, 21);
            this.cbFilter3.TabIndex = 6;
            // 
            // txtFilter2
            // 
            this.txtFilter2.Location = new System.Drawing.Point(114, 47);
            this.txtFilter2.Name = "txtFilter2";
            this.txtFilter2.Size = new System.Drawing.Size(58, 20);
            this.txtFilter2.TabIndex = 4;
            // 
            // cbOperand2
            // 
            this.cbOperand2.FormattingEnabled = true;
            this.cbOperand2.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand2.Location = new System.Drawing.Point(77, 46);
            this.cbOperand2.Name = "cbOperand2";
            this.cbOperand2.Size = new System.Drawing.Size(31, 21);
            this.cbOperand2.TabIndex = 2;
            // 
            // cbFilter2
            // 
            this.cbFilter2.FormattingEnabled = true;
            this.cbFilter2.Location = new System.Drawing.Point(0, 46);
            this.cbFilter2.Name = "cbFilter2";
            this.cbFilter2.Size = new System.Drawing.Size(71, 21);
            this.cbFilter2.TabIndex = 3;
            // 
            // txtFilter1
            // 
            this.txtFilter1.Location = new System.Drawing.Point(114, 21);
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(58, 20);
            this.txtFilter1.TabIndex = 1;
            // 
            // cbOperand1
            // 
            this.cbOperand1.FormattingEnabled = true;
            this.cbOperand1.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "=",
            "LIKE"});
            this.cbOperand1.Location = new System.Drawing.Point(77, 20);
            this.cbOperand1.Name = "cbOperand1";
            this.cbOperand1.Size = new System.Drawing.Size(31, 21);
            this.cbOperand1.TabIndex = 0;
            // 
            // cbFilter1
            // 
            this.cbFilter1.FormattingEnabled = true;
            this.cbFilter1.Location = new System.Drawing.Point(0, 20);
            this.cbFilter1.Name = "cbFilter1";
            this.cbFilter1.Size = new System.Drawing.Size(71, 21);
            this.cbFilter1.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(4, 4);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(172, 307);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnect,
            this.toolStripStatusLabel1,
            this.statusServer,
            this.toolStripStatusLabel2,
            this.statusDB,
            this.toolStripStatusLabel3,
            this.statusTable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusConnect
            // 
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.Size = new System.Drawing.Size(88, 17);
            this.statusConnect.Text = "Not Connected";
            this.statusConnect.ToolTipText = "Connection Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "              Server:";
            // 
            // statusServer
            // 
            this.statusServer.Name = "statusServer";
            this.statusServer.Size = new System.Drawing.Size(34, 17);
            this.statusServer.Text = "none";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "              Database:";
            // 
            // statusDB
            // 
            this.statusDB.Name = "statusDB";
            this.statusDB.Size = new System.Drawing.Size(34, 17);
            this.statusDB.Text = "none";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel3.Text = "              Table:";
            // 
            // statusTable
            // 
            this.statusTable.Name = "statusTable";
            this.statusTable.Size = new System.Drawing.Size(34, 17);
            this.statusTable.Text = "none";
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(6, 203);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(160, 22);
            this.btnFilters.TabIndex = 20;
            this.btnFilters.Text = "Refresh";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 626);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPanel.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.gpConnection.ResumeLayout(false);
            this.gpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gpFiltry.ResumeLayout(false);
            this.gpFiltry.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.GroupBox gpConnection;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusConnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusDB;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusTable;
        private System.Windows.Forms.GroupBox gpFiltry;
        private System.Windows.Forms.TextBox txtFilter1;
        private System.Windows.Forms.ComboBox cbOperand1;
        private System.Windows.Forms.ComboBox cbFilter1;
        private System.Windows.Forms.TextBox txtFilter7;
        private System.Windows.Forms.ComboBox cbOperand7;
        private System.Windows.Forms.ComboBox cbFilter7;
        private System.Windows.Forms.TextBox txtFilter6;
        private System.Windows.Forms.ComboBox cbOperand6;
        private System.Windows.Forms.ComboBox cbFilter6;
        private System.Windows.Forms.TextBox txtFilter5;
        private System.Windows.Forms.ComboBox cbOperand5;
        private System.Windows.Forms.ComboBox cbFilter5;
        private System.Windows.Forms.TextBox txtFilter4;
        private System.Windows.Forms.ComboBox cbOperand4;
        private System.Windows.Forms.ComboBox cbFilter4;
        private System.Windows.Forms.TextBox txtFilter3;
        private System.Windows.Forms.ComboBox cbOperand3;
        private System.Windows.Forms.ComboBox cbFilter3;
        private System.Windows.Forms.TextBox txtFilter2;
        private System.Windows.Forms.ComboBox cbOperand2;
        private System.Windows.Forms.ComboBox cbFilter2;
        private System.Windows.Forms.Button btnFilters;
    }
}

