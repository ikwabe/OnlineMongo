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
using System.Threading;
using System.IO;
using Bunifu.Framework.UI;

namespace OnlineMongo
{
    public partial class inbonTab : UserControl
    {
        public static inbonTab _instance;
        public static inbonTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inbonTab();
                return _instance;
            }
        }
        public inbonTab()
        {
            InitializeComponent();
            
        }
        public static bool check = false;
        public static string enumber;
        public static bool reply = false;

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
                string readEmail = "select mailsubject,senderemail from sentmail where receiveremail = '" + userEmail + "'";
                string readMesage = "select * from sentmail where receiveremail = '" + userEmail + "' order by sentmail_id desc";
                //for reading the message in the file
                MySqlCommand com2 = new MySqlCommand(readMesage, con);

                ad = new MySqlDataAdapter(com2);
                DataTable table2 = new DataTable();
                ad.Fill(table2);
                int j = 0;
               
               
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    //the email is new
                    if (table2.Rows[i][5].ToString() == "New")
                    {
                        Label sign = new Label();
                        sign.Text = "•";
                        sign.Font = new Font("Cambria", 20, FontStyle.Bold);
                        sign.ForeColor = Color.DarkGreen;
                        j++;
                        //Take the email
                        string subject = table2.Rows[i][1].ToString();
                       
                        Label email = new Label();
                        email = new Label();
                        email.Name = table2.Rows[i][0].ToString();
                        email.AutoSize = true;
                        email.ForeColor = Color.Black;
                        email.Font = new Font("Cambria", 15, FontStyle.Bold);
                        email.Text = subject;
                        email.Cursor = Cursors.Hand;
                        email.Click += new EventHandler(email_Click);

                        //seperator for the emails
                        BunifuSeparator spr = new BunifuSeparator();
                        spr.LineThickness = 1;
                        spr.Height = 1;
                        spr.Anchor = AnchorStyles.Right;
                        spr.LineColor = Color.FromArgb(20, 105, 105, 105);
                        spr.Transparency = 25;
                        //adding the subjects to the pannel
                        flowLayoutPanel1.Controls.Add(sign);
                        flowLayoutPanel1.Controls.Add(email);
                        flowLayoutPanel1.Controls.Add(spr);

                    }
                    else
                    {
                        //Take the email
                        string subject = table2.Rows[i][1].ToString();
                        Label email = new Label();
                        email = new Label();
                        email.Name = table2.Rows[i][0].ToString();
                        email.AutoSize = true;
                        email.ForeColor = Color.FromArgb(129, 129, 131);
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
                        spr.Transparency = 25;
                        //adding the subjects to the pannel
                        flowLayoutPanel1.Controls.Add(email);
                        flowLayoutPanel1.Controls.Add(spr);

                    }
                       
                }
                emailNumberLabel.Text = "(" + j + ")";
                enumber = j.ToString();
                ad.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void inbonTab_Load(object sender, EventArgs e)
        {
            timer1.Start();
            refreshBar.Visible = true;
            refreshBar.animated = true;
            check = true;
            refreshBar.Visible = false;
            refreshBar.animated = false;
        }

      

        public static string selectedMail;
        

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
                        refreshBar.Visible = true;
                        refreshBar.animated = true;

                        richTextBox1.AppendText(table.Rows[0][2].ToString());
                        backBtn.Visible = true;
                        refreshBtn.Visible = false;
                        refreshBar.Visible = false;
                        deleteBtn.Visible = true;

                        //reading the email
                        rd = com1.ExecuteReader();
                        rd.Close();
                        replyBtn.Visible = true;
                        check = true;
                        dashBoard.check = true;
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
       

        private void backBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            refreshBtn.Visible = true;
            replyBtn.Visible = false;
            backBtn.Visible = false;
            deleteBtn.Visible = false;
            richTextBox1.Clear();
        }


      

        //function to refresh the retrieval of email
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshBar.Visible = true;
            refreshBar.animated = true;
            check = true;
            refreshBar.Visible = false;
            refreshBar.animated = false;
            backBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            replyBtn.Visible = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string insert = "insert into trash select * from sentmail where sentmail_id = '" + selectedMail + "'";
            string delete = "delete from sentmail where sentmail_id = '" + selectedMail + "' ";

            MySqlCommand com = new MySqlCommand(insert, con);
            MySqlCommand com1 = new MySqlCommand(delete, con);
            MySqlDataReader reader;
            try
            {


               con.Open();
                //inserting the deletede message to the trash
               reader = com.ExecuteReader();
               reader.Close();

                //deleting the message from the sentmail table
                reader = com1.ExecuteReader();
                reader.Close();

                MessageBox.Show("Moved to Trash");
                richTextBox1.Clear();
                check = true;
                trashTab.check = true;
                flowLayoutPanel1.Visible = true;
                backBtn.Visible = false;
                refreshBtn.Visible = true;
                deleteBtn.Visible = false;
                replyBtn.Visible = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(check == true)
            {
                flowLayoutPanel1.Controls.Clear();
                loadEmail();
                check = false;
            }
            else
            {

            }
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar)|| char.IsLetter(e.KeyChar)||char.IsPunctuation(e.KeyChar)||char.IsSymbol(e.KeyChar))
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
            if(e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
            {

            }
        }
        
        private void replyBtn_Click(object sender, EventArgs e)
        {
            reply = true;
            userMenu.reply = false;
            userInfo.reply = false;
            instantMessage insMs = new instantMessage();
            insMs.Show();
        }
    }
}
