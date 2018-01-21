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
    public partial class changePwd : Form
    {
        public changePwd()
        {
            InitializeComponent();
        }

        private void changePwd_Load(object sender, EventArgs e)
        {
            logopic.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animator.ShowSync(logopic);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            string query = "select email,password from users where  email = '" + email.Text + "' and password = '" + GetMD5Hash(oldPwd.Text)  + "'";
            string update = "update  users set password = '" + GetMD5Hash(newPwd.Text) + "' where email = '" + email.Text + "'";

            MySqlCommand com = new MySqlCommand(query, con);
            MySqlCommand com1 = new MySqlCommand(update, con);
            MySqlDataReader reader;
            MySqlDataReader reader1;
            DataTable table = new DataTable();


            try
            {
                con.Open();

                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();

                if (table.Rows.Count > 0 && newPwd.Text == rtPwd.Text)
                {

                    reader1 = com1.ExecuteReader();
                    reader1.Close();
                    MessageBox.Show("Password Change Successiful", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    email.Text = "";
                    oldPwd.Text = "";
                    newPwd.Text = "";
                    rtPwd.Text = "";
                }

                else
                {
                    MessageBox.Show("Particulars did`nt match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }

            catch (MySqlException ex) {
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
