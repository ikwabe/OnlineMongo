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
using Bunifu.Framework.UI;

namespace OnlineMongo
{
    public partial class login : Form
    {
        public static BunifuMaterialTextbox txt = new BunifuMaterialTextbox();
        public static string user_id;
        public static string fullname;
        public login()
        {
            InitializeComponent();
        }

        public static string dbConnection = "server = localhost; user = root; password =ikwabe04; database = udoread";
       
        

        private void animate_Tick(object sender, EventArgs e)
        {
            animate.Stop();
            annimator.ShowSync(logopic);
        }
        public static string user_email;
        private void login_Load(object sender, EventArgs e)
        {
            logopic.Visible = false;
            animate.Start();

            txt.Size = new Size(295, 33);
            txt.Location = new Point(124, 282);
            txt.Visible = true;
            txt.Margin = new Padding(4, 4, 4, 4);
            txt.ForeColor = Color.FromArgb(64,64,64);
            txt.BackColor = Color.FromArgb(30, 0, 40);
            txt.HintForeColor = Color.FromArgb(64,64,64);
           
            Controls.Add(txt);

        }

       //password 
        private void pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = dbConnection;
                string signIn = "select user_id, email, password,username,secword,fname,lname from users where username = '" + txt.Text + "' and password = '" + pwd.Text + "'";
                MySqlCommand com = new MySqlCommand(signIn, con);
                try
                {
                    con.Open();

                    MySqlDataReader reader;
                    DataTable table = new DataTable();
                    if (txt.Text == "")
                    {
                        label3.Text = "Username field can not be empty.";
                    }
                    else if (pwd.Text == "")
                    {
                        label3.Text = "Password field can not be empty.";
                    }
                    else
                    {
                        //checking the database
                        reader = com.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        if (table.Rows.Count > 0)
                        {
                            pwd.Enabled = false;
                            if (table.Rows[0][4] == null || table.Rows[0][4] == DBNull.Value)
                            {
                                MessageBox.Show("Please remember to set your SECRET WORD for password recovery and security purposes.");
                                //capturing user id for public purposes
                                user_id = table.Rows[0][0].ToString();
                                user_email = table.Rows[0][1].ToString();
                                fullname = table.Rows[0][5].ToString() + " " + table.Rows[0][6].ToString();
                                this.Hide();
                                dashBoard dsb = new dashBoard();
                                dsb.Show();

                            }
                            else
                            {
                                //capturing user id for public purposes
                                user_id = table.Rows[0][0].ToString();
                                user_email = table.Rows[0][1].ToString();
                                fullname = table.Rows[0][5].ToString() + " " + table.Rows[0][6].ToString();
                                this.Hide();
                                dashBoard dsb = new dashBoard();
                                dsb.Show();
                            }
                        }
                        else
                        {
                            label3.Text = "You have enterd a wrong Password or Username";
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {

            }
        }

       

        private void signUpLink_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                signUp sgp = new signUp();
                sgp.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void forgetPwdLink_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                verifyEmail ve = new verifyEmail();
                ve.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {

            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = dbConnection;
            string signIn = "select user_id, email, password,username,secword,fname,lname from users where username = '" + txt.Text + "' and password = '" + GetMD5Hash(pwd.Text) + "'";
            MySqlCommand com = new MySqlCommand(signIn, con);
            try
            {
                con.Open();

                MySqlDataReader reader;
                DataTable table = new DataTable();
                if (txt.Text == "")
                {
                    label3.Text = "Username field can not be empty.";
                }
                else if (pwd.Text == "")
                {
                    label3.Text = "Password field can not be empty.";
                }
                else
                {
                    //checking the database
                    reader = com.ExecuteReader();
                    table.Load(reader);
                    reader.Close();

                    if (table.Rows.Count > 0)
                    {
                        pwd.Enabled = false;
                        if (table.Rows[0][4] == null || table.Rows[0][4] == DBNull.Value)
                        {
                            MessageBox.Show("Please remember to set your SECRET WORD for password recovery and security purposes.");
                            //capturing user id for public purposes
                            user_id = table.Rows[0][0].ToString();
                            user_email = table.Rows[0][1].ToString();
                            fullname = table.Rows[0][5].ToString() + " " + table.Rows[0][6].ToString();
                            this.Hide();
                           
                            dashBoard dsb = new dashBoard();
                            dsb.Show();
                           
                        }
                        else
                        {
                            //capturing user id for public purposes
                            user_id = table.Rows[0][0].ToString();
                            user_email = table.Rows[0][1].ToString();
                            fullname = table.Rows[0][5].ToString() + " " + table.Rows[0][6].ToString();
                            this.Hide();
                            dashBoard dsb = new dashBoard();
                            dsb.Show();
                           
                        }
                    }
                    else
                    {
                        label3.Text = "You have enterd a wrong Password or Username";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }
    }
}
