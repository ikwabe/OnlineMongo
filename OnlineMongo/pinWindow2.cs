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
    public partial class pinWindow2 : Form
    {
        public pinWindow2()
        {
            InitializeComponent();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pinTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.dbConnection;
                string schPIN = "select pin from users where  username = '" + login.txt.Text + "'";
                MySqlCommand com = new MySqlCommand(schPIN, con);
                MySqlDataReader reader;
                try
                {
                    con.Open();

                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string pin = reader.GetString("pin");
                        if (pinTextBox.Text == pin)
                        {
                            changePIN chp = new changePIN();
                            this.Close();
                            chp.Show();
                        }
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
           
        }

        
    }
}
