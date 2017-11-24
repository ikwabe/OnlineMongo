﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
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
                if (pwd.Text == rtPwd.Text)
                {
                    DataTable table1 = new DataTable();
                    reader1 = com1.ExecuteReader();
                    table1.Load(reader1);
                    reader1.Close();
                    if (table1.Rows.Count > 0)
                    {
                        MessageBox.Show("The enterd email, already exist. Please login", "Information", MessageBoxButtons.OK);
                        email.Text = "";
                    }
                    else
                    {
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
                            reader = com.ExecuteReader();
                            reader.Close();
                            MessageBox.Show("Welcome,You have been added", "User added", MessageBoxButtons.OK);
                            this.Close();
                            login lgn = new login();
                            lgn.Show();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Password did not match");
                }
               
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}