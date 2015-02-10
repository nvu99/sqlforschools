using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;

namespace SQLforSchools
{
    public partial class MainWindow : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader rdr;
        MySql.Data.MySqlClient.MySqlDataReader tablereader;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            connectionStatus.Text = "Disconnected";
            query.ReadOnly = true;
            SendButton.Enabled = false;
            listOfTables.Enabled = false;
            listOfTables.DropDownStyle = ComboBoxStyle.DropDownList;
            displayTable.Enabled = false;
            refreshButton.Enabled = false;
            disconnectButton.Enabled = false;
            viewingQuery.ReadOnly = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=" + connectionServer.Text + ";uid=" + connectionUserID.Text + ";pwd=" + connectionPassword.Text + ";database=" + connectionDatabase.Text + ";";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();

                var status = conn.State.ToString();
                if (conn.State == ConnectionState.Open && status == "Open")
                {
                    connectionStatus.Text = "Connected to " + connectionDatabase.Text + " at " + connectionServer.Text + " as " + connectionUserID.Text;
                }
                conn.Close();
                connectionServer.Enabled = false;
                connectionDatabase.Enabled = false;
                connectionUserID.Enabled = false;
                connectionPassword.Enabled = false;
                query.ReadOnly = false;
                SendButton.Enabled = true;
                listOfTables.Enabled = true;
                displayTable.Enabled = true;
                disconnectButton.Enabled = true;
                connectButton.Enabled = false;
                viewingQuery.ReadOnly = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
        }
        
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            conn.Close();
            var status = conn.State.ToString();
            if (conn.State == ConnectionState.Open && status == "Open")
            {
                MessageBox.Show(@"Couldn't disconnect");
            }
            else
            {
                connectionStatus.Text = "Disconnected";
            }
            connectionServer.Enabled = true;
            connectionDatabase.Enabled = true;
            connectionUserID.Enabled = true;
            connectionPassword.Enabled = true;
            query.ReadOnly = true;
            SendButton.Enabled = false;
            listOfTables.Enabled = false;
            displayTable.Enabled = false;
            refreshButton.Enabled = false;
            dataGridView1.Enabled = false;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            viewingQuery.ReadOnly = true;
            conn.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query.Text, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MessageBox.Show(rdr.GetString(1));
                }
                MessageBox.Show("Command successful!");
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
        }

        private void listOfTables_Click(object sender, EventArgs e)
        {
            listOfTables.Items.Clear();
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand tablereadcommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='" + connectionDatabase.Text + "'", conn);
            tablereader = tablereadcommand.ExecuteReader();
            while (tablereader.Read())
            {
                listOfTables.Items.Add((string)tablereader["TABLE_NAME"]);
            }
            conn.Close();
        }

        private void displayTable_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(viewingQuery.Text, conn);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            conn.Close();
            listOfTables.Enabled = false;
            refreshButton.Enabled = true;
            dataGridView1.Enabled = true;
            viewingQuery.ReadOnly = true;
        }

        private void closeData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            listOfTables.Enabled = true;
            refreshButton.Enabled = false;
            viewingQuery.ReadOnly = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(viewingQuery.Text, conn);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            conn.Close();
            viewingQuery.ReadOnly = true;
        }

        private void listOfTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewingQuery.Text = "select * from " + listOfTables.Text;
        }
    }
}
