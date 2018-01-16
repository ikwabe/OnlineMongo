using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace OnlineMongo
{
    public partial class myProfile : UserControl
    {
        public static myProfile _instance;
        public static myProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new myProfile();
                return _instance;
            }
        }
        public myProfile()
        {
            InitializeComponent();
           
        }
        string computerUserName = Environment.UserName;
        public static bool check = false;
        string location;
        private void changePrflPhoto_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string pic = "update users set prfpic = @prfpic where user_id = '" + login.user_id + "'";
            try
            {
                openFileDialog1.Filter = "(*.JPG)|*.JPG";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    location = openFileDialog1.FileName;

                }

                //compress the profile photo.
                CompressImage();              

               
                byte[] images = null;
                try
                {
                    
                    FileStream stream = new FileStream("C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Image/image.Jpeg", FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                }
                catch
                {

                }
                
                MySqlCommand com = new MySqlCommand(pic, con);


                con.Open();
                com.Parameters.AddWithValue("@prfpic", images);
                com.ExecuteNonQuery();
                check = true;
             
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();



        }
        //a function to load profile information for the user login
        private void profile()
        {
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

                uname.Text = table.Rows[0][6].ToString();
                bday.Text = table.Rows[0][8].ToString();
                sex.Text = table.Rows[0][20].ToString();
                work.Text = table.Rows[0][9].ToString();
                nationality.Text = table.Rows[0][10].ToString();
                education.Text = table.Rows[0][11].ToString();
                home.Text = table.Rows[0][12].ToString();
                music.Text = table.Rows[0][13].ToString();
                video.Text = table.Rows[0][14].ToString();
                actor.Text = table.Rows[0][15].ToString();
                book.Text = table.Rows[0][16].ToString();
                series.Text = table.Rows[0][17].ToString();
                game.Text = table.Rows[0][18].ToString();
                channel.Text = table.Rows[0][19].ToString();
                userPrflName.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                try
                {
                    byte[] img = (byte[])table.Rows[0][7];
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

       

        private void myProfile_Load(object sender, EventArgs e)
        {
            timer1.Start();
            check = true;
        }
        public static bool chek = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chek = true;
            pic.chek = false;
            postb.chek = false;
            pictureView pc = new pictureView();
            pc.Show(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(check == true)
            {
                profile();
                check = false;
            }
            else
            {

            }
           
        }

        //resize image 
        private void CompressImage()
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            using (Bitmap bmp1 = new Bitmap(@location))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.  
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 30L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(@"C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Image/image.jpeg", jpgEncoder, myEncoderParameters);
            }
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
