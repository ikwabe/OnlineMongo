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
    public partial class imageOption : Form
    {
        public imageOption()
        {
            InitializeComponent();
        }

        private void imageOption_Load(object sender, EventArgs e)
        {
           
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
        private void openBtn_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            //view the picture
            pictureView picv = new pictureView();
            picv.Show(); 
        }

        //a function to delete images from the database
        private void picDelete()
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string delete = "delete from images where img_id = '" + pic.photName + "'";
            MySqlCommand com = new MySqlCommand(delete, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                //deleting the image
                rd = com.ExecuteReader();
                rd.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            if(pic.chek == true && (MessageBox.Show("Are you sure you want to delete this image?","Delete Alert",MessageBoxButtons.YesNo)== DialogResult.Yes))
            {
                //deleting the photo from the database
                picDelete();
                pic.picCheck = true;
                this.Hide();
            }
            else
            {

            }
           


        }
    }
}
