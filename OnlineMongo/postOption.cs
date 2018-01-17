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
    public partial class postOption : Form
    {
        public postOption()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            dashBoard.iCheck = false;
            this.Hide();
            //view the picture
            pictureView picv = new pictureView();
            picv.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            postb.postCheck = true;
            dashBoard.emailCheck = true;
        }
        //function for downloading the image
        private void Download()
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
               
                ad = new MySqlDataAdapter(com);
               
                DataTable table = new DataTable();
                ad.Fill(table);
                try
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
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            Download();
            this.Hide();
            postb.postCheck = true;
        }
    }
}
