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
    public partial class resetPwd : Form
    {
       
        public resetPwd()
        {
            InitializeComponent();
            dataCheck();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Close();
            
        }

        private void showSecBox()
        {
            secword.Visible = true;
            secwordLb.Visible = true;
        }

        private void HideSecBox()
        {
            secword.Visible = false;
            secwordLb.Visible = false;
            secwordBar.Visible = false;
            secwordBar.animated = false;
            secwordPassPic.Visible = false;
            secword.Text = "";
        }

        private void HidePwdBtn()
        {
            resetPwdBtn.Visible = false;
            resLb.Visible = false;
        }

        private void ShowPwdBtn()
        {
            resetPwdBtn.Visible = true;
            resLb.Visible = true;
        }
        private static string  emailTxt;
        private static string  secwordTxt;
        private static string  secqnTxt;
        

        private void dataCheck()
        {
           
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

             string email = "select email, secword,secqn from users where email = '"+ verifyEmail.email +"'";
            MySqlDataReader ad;
            MySqlCommand com = new MySqlCommand(email, con);
           
            try
            {
                con.Open();
                ad = com.ExecuteReader();
                while (ad.Read())
                {
                    try
                    {
                        emailTxt = ad.GetString("email");
                        secwordTxt = ad.GetString("secword");
                        secqnTxt = ad.GetString("secqn");
                    }
                    catch
                    {
                        
                        if (MessageBox.Show("Sorry, this email does not contain a secret word. We are sorry to inform you that the password can not be reset. Please create another acount and remember to set the secret word for password reset. Thank you. ", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                            login lg = new login();
                            lg.Show();
                        }
                    }
                    
                }
                
                ad.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }
      
       

        private void secword_OnValueChanged(object sender, EventArgs e)
        {
            
            if (secword.Text == "")
            {
                secwordBar.Visible = false;
                secwordBar.animated = false;
                secwordPassPic.Visible = false;
            }
            else
            {
                secwordBar.Visible = true;
                secwordBar.animated = true;
                if (secword.Text == secwordTxt)
                {
                    
                    secwordBar.Visible = false;
                    secwordBar.animated = false;
                    secwordPassPic.Visible = true;
                    ShowPwdBtn();
                }
                else
                {
                    HidePwdBtn();
                }
            }

               
        }

        private void resetPwdBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            string update = "update users set password = '"+"UdoRead1234" +"' where email = '"+ email.Text +"'";

            MySqlCommand com = new MySqlCommand(update, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                reader.Close();
                MessageBox.Show("Password Reset Succesiful. Your Password is UdoRead1234. You can change it, when you login to your account.");
                this.Close();
                login lg = new login();
                lg.Show();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void resetPwd_Load(object sender, EventArgs e)
        {
            email.Text = verifyEmail.emailHold;
            email.Enabled = false;
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                emailBar.Visible = false;
                emailBar.animated = false;
                emailPassPic.Visible = false;

            }
            else
            {
                emailBar.Visible = true;
                emailBar.animated = true;
                if (email.Text == emailTxt)
                {

                    emailBar.Visible = false;
                    emailBar.animated = false;
                    emailPassPic.Visible = true;
                    secwordLb.Text = secqnTxt;
                    showSecBox();



                }
                else
                {
                    HideSecBox();
                    HidePwdBtn();
                }
            }

        }
    }
}
