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
using System.Text.RegularExpressions;

namespace OnlineMongo
{
   
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
           
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            login lgn = new login();
            lgn.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login lgn = new login();
            lgn.Show();

        }

        private void signUp_Load(object sender, EventArgs e)
        {
            logopic.Visible = false;
            animate.Start();
        }

        private void animate_Tick(object sender, EventArgs e)
        {
            animate.Stop();
            animator.ShowSync(logopic);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //sign up button

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string query = "insert into users(fname,lname,email,password,username,pin) values ('"+ fname.Text +"', '"+ lname.Text +"', '"+ email.Text +"','"+ pwd.Text +"','"+ username.Text + "','" + pinLb.Text + "')";
            string chek = "select email from users where email = '"+ email.Text +"'";
            string chek2 = "select username from users where username = '"+ username.Text +"'";

            MySqlCommand com = new MySqlCommand(query,con);
            MySqlCommand com1 = new MySqlCommand(chek, con);
            MySqlCommand com2 = new MySqlCommand(chek2, con);

            try
            {
                con.Open();
                MySqlDataReader reader;
                MySqlDataReader reader1;
                MySqlDataReader reader2;

                //checking if the username empty
                if (username.Text == "")
                {
                    MessageBox.Show("Username Field can not be empty");
                }
                else
                {


                    //verifying if the password is correct
                    if (pwd.Text == rtPwd.Text)
                    {

                        DataTable table1 = new DataTable();
                        reader1 = com1.ExecuteReader();
                        table1.Load(reader1);
                        reader1.Close();
                        //checking if the email exist in the database
                        if (table1.Rows.Count > 0)
                        {
                            MessageBox.Show("The enterd email, already exist. Please login", "Information", MessageBoxButtons.OK);
                            email.Text = "";
                        }
                        else
                        {
                            //Cheking if the user is already registerd

                            DataTable table2 = new DataTable();
                            reader2 = com2.ExecuteReader();
                            table2.Load(reader2);
                            reader2.Close();

                            if (table2.Rows.Count > 0)
                            {
                                MessageBox.Show("The enterd username, already exist. Please, change username", "Information", MessageBoxButtons.OK);
                                username.Text = "";
                            }
                            else
                            {
                                //verifying the email if is valid

                                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                                if (!reg.IsMatch(email.Text))
                                {
                                    MessageBox.Show("Please enter the valid email");
                                }
                                else
                                {
                                    string password = pwd.Text;
                                    //check if the password is strong 
                                    bool validPassword = password.Any(char.IsDigit) && !password.All(char.IsLetterOrDigit) && password.Length >= 6;

                                    if (validPassword == true)
                                    {
                                        //creating the account

                                        reader = com.ExecuteReader();
                                        reader.Close();
                                        MessageBox.Show("Welcome,You have been added", "User added", MessageBoxButtons.OK);
                                        this.Close();
                                        login lgn = new login();
                                        lgn.Show();

                                    }
                                    else
                                    {
                                        MessageBox.Show("The Password should contain at least later, number,special character and more than 6 characters ");
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                    }
                }
               
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function handle the entrace of number in first name and last name
        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar)&& !char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
