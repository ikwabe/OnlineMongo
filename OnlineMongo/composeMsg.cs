using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.io;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace OnlineMongo
{
    public partial class composeMsg : UserControl
    {
        public static composeMsg _instance;
        public static composeMsg Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new composeMsg();
                return _instance;
            }
        }
        public composeMsg()
        {
            InitializeComponent();
        }


        private void composeMsg_Load(object sender, EventArgs e)
        {
           
            richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont.FontFamily, 11);
            foreach(FontFamily item in FontFamily.Families)
            {
                fontTypeBtn.Items.Add(item.Name.ToString());
            }
            fontTypeBtn.Text = "Century Gothic";
        }

      
        private void boldBtn_Click(object sender, EventArgs e)
        {
            italicBtn.Checked = false;
            underlineBtn.Checked = false;
            try
            {
                if (richTextBox1.SelectionFont.Bold == false)
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Regular);
                }
            }
            catch
            {
                boldBtn.Checked = false;
            }
           

        }

      

        private void italicBtn_Click(object sender, EventArgs e)
        {
            boldBtn.Checked = false;
            underlineBtn.Checked = false;
            try
            {
                if (richTextBox1.SelectionFont.Italic == false)
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Regular);
                }
            }
            catch
            {
                italicBtn.Checked = false;
            }
            


        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            boldBtn.Checked = false;
            italicBtn.Checked = false;
            try
            {
                if (richTextBox1.SelectionFont.Underline == false)
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Underline);
                }
            }
            catch
            {
                underlineBtn.Checked = false;
            }
           

        }

        private void fontSizeBtn_TextChanged(object sender, EventArgs e)
        {
            boldBtn.Checked = false;
            italicBtn.Checked = false;
            underlineBtn.Checked = false;
            try
            {
                Single fontSz = Convert.ToSingle(fontSizeBtn.Text);
                richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font.FontFamily,fontSz );
            }
            catch
            {
                fontSizeBtn.Text = "11";
            }
            
        }

        private void fontTypeBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            boldBtn.Checked = false;
            italicBtn.Checked = false;
            underlineBtn.Checked = false;
            try
            {
             richTextBox1.SelectionFont = new System.Drawing.Font(fontTypeBtn.Text, richTextBox1.Font.Size);
                
            }
            catch
            {
                fontTypeBtn.Text = "Century Gothic";
            }
            
        }

        private void alginLeft_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            catch
            {

            }
            
            alginLeft.Checked = false;
        }

        private void alignCenter_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch
            {

            }
            alignCenter.Checked = false;
        }

        private void alignRight_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            catch
            {

            }
            alignRight.Checked = false;
        }
        private static string senderEmail;
        private static string emailLocation;
        private void sendBtn1_Click(object sender, EventArgs e)
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
            while(check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt");
                    //writing to a text file the words from the richtext box.
                    email.WriteLine(richTextBox1.Text);
                    email.Close();
                    emailLocation = "C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt";
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
                senderEmail =table.Rows[0][3].ToString();                  
                ad.Dispose();
                string subject = subjectTextBox1.Text + "(By " + login.txt.Text + ")";
                string insert = "insert into sentmail (mailsubject,sentmsg,senderemail,receiveremail) values ('" + subject + "', @sentmsg,'" + senderEmail + "', '" + toTextBox1.Text + "')";

               
                byte[] mail = null;
               
                  
               //fill the sent email to the byte for uploading it to the database

               mail = File.ReadAllBytes(emailLocation);
                //command for inseting email to the database
                MySqlCommand com1 = new MySqlCommand(insert, con);

                //inserting the email text file to the database
                com1.Parameters.AddWithValue("@sentmsg", mail);
                com1.ExecuteNonQuery();

                MessageBox.Show("Message Sent. If you need to send the same message, please change the tittle or the email for message safety.");

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
    }
}
