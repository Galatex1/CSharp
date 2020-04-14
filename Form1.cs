using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPanel.SelectedTab = tabConnection;

        }

        string server = "SERVER=";
        string user = "UID=";
        string pass = "PASSWORD=";
        string port = "PORT=";
        string connString = "";
        int DB_rows = 0;

        MySqlConnection connection;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectDB();
        }

        private void connectDB()
        {
            server = "SERVER="+txtServer.Text+";";
            user = "UID=" + txtUser.Text + ";";
            pass = "PASSWORD=" + txtPassword.Text + ";";
            port = "PORT="+ numPort.Value.ToString() + ";";

            


            try
            {

                
                connString =server + user + pass + port;
                //MessageBox.Show(connString);
                connection = new MySqlConnection(connString);
                connection.Open();


                //MessageBox.Show("Pripojeni uspesne!");
                statusConnect.Text = "Connected";
                statusServer.Text = txtServer.Text;
                tabPanel.SelectedTab = tabData;

                gpConnection.Hide();

                refreshDatabases();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba pripojeni: " + ex.ToString());
            }
        }

        private void conenctionScreen()
        {

        }


        private void refreshDatabases()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand("SHOW DATABASES", connection);
                MySqlDataReader reader = sql.ExecuteReader();
                MySqlConnection con2 = new MySqlConnection(connString);
                con2.Open();

                while (reader.Read())
                {
                    string DB = reader.GetString(0);
                    TreeNode DB_node = tree.Nodes.Add(DB);

                    MySqlCommand sql1 = new MySqlCommand("USE " + DB + "; SHOW TABLES", con2);
                    MySqlDataReader reader1 = sql1.ExecuteReader();

                    while (reader1.Read())
                    {
                        string tbl = reader1.GetString(0);
                        TreeNode tbl_node = DB_node.Nodes.Add(tbl);
                    }

                    reader1.Close();

                }

                reader.Close();

                con2.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba: " + ex.ToString());
            }


        }

        private void showData()
        {
            try
            {
                string s = "SELECT * FROM "+statusTable+" WHERE "+ makeFilters();
                //MessageBox.Show(s);
                MySqlCommand sql = new MySqlCommand("USE " + statusDB+";" + s , connection);
                MySqlDataReader reader = sql.ExecuteReader();
                DataTable tbl = new DataTable();
                bool columns = true;

                while (reader.Read())
                {

                    int i = 0;
                    if (columns)
                    {
                        for ( i = 0; i < reader.FieldCount; i++)
                        {
                            tbl.Columns.Add(reader.GetName(i));
                        }

                        //tbl.Columns.Add("Edit");
                        //tbl.Columns.Add("Delete");

                    }

                   


                    DataRow row = tbl.NewRow();
                    
                    for (i = 0; i < reader.FieldCount; i++)
                    {
                        try
                        {
                            row[i] = reader.GetString(i);
                        }
                        catch 
                        {

                        }
                    }

                    //row[i] = reader.GetString(0);
                    //row[i + 1] = reader.GetString(0);

                    tbl.Rows.Add(row);

                    columns = false;

                }

                DB_rows = tbl.Rows.Count;

                reader.Close();
                dataTable.Columns.Clear();
                dataTable.DataSource = tbl;

                if (dataTable.Columns["btnEdit"] == null)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Edit";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    dataTable.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "Delete";
                    bcol1.Text = "Delete";
                    bcol1.Name = "btnDelete";
                    bcol1.UseColumnTextForButtonValue = true;
                    dataTable.Columns.Add(bcol1);
                }


                dataTable.CellClick += dataTable_CellClick;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba: " + ex.ToString());
            }
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            string value = dataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            string action = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if(action == "Delete")
            {
                DialogResult res = MessageBox.Show(this, "Opravdu smazat?", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        string s = "DELETE FROM " + statusTable + " WHERE " + dataTable.Columns[0].HeaderText + " = " + value;
                        MessageBox.Show(s);
                        MySqlCommand sql = new MySqlCommand("USE " + statusDB + ";" + s, connection);
                        int reader = sql.ExecuteNonQuery();
                        MessageBox.Show("Smazano "+reader.ToString()+" zaznamu.");
                    }
                    catch
                    {

                        
                    }
                }
            }
            else if(action == "Edit")
            {

                if (e.RowIndex < DB_rows)
                {

                    try
                    {
                        string s = "UPDATE " + statusTable + " SET ";
                        foreach (DataGridViewCell c in dataTable.Rows[e.RowIndex].Cells)
                        {

                            string col = dataTable.Columns[c.ColumnIndex].HeaderText;

                            if (col != "Edit" && col != "Delete")
                            {

                                s += col + " = \"" + c.Value.ToString() + "\"";

                                if (c.ColumnIndex < dataTable.Columns.Count - 3)
                                    s += ", ";
                            }
                        }

                        s += " WHERE " + dataTable.Columns[0].HeaderText + " = \"" + value + "\"";

                        //MessageBox.Show(s);
                        MySqlCommand sql = new MySqlCommand("USE " + statusDB + ";" + s, connection);
                        int reader = sql.ExecuteNonQuery();
                        MessageBox.Show("Upraveno " + reader.ToString() + " zaznamu.");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());

                    }
                }
                else
                {
                    try
                    {
                        string s = "INSERT INTO " + statusTable + " ( ";
                        string v = " VALUES(";
                        foreach (DataGridViewCell c in dataTable.Rows[e.RowIndex].Cells)
                        {

                            string col = dataTable.Columns[c.ColumnIndex].HeaderText;

                            if (col != "Edit" && col != "Delete")
                            {

                                s += col;
                                v += "\"" + c.Value.ToString() + "\"";

                                if (c.ColumnIndex < dataTable.Columns.Count - 3)
                                {
                                    s += ", ";
                                    v += ", ";
                                }
                            }
                        }
                        v += ")";
                        s += ")" + v;

                        //MessageBox.Show(s);
                        MySqlCommand sql = new MySqlCommand("USE " + statusDB + ";" + s, connection);
                        int reader = sql.ExecuteNonQuery();
                        MessageBox.Show("Pridan " + reader.ToString() + " zaznam.");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());

                    }
                }

            }

        }

        private void Reset()
        {
            statusConnect.Text = "Not Connected";
            statusServer.Text = "none";
            statusDB.Text = "none";
            gpConnection.Show();
            tree.Nodes.Clear();
        }


        private void closeConnection()
        {

            Reset();
            if (connection != null /*&& connection.State == ConnectionState.Open*/)
                connection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeConnection();
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            closeConnection();
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = tree.SelectedNode;
            while(node.Parent != null)
            {
                node = node.Parent;
            }
            statusDB.Text = node.Text;

            if (tree.SelectedNode.Text != node.Text)
            {
                statusTable.Text = tree.SelectedNode.Text;
                setUpFilters();
                showData();
            }
            else
                statusTable.Text = "none";
        }

        private void setUpFilters()
        {
            ComboBox[] filters = { cbFilter1, cbFilter2, cbFilter3, cbFilter4, cbFilter5, cbFilter6, cbFilter7 };

            MySqlCommand sql = new MySqlCommand("USE " + statusDB + ";SELECT * FROM "+statusTable.Text+" LIMIT 0, 1", connection);
            MySqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                foreach (ComboBox c in filters)
                {
                    c.Items.Clear();

                
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                       c.Items.Add(statusTable.Text + "." + reader.GetName(i));                   
                    }
                
                }
            }

            reader.Close();
        }


        private string makeFilters()
        {
            ComboBox[] filters = { cbFilter1, cbFilter2, cbFilter3, cbFilter4, cbFilter5, cbFilter6, cbFilter7 };
            ComboBox[] operands = { cbOperand1, cbOperand2, cbOperand3, cbOperand4, cbOperand5, cbOperand6, cbOperand7 };
            TextBox[] values = { txtFilter1, txtFilter2, txtFilter3, txtFilter4, txtFilter5, txtFilter6, txtFilter7 };
            string filter = "";
            bool st = true;

            for (int i = 0; i < 7; i++)
            {
                //if(filters[i].SelectedIndex > -1 && operands[i].SelectedIndex > -1)
                //    MessageBox.Show(filters[i].SelectedItem.ToString() + operands[i].SelectedItem.ToString() + values[i].Text);

                if (filters[i].SelectedIndex > -1 && operands[i].SelectedIndex > -1 && isset(values[i].Text))
                {
                    //

                    if (!st)
                    {
                        filter += " AND ";
                    }

                    filter += filters[i].SelectedItem.ToString() + " "+operands[i].SelectedItem.ToString() + " "+ values[i].Text+" ";

                    st = false;
                }
            }


            filter = filter == "" ? "1 " : filter;
           // MessageBox.Show(filter);
            return filter;
            
        }


        private bool isset(string val)
        {
            if (/*val != null &&*/ val != "")
                return true;

            return false;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            statusTable.Text = tree.SelectedNode.Text;
            //setUpFilters();
            showData();
        }
    }
}
