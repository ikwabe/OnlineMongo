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
                }

               

                MemoryStream mstream = new MemoryStream();
                try
                {
                    pictureBox1.Image.Save(mstream, ImageFormat.Jpeg);
                }
                catch
                {

                }
                byte[] arrImg = mstream.GetBuffer();
                mstream.Close();



                MySqlCommand com = new MySqlCommand(pic, con);


                con.Open();
                com.Parameters.AddWithValue("@prfpic", arrImg);
                com.ExecuteNonQuery();
                
             
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
            profile();
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
            profile();
        }
    }
}
