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
            friendTimer.Start();
            instPostTimer.Start();
        }

        int[] ReqUser_id;

        //the function to retrieve user acounts from the databases
        private void showFriend()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            //reading data query
            string readAccount = "select * from users where username <> '"+ login.txt.Text +"'";

            //string to read userID from request table
            string checkReq = "select * from requests";

            //for request user_id fetch
            MySqlCommand com1 = new MySqlCommand(checkReq, con);
            ad = new MySqlDataAdapter(com1);
            DataTable table = new DataTable();
            ad.Fill(table);
            ReqUser_id = new int[table.Rows.Count];
            for(int i =0; i< table.Rows.Count; i++)
            {
                ReqUser_id[i] = (int)table.Rows[i][1];
            }
            ad.Dispose();

            //for users 
            MySqlCommand com = new MySqlCommand(readAccount, con);
           
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);

            i = 0;

            for (int j = 0; j < table1.Rows.Count; j++)
            {

                
                string user_id = table1.Rows[j][0].ToString();
try
                {
                    //reseting if the bound exeeds
                    if (i > (table.Rows.Count - 1))
                    {
                        i = table.Rows.Count - 1;

                    }
                    else
                    {

                    }
                    //checking if the request is available
                    if (ReqUser_id[i] != int.Parse(user_id))
                    {
                        //Image
                        PictureBox phot = new PictureBox();
                        phot.Width = 120;
                        phot.Height = 95;
                        phot.Name = user_id;
                        phot.SizeMode = PictureBoxSizeMode.Zoom;
                        phot.Cursor = Cursors.Hand;

                        //takking photo to the panel
                        try
                        {
                            byte[] img = (byte[])table1.Rows[j][7];
                            MemoryStream ms = new MemoryStream(img);
                            phot.Image = Image.FromStream(ms);


                        }
                        catch
                        {

                        }

                        //User Full name
                        string fullname = table1.Rows[j][1].ToString() + " " + table1.Rows[j][2].ToString();
                        Label uname = new Label();
                        uname = new Label();
                        uname.Name = "lable" + k;
                        uname.AutoSize = true;
                        uname.ForeColor = Color.DarkGreen;
                        uname.Font = new Font("Cambria", 11, FontStyle.Bold);
                        uname.Text = fullname;

                        //Button
                        BunifuFlatButton bt = new BunifuFlatButton();
                        bt.Name = user_id;
                        bt.Text = "Add Friend";
                        bt.Height = 30;
                        bt.Width = 120;
                        bt.Normalcolor = Color.FromArgb(0, 122, 204);
                        bt.OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt.Activecolor = Color.FromArgb(0, 122, 204);
                        bt.Iconimage = null;
                        bt.TextAlign = ContentAlignment.MiddleCenter;
                        bt.BorderRadius = 5;
                        bt.Click += new EventHandler(addFriendBtn_Click);

                        //taking photo to panel
                        flowLayoutPanel2.Controls.Add(phot);

                        //adding user name to the panel
                        flowLayoutPanel2.Controls.Add(uname);

                        //adding button to the panel
                        flowLayoutPanel2.Controls.Add(bt);


                    }
                    else
                    {

                    }
                    i++;
                }
                catch
                {

                }
               
            }

            ad.Dispose();

        }
        BunifuFlatButton[] bt;
        PictureBox[] phot;
        string [] btnName;
        int count;

        //add posted post at instant
        private void instLoadPost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            //query to check if the post is added at instant
            string readpost = "SELECT * FROM post order by post_id DESC LIMIT 1";

            MySqlCommand com = new MySqlCommand(readpost, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);

            bt = new BunifuFlatButton[table1.Rows.Count];
            phot = new PictureBox[table1.Rows.Count];
            btnName = new string[table1.Rows.Count];
            for (int j = 0; j < table1.Rows.Count; j++)
            {

                i++;
                string post_id = table1.Rows[j][0].ToString();
                //Image
                phot[j] = new PictureBox();
                phot[j].Width = 300;
                phot[j].Height = 172;
                phot[j].Name = post_id;
                phot[j].SizeMode = PictureBoxSizeMode.Zoom;
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
                string fullname = table1.Rows[j][5].ToString();
                Label uname = new Label();
                uname = new Label();
                uname.Name = "lable" + k.ToString();
                uname.AutoSize = true;
                uname.ForeColor = Color.DarkGreen;
                uname.Font = new Font("Cambria", 14);
                uname.Text = "Posted by: " + fullname;
                //Button

                bt[j] = new BunifuFlatButton();
                bt[j].Text = "Comment";
                bt[j].Name = post_id;
                bt[j].Height = 40;
                bt[j].Width = 300;
                bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                bt[j].OnHovercolor = Color.FromArgb(32, 9, 191);
                bt[j].Activecolor = Color.FromArgb(0, 122, 204);
                bt[j].Iconimage = null;
                bt[j].TextAlign = ContentAlignment.MiddleCenter;
                bt[j].BorderRadius = 5;
                bt[j].Click += new EventHandler(commentPostBtn_Click);

                //TextBox
                BunifuCustomTextbox txt = new BunifuCustomTextbox();
                txt.Name = "TextBox" + i;
                txt.Width = 300;
                txt.Height = 30;
                txt.Multiline = true;
                txt.Font = new Font("Cambria", 14);
                txt.BackColor = Color.FromArgb(240, 240, 240);
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.ForeColor = Color.Black;
                txt.BorderColor = Color.FromArgb(32, 9, 191);
                txt.TextChanged += new EventHandler(txt_TextChanged);

                //adding button to the panel
                flowLayoutPanel1.Controls.Add(bt[j]);

                //adding Textbox
                flowLayoutPanel1.Controls.Add(txt);

                //taking photo to panel
                flowLayoutPanel1.Controls.Add(phot[j]);

                //taking lable to the panel
                flowLayoutPanel1.Controls.Add(lb);

                //adding user name to the panel
                flowLayoutPanel1.Controls.Add(uname);

            }
            ad.Dispose();


        }
        //function for retreaving posts from post table
        private void loadPost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            //reading data query
            string readImage = "select * from post";

            MySqlCommand com = new MySqlCommand(readImage, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);



            bt = new BunifuFlatButton[table1.Rows.Count];
            phot = new PictureBox[table1.Rows.Count];
            btnName = new string[table1.Rows.Count];
            count = table1.Rows.Count;
            for (int j = 0; j < table1.Rows.Count; j++)
            {
               
                i++;
                string post_id = table1.Rows[j][0].ToString();
                //Image
                phot[j] = new PictureBox();
                phot[j].Width = 300;
                phot[j].Height = 172;
                phot[j].Name = post_id;
                phot[j].SizeMode = PictureBoxSizeMode.Zoom;
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
              string  fullname = table1.Rows[j][5].ToString();
                Label uname = new Label();
                uname = new Label();
                uname.Name = "lable" + k.ToString();
                uname.AutoSize = true;
                uname.ForeColor = Color.DarkGreen;
                uname.Font = new Font("Cambria", 14);
                uname.Text = "Posted by: " + fullname;
                //Button

                bt[j] = new BunifuFlatButton();
                bt[j].Text =  "Comment";
                bt[j].Name = post_id;
                bt[j].Height = 40;
                bt[j].Width = 300;
                bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                bt[j].OnHovercolor = Color.FromArgb(32, 9, 191);
                bt[j].Activecolor = Color.FromArgb(0, 122, 204);
                bt[j].Iconimage = null;
                bt[j].TextAlign = ContentAlignment.MiddleCenter;
                bt[j].BorderRadius = 5;
                bt[j].Click += new EventHandler(commentPostBtn_Click);

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
                txt.TextChanged += new EventHandler(txt_TextChanged);

                //adding button to the panel
                flowLayoutPanel1.Controls.Add(bt[j]);

                //adding Textbox
                flowLayoutPanel1.Controls.Add(txt);

                //taking photo to panel
                flowLayoutPanel1.Controls.Add(phot[j]);

                //taking lable to the panel
                flowLayoutPanel1.Controls.Add(lb);

                //adding user name to the panel
                flowLayoutPanel1.Controls.Add(uname);
               
            }

            ad.Dispose();
           

        }

        private void postTimer_Tick(object sender, EventArgs e)
        {

            loadPost();
            postTimer.Stop();
        }

        private void friendTimer_Tick(object sender, EventArgs e)
        {
            
            showFriend();
            friendTimer.Stop();
            
        }

        //function for add friend button 
        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MessageBox.Show(button.Name);
        }

        string comment;
        private void txt_TextChanged(object sender, EventArgs e)
        {

            var txt = sender as BunifuCustomTextbox;
            comment = txt.Text;



        }
       
        //function for commenting the posts
        private void commentPostBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            //reading data query
            string userId = "select * from users where username = '" + login.txt.Text + "'";
            try
            {
                con.Open();
                MySqlCommand com = new MySqlCommand(userId, con);
                ad = new MySqlDataAdapter(com);
                DataTable table1 = new DataTable();
                ad.Fill(table1);

                int user_id = (int)table1.Rows[0][0];
                DateTime com_date = DateTime.Now;

                string insertComment = "insert into comments(post_id,comment,date,user_id) values('" + int.Parse(button.Name) +"','"+ comment +"','"+ com_date +"','"+ user_id +"')";
                MySqlCommand com1 = new MySqlCommand(insertComment, con);
                MySqlDataReader rd;
                if(comment != "" && comment != null)
                {
                    rd = com1.ExecuteReader();
                    rd.Close();
                    comment = null;
                }
                else
                {
                    MessageBox.Show("No Comment to Post");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //the strig to hold the pic name for retrieving it from the database
        public static string photName;

        //function for handling picture click
        private void photoClickBtn_Click(object sender, EventArgs e)
        {
            var picName = sender as PictureBox;

            //taking the clicked PictureName to the static string
            photName = picName.Name;

            pictureView picv = new pictureView();
            picv.Show();


        }

        //refresh function
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            postTimer.Start();
        }


        //timer for instant post
        private void instPostTimer_Tick(object sender, EventArgs e)
        {
            int check;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            //reading data query
            string readpost = "select * from post";
            try
            {
                MySqlCommand com = new MySqlCommand(readpost, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
                check = table1.Rows.Count;

                //check if there is an update of post
                if(check > count)
                {
                    instLoadPost();
                    count = table1.Rows.Count;
                }
                else
                {

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
