using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace OnlineMongo
{
    public partial class pic : UserControl
    {

        //creating instance to access this control
        public static pic _instance;
        public static pic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new pic();
                return _instance;
            }

        }
        public pic()
        {
            InitializeComponent();
           
        }

        int i = 0 ;
        string[] image;
        PictureBox phott;
        private PictureBox photo()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string userId = "select * from users where username = '" + login.txt.Text + "'";
            MySqlDataAdapter ad;

            //taking user id from the database
            MySqlCommand com1 = new MySqlCommand(userId, con);
            ad = new MySqlDataAdapter(com1);
            DataTable table = new DataTable();
            ad.Fill(table);
            string user_idc = table.Rows[0][0].ToString();
            ad.Dispose();

            int user_id = int.Parse(user_idc);

            //reading images query
            string readImage = "select * from images where user_id = '" + user_id + "' order by img_id DESC";

            MySqlCommand com = new MySqlCommand(readImage, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);


            PictureBox[] phot = new PictureBox[table1.Rows.Count];
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                i++;
                string image_id = table1.Rows[j][0].ToString();
                phot[j] = new PictureBox();
                    phot[j].Width = 300;
                    phot[j].Height = 172;
                    phot[j].Name = image_id;
                    phot[j].SizeMode = PictureBoxSizeMode.StretchImage;
                    phot[j].Cursor = Cursors.Hand;
                    phot[j].Click += new EventHandler(photoClickBtn_Click);

                //takking photo to the panel
                try
                {
                    byte[] img = (byte[])table1.Rows[j][1];
                    MemoryStream ms = new MemoryStream(img);
                    phot[j].Image = Image.FromStream(ms);
                   

                }
                catch
                {

                }

                flowLayoutPanel1.Controls.Add(phot[j]);
            }
            
            ad.Dispose();
            return phott;
           
        }

        //the strig to hold the pic name for retrieving it from the database
        public static string photName;
        public static bool chek = false;
        //function for handling picture click
        private void photoClickBtn_Click(object sender, EventArgs e)
        {
            var picName = sender as PictureBox;

            //taking the clicked PictureName to the static string
            photName = picName.Name;
            //for checking if the is true
            chek = true;

            postb.chek = false;
            myProfile.chek = false;
            //testing
            imageOption img = new imageOption();
            img.Show();

        }

        private void addPic_Click(object sender, EventArgs e)
        {
            addPicToDb();
            flowLayoutPanel1.Controls.Clear();
            timer1.Start();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dlg = sender as OpenFileDialog;
            if (20 < dlg.FileNames.Length)
            {
                MessageBox.Show("Please, Select Maximum of 20 images");
                e.Cancel = true;
            }
        }


        private void addPicToDb()
        {
            DateTime img_date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string userId = "select * from users where username = '" + login.txt.Text + "'";

           
           
            try
            {
                con.Open();
                openFileDialog1.Filter = "(*.JPG)|*.JPG";
                MessageBox.Show("Please, Select Maximum of 20 images");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    image = openFileDialog1.FileNames;
                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {


                        byte[] images = null;
                        FileStream stream = new FileStream(image[i], FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);




                        MySqlDataAdapter ad;
                       

                        //taking user id from the database
                        MySqlCommand com1 = new MySqlCommand(userId, con);
                        ad = new MySqlDataAdapter(com1);
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        string user_idc = table.Rows[0][0].ToString();
                        ad.Dispose();

                        int user_id = int.Parse(user_idc);
                        //
                        //string to insert data
                        string pic = "insert into images(image,user_id,img_date) values(@image,'" + user_id + "','" + img_date.ToShortDateString() + "')";
                    
                        //command to insert photos
                        MySqlCommand com = new MySqlCommand(pic, con);
                        com.Parameters.Add(new MySqlParameter("@image", images));
                        com.ExecuteNonQuery();
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            con.Close();

        }

        private void pic_Load(object sender, EventArgs e)
        {
            timer1.Start();
            reLoadTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            photo();
            timer1.Stop();
          
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            timer1.Start();
        }
        //has to be deleted
        public static int x;
        public static int y;
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        public static bool picCheck = false;
        private void reLoadTimer_Tick(object sender, EventArgs e)
        {
            if(picCheck == true)
            {
                flowLayoutPanel1.Controls.Clear();
                timer1.Start();
                picCheck = false;
            }
            else
            {

            }

        }
    }

   

    
   
}   

