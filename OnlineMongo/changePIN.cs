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

namespace OnlineMongo
{
    public partial class changePIN : Form
    {
        public changePIN()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void changePINBtn_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string update = "update  users set pin = '" + pinTextBox1.Text + "' where  username = '" + login.txt.Text + "'";
            MySqlCommand com1 = new MySqlCommand(update, con);
            MySqlDataReader reader;


            try {
                con.Open();

                if (pinTextBox1.Text == pinTextBox2.Text)
                {
                    reader = com1.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("PIN changed.", "Change", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    label1.Text = "Not Match, Repeat";
                    pinTextBox2.Text = "";

                }


            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
        }

        private void changePIN_Load(object sender, EventArgs e)
        {
           
            pinTextBox1.Visible = true;
            pinTextBox2.Visible = false;
            changePINBtn.Visible = false;
        }
        private void pinTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Text = "Repeat PIN";
                pinTextBox1.Visible = false;
                pinTextBox2.Visible = true;
                changePINBtn.Visible = true;
            }
        }
    }
}
