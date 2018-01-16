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
using System.Drawing.Imaging;

namespace OnlineMongo
{
    public partial class photoPost : Form
    {
        public photoPost()
        {
            InitializeComponent();
        }
        string computerUserName = Environment.UserName;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            postb.chek = true;
            this.Close();
        }
        string location;
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            panelCont();
            openFileDialog1.Filter = "(*.JPG; *.PNG) | *.JPG; *.PNG ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                timer1.Start();
                location = openFileDialog1.FileName;
                CompressImage();

            }
            else
            {
                MessageBox.Show("No photo Uploaded");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            animator.ShowSync(panel1);
        }

        //hidding panel and clear text function
        private void panelCont()
        {
            panel1.Visible = false;
            photoSttsTxt.Text = null;
            pictureBox1.Image = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panelCont();
        }

        //the function to add a post
        private void addPostToDb()
        {
            DateTime pst_date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string userId = "select fname,lname from users where user_id = '" + login.user_id + "'";



            try
            {
                con.Open();
               
                        byte[] images = null;
                        FileStream stream = new FileStream("C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Image/image.Jpeg", FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);   
                MySqlDataReader reader;

                //taking user id from the database
                MySqlCommand com1 = new MySqlCommand(userId, con);
                DataTable table = new DataTable();
                reader = com1.ExecuteReader();
                table.Load(reader);
                reader.Close();       
                string fullname = table.Rows[0][0].ToString() + " " + table.Rows[0][1].ToString();
             
                        //string to insert data
                        string pic = "insert into post(image,status,user_id,pst_date,fullname,chek) values(@image,'" + photoSttsTxt.Text + "','" + login.user_id + "','" + pst_date.ToShortDateString() + "', '"+ fullname +"','New')";

                        //command to insert photos
                        MySqlCommand com = new MySqlCommand(pic, con);
                        com.Parameters.Add(new MySqlParameter("@image", images));
                        com.ExecuteNonQuery();  
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (photoSttsTxt.Text == "")
            {
                if(pictureBox1.Image == null)
                {
                    MessageBox.Show("Nothing To Post, Please Upload Photo");
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to post this photo without status","POST ALERT!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        addPostToDb();
                        panelCont();
                        postb.postCheck = true;
                        MessageBox.Show("Posted");
                       

                    }
                    else
                    {

                    }

                }
               
            }
            else
            {
                addPostToDb();
                panelCont();
                postb.postCheck = true;
                MessageBox.Show("Posted");
                

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
