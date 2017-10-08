using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OnlineMongo
{
    public partial class sentTab : UserControl
    {
        public static sentTab _instance;
        public static sentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sentTab();
                return _instance;
            }
        }
        public sentTab()
        {
            InitializeComponent();
        }

        private void loadEmail()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from users where username = '" + login.txt.Text + "'";

            MySqlCommand com = new MySqlCommand(detail, con);
            try
            {

                con.Open();

                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                string userEmail = table.Rows[0][3].ToString();
                ad.Dispose();

                //reading all emails correspond to the user email
                string readEmail = "select mailsubject from sentmail where senderemail = '" + userEmail + "'";
                string readMesage = "select mailsubject Message from sentmail where senderemail = '" + userEmail + "' order by sentmail_id desc";
                //for reading the message in the file
                MySqlCommand com2 = new MySqlCommand(readMesage, con);

                ad = new MySqlDataAdapter(com2);
                DataTable table2 = new DataTable();
                ad.Fill(table2);
                emailsList.DataSource = table2;
                ad.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private static string selectedWord;
        private void emailsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int index = e.RowIndex;
            try
            {
                DataGridViewRow selectedIndex = emailsList.Rows[index];
                selectedWord = selectedIndex.Cells[0].Value.ToString();
            }
            catch
            {

            }
           
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from sentmail where mailsubject = '"+ selectedWord + "' ";

            MySqlCommand com = new MySqlCommand(detail, con);
            try
            {

                con.Open();

                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                   // MessageBox.Show(table.Rows[0][2].ToString());
                    if(table.Rows.Count > 0)
                    {
                        emailsList.Visible = false;
                        richTextBox1.AppendText(table.Rows[0][2].ToString());
                        backBtn.Visible = true;
                        refreshBtn.Visible = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the Email does`nt exist..!");
                    }
                    
                   
                }
                catch
                {

                }
                ad.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            emailsList.BringToFront();
            loadEmail();
           
        }

        private void sentTab_Load(object sender, EventArgs e)
        {
            emailsList.BringToFront();
            loadEmail();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            emailsList.Visible = true;
            backBtn.Visible = false;
            refreshBtn.Visible = true;
            richTextBox1.Clear();
        }
    }
}
