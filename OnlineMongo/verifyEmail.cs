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
    public partial class verifyEmail : Form
    {
       
        public verifyEmail()
        {
            InitializeComponent();
           
        }
        public static string email;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            this.Close();
            login lg = new login();
            lg.Show();
        }

        private void emailCheck()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";

            string emails = "select email  from users where email = '" + emailTxt.Text +"'";
            MySqlDataReader ad;
            MySqlCommand com = new MySqlCommand(emails, con);
            try
            {
                con.Open();
                ad = com.ExecuteReader();
                while (ad.Read())
                {
                    email = ad.GetString("email");
                }
                
                ad.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();

        }


        private void verifyEmail_Load(object sender, EventArgs e)
        {
           
        }
       

        private void emailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (emailTxt.Text == "")
            {
                emailBar.Visible = false;
                emailBar.animated = false;
                emailPassPic.Visible = false;

            }
            else
            {
              
                 
                emailBar.Visible = true;
                emailBar.animated = true;
                if (e.KeyCode == Keys.Enter)
                {
                    emailCheck();

                    if (emailTxt.Text == email)
                    {

                        emailBar.Visible = false;
                        emailBar.animated = false;
                        emailPassPic.Visible = true;
                        this.Close();
                        try
                        {
                            resetPwd rs = new resetPwd();
                            rs.Show();
                        }
                        catch
                        {

                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("The email is not registerd. Please SIGN UP for free Now!");
                    }
                }
                else
                {

                }
               
            }
        }
    }
}
