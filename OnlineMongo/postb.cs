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
        int dbCount;
        FlowLayoutPanel [] comPanel;
        public static bool postCheck = false;
        BunifuCustomTextbox txt;
        private void photo_Click(object sender, EventArgs e)
        {
            postb.chek = false;
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
            postCheck = true;
            friendTimer.Start();
            instPostTimer.Start();
        }

        int[] ReqUser_id;

        //the function to retrieve user acounts from the databases
        private void showFriend()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            //reading data query
            string readAccount = "select * from users where user_id <> '"+ login.user_id +"'";

           

            //string to read userID from request table
            string checkReq = "select * from requests where sender_id = '"+ login.user_id +"'";
            con.Open();
            //for request user_id fetch
            MySqlCommand com1 = new MySqlCommand(checkReq, con);
            ad = new MySqlDataAdapter(com1);
            DataTable table = new DataTable();
            ad.Fill(table);

            //execute ones to check if the database is empty or not
            object nullValue = com1.ExecuteScalar();
            

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

                //if the database return null value
                if(nullValue == null || nullValue == DBNull.Value)
                {
                    //Image
                    PictureBox phot = new PictureBox();
                    phot.Width = 120;
                    phot.Height = 95;
                    phot.Name = user_id;
                    phot.SizeMode = PictureBoxSizeMode.Zoom;
                    phot.Cursor = Cursors.Hand;
                    phot.Click += new EventHandler(ProfilePhoto_Click);
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
                    uname.Name = table1.Rows[j][0].ToString();
                    uname.AutoSize = true;
                    uname.ForeColor = Color.DarkGreen;
                    uname.Cursor = Cursors.Hand;
                    uname.Font = new Font("Cambria", 11, FontStyle.Bold);
                    uname.Click += new EventHandler(uname_Click);
                    uname.Text = fullname;

                    //Button
                    BunifuFlatButton bt = new BunifuFlatButton();
                    bt.Name = user_id;
                    bt.Text = "Follow";
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
                //if the database doesnt return null value
                else
                {

                        try
                        {
                            //reseting if the requests index bound exeeds
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
                            phot.Click += new EventHandler(ProfilePhoto_Click);
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
                            uname.Name = table1.Rows[j][0].ToString();
                            uname.AutoSize = true;
                            uname.ForeColor = Color.DarkGreen;
                            uname.Cursor = Cursors.Hand;
                            uname.Font = new Font("Cambria", 11, FontStyle.Bold);
                            uname.Click += new EventHandler(uname_Click);
                            uname.Text = fullname;

                            //Button
                            BunifuFlatButton bt = new BunifuFlatButton();
                                bt.Name = user_id;
                                bt.Text = "Follow";
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
               
            }

            ad.Dispose();
            con.Close();
        }

        //function to clear the panel for add friend request
        private void friendRequest()
        {
           
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            //reading data query
            string readAccount = "select * from users where user_id <> '" + login.user_id + "'";

            //string to read userID from request table
            string checkReq = "select * from requests where sender_id = '" + login.user_id + "'";
            con.Open();
            //for request user_id fetch
            MySqlCommand com1 = new MySqlCommand(checkReq, con);
            ad = new MySqlDataAdapter(com1);
            DataTable table = new DataTable();
            ad.Fill(table);

            //execute ones to check if the database is empty or not
            object nullValue = com1.ExecuteScalar();


            ReqUser_id = new int[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
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
                //reseting if the requests index bound exeeds
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
                    phot.Click += new EventHandler(ProfilePhoto_Click);
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
                    uname.Name = table1.Rows[j][0].ToString();
                    uname.AutoSize = true;
                    uname.ForeColor = Color.DarkGreen;
                    uname.Cursor = Cursors.Hand;
                    uname.Font = new Font("Cambria", 11, FontStyle.Bold);
                    uname.Click += new EventHandler(uname_Click);
                    uname.Text = fullname;

                    //Button
                    BunifuFlatButton bt = new BunifuFlatButton();
                    bt.Name = user_id;
                    bt.Text = "Follow";
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

    }



        BunifuFlatButton[] bt;
        PictureBox[] phot;
        string [] btnName;
        int count;

        //boolean for activating the instant post
       
        //add posted post at instant
        private void instLoadPost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            //query to check if the post is added at instant
            string readpost = "SELECT * FROM  post where chek = 'New' order by post_id DESC LIMIT 1";

            MySqlCommand com = new MySqlCommand(readpost, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
            ad.Dispose();

            bt = new BunifuFlatButton[table1.Rows.Count];
            phot = new PictureBox[table1.Rows.Count];
            btnName = new string[table1.Rows.Count];
            try
            {
                con.Open();
                if (table1.Rows.Count > 0)
                {
                    
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
                        uname.Name = table1.Rows[j][3].ToString();
                        uname.AutoSize = true;
                        uname.ForeColor = Color.DarkGreen;
                        uname.Font = new Font("Cambria", 14);
                        uname.Cursor = Cursors.Hand;
                        uname.Text = "Posted by: " + fullname;
                        uname.Click += new EventHandler(uname_Click);
                        //Button

                        bt[j] = new BunifuFlatButton();
                        bt[j].Text = "Comment";
                        bt[j].Name = post_id;
                        bt[j].Height = 25;
                        bt[j].Width = 100;
                        bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                        bt[j].OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt[j].Activecolor = Color.FromArgb(0, 122, 204);
                        bt[j].Iconimage = null;
                        bt[j].TextAlign = ContentAlignment.MiddleCenter;
                        bt[j].BorderRadius = 5;
                        bt[j].Click += new EventHandler(commentPostBtn_Click);

                        //TextBox
                        txt = new BunifuCustomTextbox();
                        txt.Name = post_id;
                        txt.Width = 300;
                        txt.Height = 25;
                        txt.Multiline = true;
                        txt.Font = new Font("Cambria", 11);
                        txt.BackColor = Color.FromArgb(240, 240, 240);
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.ForeColor = Color.Black;
                        txt.BorderColor = Color.FromArgb(32, 9, 191);
                        txt.TextChanged += new EventHandler(txt_TextChanged);

                        //a panel for photo
                        FlowLayoutPanel photoPanel = new FlowLayoutPanel();

                        photoPanel.AutoSize = true;
                        photoPanel.Controls.Add(phot[j]);

                        ////a panel forcomments
                        comPanel[j] = new FlowLayoutPanel();
                        comPanel[j].AutoSize = true;
                        comPanel[j].Name = post_id;
                        comPanel[j].BackColor = Color.LightGray;
                        comPanel[j].FlowDirection = FlowDirection.TopDown;

                        //a panel for comment and button
                        FlowLayoutPanel commentPanel = new FlowLayoutPanel();
                        commentPanel.AutoSize = true;
                        commentPanel.FlowDirection = FlowDirection.LeftToRight;
                        commentPanel.WrapContents = false;
                        commentPanel.Controls.Add(txt);
                        commentPanel.Controls.Add(bt[j]);

                        //a panel for caption
                        FlowLayoutPanel captionPanel = new FlowLayoutPanel();
                        captionPanel.AutoSize = true;

                        captionPanel.Controls.Add(lb);

                        //a panel for caption
                        FlowLayoutPanel unamePanel = new FlowLayoutPanel();
                        unamePanel.AutoSize = true;

                        unamePanel.Controls.Add(uname);

                        ////adding comment and button to the panel
                        flowLayoutPanel1.Controls.Add(commentPanel);

                        //taking comments to panel
                        flowLayoutPanel1.Controls.Add(comPanel[j]);

                        ////taking photo to panel
                        flowLayoutPanel1.Controls.Add(photoPanel);

                        ////taking lable to the panel
                        flowLayoutPanel1.Controls.Add(captionPanel);

                        //adding user name to the panel
                        flowLayoutPanel1.Controls.Add(unamePanel);


                        //update the poast
                        string update = "update post set chek = 'Posted' where post_id = '" + post_id + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);
                        MySqlDataReader rd;

                        rd = com1.ExecuteReader();
                        rd.Close();

                    }
                   
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();





        }
        //function for retreaving posts from post table
        private void loadPost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            //reading data query
            string readImage = "select * from post";

            //read the comments 
            string loadcomments = "select post_id,comment,user_name,user_id from comments";
            MySqlCommand com1 = new MySqlCommand(loadcomments, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;
            try
            {
                con.Open();
                //taking the comments
                rd = com1.ExecuteReader();
                table.Load(rd);
                rd.Close();

                MySqlCommand com = new MySqlCommand(readImage, con);
                ad = new MySqlDataAdapter(com);
                DataTable table1 = new DataTable();
                ad.Fill(table1);



                bt = new BunifuFlatButton[table1.Rows.Count];
                phot = new PictureBox[table1.Rows.Count];
                btnName = new string[table1.Rows.Count];
                comPanel = new FlowLayoutPanel[table1.Rows.Count];
                count = table1.Rows.Count;
                dbCount = table1.Rows.Count;
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
                    uname.Name = table1.Rows[j][3].ToString();
                    uname.AutoSize = true;
                    uname.ForeColor = Color.DarkGreen;
                    uname.Cursor = Cursors.Hand;
                    uname.Font = new Font("Cambria", 14);
                    uname.Text = "Posted by: " + fullname;
                    uname.Click += new EventHandler(uname_Click);
                    //Button

                    bt[j] = new BunifuFlatButton();
                    bt[j].Text = "Comment";
                    bt[j].Name = post_id;
                    bt[j].Height = 25;
                    bt[j].Width = 100;
                    bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                    bt[j].OnHovercolor = Color.FromArgb(32, 9, 191);
                    bt[j].Activecolor = Color.FromArgb(0, 122, 204);
                    bt[j].Iconimage = null;
                    bt[j].TextAlign = ContentAlignment.MiddleCenter;
                    bt[j].BorderRadius = 5;
                    bt[j].Click += new EventHandler(commentPostBtn_Click);

                    //TextBox
                    txt = new BunifuCustomTextbox();
                    txt.Name = post_id;
                    txt.Width = 300;
                    txt.Height = 25;
                    txt.Multiline = true;
                    txt.Font = new Font("Cambria", 11);
                    txt.BackColor = Color.FromArgb(240, 240, 240);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.ForeColor = Color.Black;
                    txt.BorderColor = Color.FromArgb(32, 9, 191);
                    txt.TextChanged += new EventHandler(txt_TextChanged);

                    //a panel for photo
                    FlowLayoutPanel photoPanel = new FlowLayoutPanel();

                    photoPanel.AutoSize = true;
                    photoPanel.Controls.Add(phot[j]);

                    ////a panel forcomments
                    comPanel[j] = new FlowLayoutPanel();
                    comPanel[j].AutoSize = true;
                    comPanel[j].Name = post_id;
                    comPanel[j].BackColor = Color.LightGray;
                    comPanel[j].FlowDirection = FlowDirection.TopDown;
                    //adding data to comment panel

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (comPanel[j].Name == table.Rows[i][0].ToString())
                        {
                            //label
                            Label coomm = new Label();
                            coomm.Font = new Font("Sitka Small", 11, FontStyle.Bold);
                            coomm.ForeColor = Color.FromArgb(30, 0, 40);
                            coomm.Text = ": " + table.Rows[i][1].ToString();
                            coomm.AutoSize = true;

                            //LinkLable for username
                            LinkLabel userbt = new LinkLabel();
                           userbt.Text = table.Rows[i][2].ToString();
                           userbt.Name = table.Rows[i][3].ToString();
                            userbt.ActiveLinkColor = Color.Gray;
                           userbt.LinkColor = Color.Gray;
                           userbt.AutoSize = true;
                            userbt.LinkBehavior = LinkBehavior.NeverUnderline;
                            userbt.Cursor = Cursors.Hand;
                            userbt.BackColor = Color.Transparent;
                           userbt.Font = new Font("Lucida Fax", 9, FontStyle.Bold);
                           userbt.TextAlign = ContentAlignment.MiddleLeft;
                           userbt.Click += new EventHandler(buttonBtn_Click);

                            //flowlayout to add comment and name 
                            FlowLayoutPanel content = new FlowLayoutPanel();
                            content.FlowDirection = FlowDirection.LeftToRight;
                            content.WrapContents = false;
                            content.AutoSize = true;

                            //ading the comment to the panel
                            content.Controls.Add(userbt);
                            content.Controls.Add(coomm);

                            //adding the panel to the main panel
                            comPanel[j].AutoSize = true;
                            comPanel[j].Controls.Add(content);
                        }
                        else
                        {

                        }

                    }

                    //a panel for comment text and button
                    FlowLayoutPanel commentPanel = new FlowLayoutPanel();
                    commentPanel.AutoSize = true;
                    commentPanel.FlowDirection = FlowDirection.LeftToRight;
                    commentPanel.WrapContents = false;
                    commentPanel.Controls.Add(txt);
                    commentPanel.Controls.Add(bt[j]);

                    //a panel for caption
                    FlowLayoutPanel captionPanel = new FlowLayoutPanel();
                    captionPanel.AutoSize = true;

                    captionPanel.Controls.Add(lb);

                    //a panel for caption
                    FlowLayoutPanel unamePanel = new FlowLayoutPanel();
                    unamePanel.AutoSize = true;

                    unamePanel.Controls.Add(uname);

                    ////adding comment and button to the panel
                    flowLayoutPanel1.Controls.Add(commentPanel);

                    //taking comments to panel
                    flowLayoutPanel1.Controls.Add(comPanel[j]);

                    ////taking photo to panel
                    flowLayoutPanel1.Controls.Add(photoPanel);

                    ////taking lable to the panel
                    flowLayoutPanel1.Controls.Add(captionPanel);

                    //adding user name to the panel
                    flowLayoutPanel1.Controls.Add(unamePanel);

                }

                ad.Dispose();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           

        }

        private void friendTimer_Tick(object sender, EventArgs e)
        {
            
            flowLayoutPanel2.Controls.Clear();
            showFriend();
            friendTimer.Stop();

        }

        //function for add friend button 
        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            try
            {
                con.Open();
                //a variable to handle button clik
                var button = sender as BunifuFlatButton;

                //string to insert data to the request table
                string sendReq = "insert into requests(user_id,date,sender_id,sender_full_name) values ('" + button.Name + "', '" + date + "','" + login.user_id + "','"+ login.fullname +"')";

                //a string to check if the request is already in the table

                string reqCheck = "select * from requests where user_id = '" + button.Name + "' and sender_id = '" + login.user_id + "'";
                MySqlDataReader rd;
                //command to insert requests table
                MySqlCommand com = new MySqlCommand(sendReq, con);
                //command to check if the request is alread made
                MySqlCommand com2 = new MySqlCommand(reqCheck, con);
                DataTable table1 = new DataTable();

                //check the request if is pressent
                rd = com2.ExecuteReader();
                table1.Load(rd);
                rd.Close();

                if(table1.Rows.Count == 0)
                {
                    //request sent
                    rd = com.ExecuteReader();
                    rd.Close();

                    //removing the requested user
                    friendRequestTimer.Start();
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

        string comment;
        string txtName;
        private void txt_TextChanged(object sender, EventArgs e)
        {

            var txt = sender as BunifuCustomTextbox;
            txtName = txt.Name;
            comment = txt.Text;



        }
       

        //function for commenting the posts
        private void commentPostBtn_Click(object sender, EventArgs e)
        {
            dashBoard.iCheck = false;
            var button = sender as BunifuFlatButton;
            postb.chek = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            


            try
            {
                con.Open();
                DateTime com_date = DateTime.Now;

                string insertComment = "insert into comments(post_id,comment,date,user_id,user_name,status) values('" + int.Parse(button.Name) + "','" + comment + "','" + com_date + "','" + login.user_id + "','" + login.fullname + "','New')";
                MySqlCommand com1 = new MySqlCommand(insertComment, con);
                MySqlDataReader rd;
                if (comment != "" && comment != null && button.Name == txtName)
                {
                    rd = com1.ExecuteReader();
                    rd.Close();
                    //inserting comment in the panel
                    for (int j = 0; j < dbCount; j++)
                    {
                        if (comPanel[j].Name == button.Name)
                        {
                            //label
                            Label coomm = new Label();
                            coomm.Font = new Font("Sitka Small", 11, FontStyle.Bold);
                            coomm.ForeColor = Color.FromArgb(30, 0, 40);
                            coomm.Text = ": " + comment;
                            coomm.AutoSize = true;

                            //button for username
                            LinkLabel userbt = new LinkLabel();
                            userbt.Text = login.fullname;
                            userbt.Name = login.user_id;
                            userbt.ActiveLinkColor = Color.Gray;
                            userbt.LinkColor = Color.Gray;
                            userbt.AutoSize = true;
                            userbt.LinkBehavior = LinkBehavior.NeverUnderline;
                            userbt.Cursor = Cursors.Hand;
                            userbt.BackColor = Color.Transparent;
                            userbt.Font = new Font("Lucida Fax", 9, FontStyle.Bold);
                            userbt.TextAlign = ContentAlignment.MiddleLeft;
                            userbt.Click += new EventHandler(buttonBtn_Click);

                            //flowlayout to add comment and name 
                            FlowLayoutPanel content = new FlowLayoutPanel();
                            content.FlowDirection = FlowDirection.LeftToRight;
                            content.WrapContents = false;
                            content.AutoSize = true;

                            //ading the comment to the panel
                            content.Controls.Add(userbt);
                            content.Controls.Add(coomm);

                            //adding the panel to the main panel
                            comPanel[j].AutoSize = true;
                            comPanel[j].Controls.Add(content);

                        }
                        else
                        {

                        }

                    }

                    comment = null;
                    postb.chek = true;
                    txt.Text = null;
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

        public static bool chek = false;
        //function for handling picture click
        private void photoClickBtn_Click(object sender, EventArgs e)
        {

            dashBoard.emailCheck = false;
            var picName = sender as PictureBox;

            //taking the clicked PictureName to the static string
            photName = picName.Name;
            chek = true;
            pic.chek = true;
            myProfile.chek = false;
            postOption picv = new postOption();
            picv.Show();

            
        }

        //a function for button click
        private void buttonBtn_Click(object sender, EventArgs e)
        {
            var button = sender as LinkLabel;
            dashBoard.iCheck = false;
            dashBoard.emailCheck = false;
            user_id = int.Parse(button.Name);
            profile = true;
            friendtb.profile = false;
            userInfo uInf = new userInfo();
            uInf.Show();

        }
        //refresh function
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            instLoadPost();
        }

        //a function to check if the comment added
        private void chekComment()
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            //read the comments 
            string loadcomments = "select post_id,comment,user_name,user_id,comment_id from comments where status = 'New'";
            string countPost = "select post_id from post";
            MySqlCommand com1 = new MySqlCommand(loadcomments, con);
            MySqlCommand com = new MySqlCommand(countPost, con);
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            MySqlDataReader rd;
            try
            {
                con.Open();
                //taking the comments
                rd = com1.ExecuteReader();
                table.Load(rd);
                rd.Close();

                //counting the post
                rd = com.ExecuteReader();
                table1.Load(rd);
                rd.Close();
                

                comPanel = new FlowLayoutPanel[table1.Rows.Count];
                //adding data to comment panel
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                    comPanel[j] = new FlowLayoutPanel();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (comPanel[j].Name == table.Rows[i][0].ToString() && table.Rows[i][4].ToString() == "New")
                        {
                            //label
                            Label coomm = new Label();
                            coomm.Font = new Font("Sitka Small", 11, FontStyle.Bold);
                            coomm.ForeColor = Color.FromArgb(30, 0, 40);
                            coomm.Text = ": " + table.Rows[i][1].ToString();
                            coomm.AutoSize = true;

                            //LinkLable for username
                            LinkLabel userbt = new LinkLabel();
                            userbt.Text = table.Rows[i][2].ToString();
                            userbt.Name = table.Rows[i][3].ToString();
                            userbt.ActiveLinkColor = Color.Gray;
                            userbt.LinkColor = Color.Gray;
                            userbt.AutoSize = true;
                            userbt.LinkBehavior = LinkBehavior.NeverUnderline;
                            userbt.Cursor = Cursors.Hand;
                            userbt.BackColor = Color.Transparent;
                            userbt.Font = new Font("Lucida Fax", 9, FontStyle.Bold);
                            userbt.TextAlign = ContentAlignment.MiddleLeft;
                            userbt.Click += new EventHandler(buttonBtn_Click);

                            //flowlayout to add comment and name 
                            FlowLayoutPanel content = new FlowLayoutPanel();
                            content.FlowDirection = FlowDirection.LeftToRight;
                            content.WrapContents = false;
                            content.AutoSize = true;

                            //ading the comment to the panel
                            content.Controls.Add(userbt);
                            content.Controls.Add(coomm);

                            //adding the panel to the main panel
                            comPanel[j].AutoSize = true;
                            comPanel[j].Controls.Add(content);

                            string update = "update comments set status = 'Posted' where comment_id = '" + table.Rows[i][4] + "'";
                            MySqlCommand com3 = new MySqlCommand(update, con);

                            rd = com3.ExecuteReader();
                            rd.Close();
                        }
                        else
                        {

                        }

                    }
                }

            }
            catch (MySqlException ex)
            {
               
                    MessageBox.Show(ex.Message);
                
            }

        }


        //timer for instant post
        private void instPostTimer_Tick(object sender, EventArgs e)
        {
            if(postCheck == true)
            {
                instLoadPost();
            }
            else
            {

            }
                 
        }

        private void friendRequestTimer_Tick(object sender, EventArgs e)
        {
            friendRequestTimer.Stop();
            flowLayoutPanel2.Controls.Clear();
            friendRequest();
            
        }

//a function to show userprofile on post click
public static int user_id;
        public static bool profile = false;
        private void uname_Click(object sender, EventArgs e)
        {
            dashBoard.iCheck = false;
            dashBoard.emailCheck = false;
            var labl = sender as Label;
            user_id = int.Parse(labl.Name);
            profile = true;
            friendtb.profile = false;
            userInfo uInf = new userInfo();
            uInf.Show();
        }

        private void ProfilePhoto_Click(object sender, EventArgs e)
        {
            dashBoard.iCheck = false;
            dashBoard.emailCheck = false;
            var pc = sender as PictureBox;
            user_id = int.Parse(pc.Name);
            profile = true;
            friendtb.profile = false;
            userInfo uInf = new userInfo();
            uInf.Show();

        }

        private void postTimer_Tick(object sender, EventArgs e)
        {
            loadPost();
            postTimer.Stop();
        }
    }
}
