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
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//function to load user profile details
        private void profile()
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
        private void userInfo_Load(object sender, EventArgs e)
        {
            profile();
        }
    }
}
