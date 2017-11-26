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
using Bunifu.Framework.UI;
using WindowsFormsControlLibrary1;

namespace OnlineMongo
{
    public partial class postb : UserControl
    {
        public static postb _instance;
        public static postb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new postb();
                return _instance;
            }

        }
        public postb()
        {
            InitializeComponent();
        }

      
        Label lb;
       
        int i = 0;
        int k = 0;
        private void photo_Click(object sender, EventArgs e)
        {
            line.Visible = true;
            line.Width = photo.Width;
            line.Left = photo.Left;

            //load photo upload form
            photoPost phP = new photoPost();
            phP.Show();

        }

        private void postb_Load(object sender, EventArgs e)
        {
            postTimer.Start();
        }

        //function for retreaving posts from post table
        private void loadPost()
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
           // string user_idc = table.Rows[0][0].ToString();
            string fullname = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
            ad.Dispose();

           // int user_id = int.Parse(user_idc);

            //reading data query
            string readImage = "select * from post";

            MySqlCommand com = new MySqlCommand(readImage, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);



            for (int j = 0; j < table1.Rows.Count; j++)
            {
                i++;
                //Image
                PictureBox phot = new PictureBox();
                phot.Width = 300;
                phot.Height = 172;
                phot.Name = "pic" + i;
                phot.SizeMode = PictureBoxSizeMode.Zoom;
                phot.Cursor = Cursors.Hand;

                //takking photo to the panel
                try
                {
                    byte[] img = (byte[])table1.Rows[j][1];
                    MemoryStream ms = new MemoryStream(img);
                    phot.Image = Image.FromStream(ms);


                }
                catch
                {

                }

                //Label
                lb = new Label();
                lb.Name = "lable" + k;
                lb.AutoSize = true;
                lb.Font = new Font("Cambria", 16);
                try
                {
                    lb.Text = table1.Rows[j][2].ToString();

                }
                catch
                {

                }
                //User Full name

                Label uname = new Label();
                uname = new Label();
                uname.Name = "lable" + k;
                uname.AutoSize = true;
                uname.Font = new Font("Cambria", 14);
                uname.Text = "Posted by: " + fullname;
                //Button
                BunifuFlatButton bt = new BunifuFlatButton();
                bt.Name = "Btn" + i;
                bt.Text = "Comment";
                bt.Height = 40;
                bt.Width = 300;
                bt.Normalcolor = Color.FromArgb(0, 122, 204);
                bt.OnHovercolor = Color.FromArgb(32, 9, 191);
                bt.Activecolor = Color.FromArgb(0, 122, 204);
                bt.Iconimage = null;
                bt.TextAlign = ContentAlignment.MiddleCenter;
                bt.BorderRadius = 5;

                //TextBox
                BunifuCustomTextbox txt = new BunifuCustomTextbox();
                txt.Name = "TextBox" + i;
                txt.Width = 300;
                txt.Height = 30;
                txt.Multiline = true;
                txt.Font = new Font("Cambria", 14);
                txt.BackColor = Color.FromArgb(240,240,240);
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.ForeColor = Color.Black;
                txt.BorderColor = Color.FromArgb(32,9,191);

                //adding user name to the panel
                flowLayoutPanel1.Controls.Add(uname);

                //takking lable to the panel
                flowLayoutPanel1.Controls.Add(lb);

                //taking photo to panel
                flowLayoutPanel1.Controls.Add(phot);

                //adding Textbox
                flowLayoutPanel1.Controls.Add(txt);

                //adding button to the panel
                flowLayoutPanel1.Controls.Add(bt);
            }

            ad.Dispose();
           

        }

        private void postTimer_Tick(object sender, EventArgs e)
        {

            loadPost();
            postTimer.Stop();
        }
    }
}
