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
    public partial class picPreview : Form
    {
        public picPreview()
        {
            InitializeComponent();
        }

        private void picPreview_Load(object sender, EventArgs e)
        {
           
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from users where username = '" + login.txt.Text + "'";
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
