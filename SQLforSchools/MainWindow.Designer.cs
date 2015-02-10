namespace SQLforSchools
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connectionUserID = new System.Windows.Forms.TextBox();
            this.connectionPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.query = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listOfTables = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.displayTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.closeData = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.viewingQuery = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server";
            // 
            // connectionServer
            // 
            this.connectionServer.Location = new System.Drawing.Point(192, 55);
            this.connectionServer.Name = "connectionServer";
            this.connectionServer.Size = new System.Drawing.Size(185, 31);
            this.connectionServer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database";
            // 
            // connectionDatabase
            // 
            this.connectionDatabase.Location = new System.Drawing.Point(192, 92);
            this.connectionDatabase.Name = "connectionDatabase";
            this.connectionDatabase.Size = new System.Drawing.Size(185, 31);
            this.connectionDatabase.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "User ID";
            // 
            // connectionUserID
            // 
            this.connectionUserID.Location = new System.Drawing.Point(192, 129);
            this.connectionUserID.Name = "connectionUserID";
            this.connectionUserID.Size = new System.Drawing.Size(185, 31);
            this.connectionUserID.TabIndex = 6;
            // 
            // connectionPassword
            // 
            this.connectionPassword.Location = new System.Drawing.Point(192, 166);
            this.connectionPassword.Name = "connectionPassword";
            this.connectionPassword.PasswordChar = '*';
            this.connectionPassword.Size = new System.Drawing.Size(185, 31);
            this.connectionPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(10, 216);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(173, 53);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(204, 216);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(173, 53);
            this.disconnectButton.TabIndex = 12;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.disconnectButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.connectionServer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.connectionPassword);
            this.panel1.Controls.Add(this.connectionDatabase);
            this.panel1.Controls.Add(this.connectionUserID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 275);
            this.panel1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1663, 37);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "Connection Status";
            // 
            // connectionStatus
            // 
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(199, 32);
            this.connectionStatus.Text = "connectionStatus";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(426, 55);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(1225, 232);
            this.query.TabIndex = 15;
            this.query.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(419, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "Query";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(1264, 293);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(387, 53);
            this.SendButton.TabIndex = 17;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1628, 720);
            this.dataGridView1.TabIndex = 18;
            // 
            // listOfTables
            // 
            this.listOfTables.FormattingEnabled = true;
            this.listOfTables.Location = new System.Drawing.Point(167, 1257);
            this.listOfTables.Name = "listOfTables";
            this.listOfTables.Size = new System.Drawing.Size(366, 33);
            this.listOfTables.TabIndex = 19;
            this.listOfTables.SelectedIndexChanged += new System.EventHandler(this.listOfTables_SelectedIndexChanged);
            this.listOfTables.Click += new System.EventHandler(this.listOfTables_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 1265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "List of tables";
            // 
            // displayTable
            // 
            this.displayTable.Location = new System.Drawing.Point(539, 1255);
            this.displayTable.Name = "displayTable";
            this.displayTable.Size = new System.Drawing.Size(87, 44);
            this.displayTable.TabIndex = 21;
            this.displayTable.Text = "View";
            this.displayTable.UseVisualStyleBackColor = true;
            this.displayTable.Click += new System.EventHandler(this.displayTable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(16, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 42);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data";
            // 
            // closeData
            // 
            this.closeData.Location = new System.Drawing.Point(632, 1256);
            this.closeData.Name = "closeData";
            this.closeData.Size = new System.Drawing.Size(87, 44);
            this.closeData.TabIndex = 23;
            this.closeData.Text = "Close";
            this.closeData.UseVisualStyleBackColor = true;
            this.closeData.Click += new System.EventHandler(this.closeData_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(725, 1257);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 44);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1274, 1099);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Copyright © 2015 Nguyen Thai Dai Vu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 1112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Viewing query";
            // 
            // viewingQuery
            // 
            this.viewingQuery.Location = new System.Drawing.Point(167, 1078);
            this.viewingQuery.Name = "viewingQuery";
            this.viewingQuery.Size = new System.Drawing.Size(1473, 155);
            this.viewingQuery.TabIndex = 27;
            this.viewingQuery.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 1344);
            this.Controls.Add(this.viewingQuery);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listOfTables);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.query);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MySQL Connection for Deutsche Schule Prag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectionServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox connectionDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox connectionUserID;
        private System.Windows.Forms.TextBox connectionPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        private System.Windows.Forms.RichTextBox query;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox listOfTables;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button displayTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button closeData;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox viewingQuery;
    }
}

