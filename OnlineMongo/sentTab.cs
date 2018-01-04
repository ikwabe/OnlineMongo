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
using Bunifu.Framework.UI;


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
        public static bool check = false;
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
                string readMesage = "select * from sentmail where senderemail = '" + userEmail + "' order by sentmail_id desc";
                //for reading the message in the file
                MySqlCommand com2 = new MySqlCommand(readMesage, con);

                ad = new MySqlDataAdapter(com2);
                DataTable table2 = new DataTable();
                ad.Fill(table2);
              


                for (int i = 0; i < table2.Rows.Count; i++)
                {
                  
                        //Take the email
                        string subject = table2.Rows[i][1].ToString();
                        Label email = new Label();
                        email = new Label();
                        email.Name = table2.Rows[i][0].ToString();
                        email.AutoSize = true;
                        email.ForeColor = Color.FromArgb(64, 64, 64);
                        email.Font = new Font("Cambria", 15, FontStyle.Regular);
                        email.Text = subject;
                        email.Cursor = Cursors.Hand;
                        email.Click += new EventHandler(email_Click);

                        //seperator for the emails
                        BunifuSeparator spr = new BunifuSeparator();
                        spr.LineThickness = 1;
                        spr.Height = 1;
                        spr.Anchor = AnchorStyles.Right;
                        spr.LineColor = Color.FromArgb(20, 105, 105, 105);
                        spr.Transparency = 30;
                        //adding the subjects to the pannel
                        flowLayoutPanel1.Controls.Add(email);
                        flowLayoutPanel1.Controls.Add(spr);

                   

                }
                check = true;
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
            check = true;
            //flowLayoutPanel1.BringToFront();
            //loadEmail();
           
        }

        private void sentTab_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.BringToFront();
            //loadEmail();

            timer1.Start();
            check = true;
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            backBtn.Visible = false;
            refreshBtn.Visible = true;
            richTextBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                flowLayoutPanel1.Controls.Clear();
                loadEmail();
                check = false;
            }
            else
            {

            }
        }

        private static string selectedMail;

        //function for email labels 
        private void email_Click(object sender, EventArgs e)
        {
            var email = sender as Label;
            selectedMail = email.Name;

            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from sentmail where sentmail_id = '" + selectedMail + "' ";

            //the string to update the opened email
            string opened = "update sentmail set status = 'Read' where sentmail_id = '" + selectedMail + "' ";
            MySqlCommand com1 = new MySqlCommand(opened, con);

            MySqlCommand com = new MySqlCommand(detail, con);
            try
            {

                con.Open();

                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                ad.Dispose();

                //a reader to read the email
                MySqlDataReader rd;

                try
                {
                    // MessageBox.Show(table.Rows[0][2].ToString());
                    if (table.Rows.Count > 0)
                    {
                        flowLayoutPanel1.Visible = false;
                       
                        richTextBox1.AppendText(table.Rows[0][2].ToString());
                        backBtn.Visible = true;
                        refreshBtn.Visible = false;
                        

                        //reading the email
                        rd = com1.ExecuteReader();
                        rd.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the Email does`nt exist..!");
                    }


                }
                catch
                {

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
            {

            }
        }
    }
}
