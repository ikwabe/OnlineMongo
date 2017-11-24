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
    public partial class pinWindow : Form
    {
        public pinWindow()
        {
            InitializeComponent();
            dataAc();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            login lgn = new login();
            lgn.Show();
        }

        private void optionBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter Password";
            pinTextBox.Visible = false;
            pinTextBox.Text = "";
            pwdTextBox.Visible = true;
            optionBtn.Visible = false;
            pinBtn.Visible = true;
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter PIN";
            pwdTextBox.Visible = false;
            pwdTextBox.Text = "";
            pinTextBox.Visible = true;
            pinBtn.Visible = false;
            optionBtn.Visible = true;

        }

        private void pinWindow_Load(object sender, EventArgs e)
        {
            
            label1.Text = "Enter PIN";
            pwdTextBox.Visible = false;
            
        }


        private void pwdTextBox_OnValueChanged(object sender, EventArgs e)
        {
           
            if (pwdTextBox.Text == pwd)
            {
                pwdTextBox.Enabled = false;
                dashBoard dshb = new dashBoard();
                dshb.Show();
                this.Close();
            }
        }

        private static string pn;
        private static string pwd;
        private void dataAc()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string schPIN = "select pin from users where  username = '" + login.txt.Text + "'";
            string schPWD = "select password from users where  username = '" + login.txt.Text + "'";
            MySqlCommand com = new MySqlCommand(schPIN, con);
            MySqlCommand com1 = new MySqlCommand(schPWD, con);
            MySqlDataReader reader;
            MySqlDataReader reader2;
            try
            {
                con.Open();
                //execute PIN
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                     pn = reader.GetString("pin");
                }
                reader.Close();

                //execute password
                reader2 = com1.ExecuteReader();
                while (reader2.Read())
                {
                    pwd = reader2.GetString("password");
                }
                reader2.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void pinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pinTextBox.Text == pn)
            {
                dashBoard dsb = new dashBoard();
                this.Close();
                dsb.Show();
            }
        }
    }
}