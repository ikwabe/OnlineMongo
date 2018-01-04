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
using System.IO;

namespace OnlineMongo
{
    public partial class instantMessage : Form
    {
        public instantMessage()
        {
            InitializeComponent();
        }

        //a function to load email of the user
        private void loadEmail()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from users where user_id = '" + friendtb.user_id + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                toLabel.Text = table.Rows[0][3].ToString();
                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //for reply in inbox 
        private void replyEmail()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from sentmail where sentmail_id = '" + inbonTab.selectedMail + "' ";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                toLabel.Text = table.Rows[0][3].ToString();
                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function for messaging a friend from viewing the ptofile
        private void sendMessageFromViewProfile()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from users where user_id = '" + friendtb.user_id + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                toLabel.Text = table.Rows[0][3].ToString();
                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function for messaging a user from viewing the ptofile on post Tab
        private void sendMessageFromPostProfile()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from users where user_id = '" + postb.user_id + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                toLabel.Text = table.Rows[0][3].ToString();
                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void instantMessage_Load(object sender, EventArgs e)
        {
            if(userMenu.reply == true)
            {
                //message for friend
                loadEmail();
            }
            else if(inbonTab.reply == true)
            {
                replyEmail();
            }
            else if(userInfo.reply == true)
            {
                if (postb.profile == true)
                {
                    sendMessageFromPostProfile();
                }
                else if (friendtb.profile == true)
                {
                    sendMessageFromViewProfile();
                }               
            }
            else
            {
                MessageBox.Show("Erro 002");
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private static string senderEmail;
        private static string emailLocation;

        string subjectTextBox1 = "Instant Message";

        //a function to send instant message.
        private void sendMessage()
        {
            //for renaming the file on inserting in a directory
            int i = 0;


            //for the while loop
            Boolean check = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";

            //getting the computer user name for identifying the app directory location
            string currentComputerUserrName = Environment.UserName;

            //checking if the filename exist to avoid overiding
            while (check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1 + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1 + " by " + login.txt.Text + "(" + i + ").txt");
                    //writing to a text file the words from the richtext box.
                    email.WriteLine(richTextBox1.Text);
                    email.Close();
                    emailLocation = "C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1 + " by " + login.txt.Text + "(" + i + ").txt";
                    check = false;
                }
                else
                {

                }
                i++;
            }


            string sendmail = "select * from users where username = '" + login.txt.Text + "'";

            //command for retreiving email from the database
            MySqlCommand com = new MySqlCommand(sendmail, con);
            MySqlDataAdapter ad;

            try
            {
                con.Open();
                //retrieving sender email from the database
                ad = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                ad.Fill(table);
                senderEmail = table.Rows[0][3].ToString();
                ad.Dispose();
                string subject = subjectTextBox1 + "(By " + login.txt.Text + ")";
                string insert = "insert into sentmail (mailsubject,sentmsg,senderemail,receiveremail,status) values ('" + subject + "', @sentmsg,'" + senderEmail + "', '" + toLabel.Text + "','New')";


                byte[] mail = null;


                //fill the sent email to the byte for uploading it to the database

                mail = File.ReadAllBytes(emailLocation);
                //command for inseting email to the database
                MySqlCommand com1 = new MySqlCommand(insert, con);

                //inserting the email text file to the database
                com1.Parameters.AddWithValue("@sentmsg", mail);
                com1.ExecuteNonQuery();
                inbonTab.check = true;
                dashBoard.check = true;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendMessage();
            richTextBox1.Text = "";

        }
    }
}
