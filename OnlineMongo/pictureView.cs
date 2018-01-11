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
    public partial class pictureView : Form
    {
        public pictureView()
        {
            InitializeComponent();
        }

        //a function for viewing a post image when clicked
        private void postImageView()
        {
            //takin the image from the database
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from post where post_id = '" + postb.photName + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                    byte[] img = (byte[])table.Rows[0][1];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch
                {

                }

                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //afunction to view pic uploaded by user
        private void userUploadedImages()
        {
            //takin the image from the database
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from images where img_id = '" + pic.photName + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                    byte[] img = (byte[])table.Rows[0][1];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    Image picha = Image.FromStream(ms);
                    picha.Save("C:/Users/Shadrack Ikwabe/AppData/Roaming/UdoRead/Profile Photo(s)/profile.jpeg");

                }
                catch
                {

                }

                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //viewing profile picture
        private void ProfilePicture()
        {
            //takin the image from the database
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from users where user_id = '" + login.user_id + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                    byte[] img = (byte[])table.Rows[0][7];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    Image picha = Image.FromStream(ms);
                    picha.Save("C:/Users/Shadrack Ikwabe/AppData/Roaming/UdoRead/Profile Photo(s)/profile.jpeg");

                }
                catch
                {

                }

                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        string detail;

        //function for downloading the image
        private void Download()
        {
            //takin the image from the database
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            
            if (postb.chek == true)
            {
                detail = "select * from post where post_id = '" + postb.photName + "'";
            }
            if(pic.chek == true)
            {
                detail = "select * from images where img_id = '" + pic.photName + "'";

            }
            if(myProfile.chek == true)
            {
                detail = "select * from users where user_id = '" + login.user_id + "'";
            }
            
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                    if(myProfile.chek == true)
                    {
                        byte[] img = (byte[])table.Rows[0][7];
                        MemoryStream ms = new MemoryStream(img);

                        saveFileDialog1.InitialDirectory = @"C:\Users\Shadrack Ikwabe\Pictures";
                        saveFileDialog1.Title = "Save File As";
                        saveFileDialog1.Filter = "(*.JPG)|*.PNG";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {

                            Image picha = Image.FromStream(ms);
                            picha.Save(saveFileDialog1.FileName);

                        }



                    }
                    else
                    {
                        byte[] img = (byte[])table.Rows[0][1];
                        MemoryStream ms = new MemoryStream(img);

                        saveFileDialog1.InitialDirectory = @"C:\Users\Shadrack Ikwabe\Pictures";
                        saveFileDialog1.Title = "Save File As";
                        saveFileDialog1.Filter = "(*.JPG)|*.PNG";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {

                            Image picha = Image.FromStream(ms);
                            picha.Save(saveFileDialog1.FileName);

                        }

                    }
                   

                }
                catch
                {

                }

                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        private void pictureView_Load(object sender, EventArgs e)
        {
            if(postb.chek == true)
            {
                //view the clicked post image
                postImageView();
            }
            else if(pic.chek == true)
            {
                //view the clicked useruploaded image
                userUploadedImages();
            }
            else if(myProfile.chek == true)
            {
                //view the profile photo
                ProfilePicture();
            }
            else
            {
                MessageBox.Show("Error 003, image overrupt.");
            }
            

           
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Headerpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //double click for maximizing or minimizing the form
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
               CancelBtn.Location = new Point(1270, CancelBtn.Location.Y);
                //CancelBtn.BringToFront();

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CancelBtn.Location = new Point(841, CancelBtn.Location.Y);
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            Download();
        }
    }
}
