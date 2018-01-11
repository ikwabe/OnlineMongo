using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace OnlineMongo
{
    public partial class sendLectOrBook : Form
    {
        public sendLectOrBook()
        {
            InitializeComponent();
        }

        byte[] bytes = null;
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.pdf)|*.PDF";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
               
                try
                {
                    bytes = File.ReadAllBytes(openFileDialog1.FileName);

                }
                catch 
                {
                    
                }
                

            }
            else
            {
                MessageBox.Show("No Item to send");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            DateTime date = DateTime.Today;

            try
            {
                con.Open();
                MySqlDataAdapter da;
                DataTable table = new DataTable();
                string emailTake = "select * from users where user_id = '" + login.user_id + "'";

                MySqlCommand com1 = new MySqlCommand(emailTake, con);

                //taking the login email
                da = new MySqlDataAdapter(com1);
                da.Fill(table);
                da.Dispose();

                string insert = "insert into sentitems(item,item_name,sender_email,receiver_email,date,status) values ( @item,'" + openFileDialog1.SafeFileName + "','" + table.Rows[0][3].ToString() + "','" + emailTxt.Text + "','" + date.ToShortDateString() + "','New')";


                MySqlCommand com = new MySqlCommand(insert, con);

                if (emailTxt.Text == "" || emailTxt == null)
                {
                    MessageBox.Show("Please enter the receiver email.");

                }
                else if(openFileDialog1.FileName == null || openFileDialog1.FileName == "" || openFileDialog1.FileName == "openFileDialog1")
                {
                    MessageBox.Show("Please load the book to send.");
                }
                else
                {
                    Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    if (!reg.IsMatch(emailTxt.Text))
                    {
                        MessageBox.Show("Please enter the valid receiver email");
                    }
                    else
                    {
                        //insert the item in the database
                        com.Parameters.AddWithValue("@item", bytes);
                        com.ExecuteNonQuery();
                        emailTxt.Text = null;
                        textBox1.Text = null;
                        openFileDialog1.FileName = null;
                        MessageBox.Show("Sent");

                    }
                    

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
