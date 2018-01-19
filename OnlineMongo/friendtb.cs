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
using Bunifu.Framework.UI;
using System.IO;

namespace OnlineMongo
{
    public partial class friendtb : UserControl
    {
        public static friendtb _instance;
        public static friendtb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new friendtb();
                return _instance;
            }

        }
        public friendtb()
        {
            InitializeComponent(); 
        }

        string myuserid;
        //function to read requests 

        private void fetchRequest()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            string readLoginAccount = "select * from users where username = '" + login.txt.Text + "'";

            //for login users 
            MySqlCommand com3 = new MySqlCommand(readLoginAccount, con);
            ad = new MySqlDataAdapter(com3);
            DataTable table2 = new DataTable();
            ad.Fill(table2);
            string loginUserID = table2.Rows[0][0].ToString();
            myuserid = loginUserID;
            ad.Dispose();

            //string to read userID from request table
            string checkReq = "select * from requests where user_id = '" + loginUserID + "'";
            con.Open();
            //for request user_id fetch
            MySqlCommand com1 = new MySqlCommand(checkReq, con);
            ad = new MySqlDataAdapter(com1);
            DataTable table = new DataTable();
            ad.Fill(table);

            //execute ones to check if the database is empty or not
            object nullValue = com1.ExecuteScalar();

            if (nullValue == null || nullValue == DBNull.Value)
            {
                //do nothing 
                reqNumberLabel.Text = "(0)";

            }
            else
            {
                reqNumberLabel.Text = "(" + table.Rows.Count + ")";
                for (int j = 0; j < table.Rows.Count; j++)
                {
                   
                    //User Full name
                    string fullname = table.Rows[j][4].ToString();
                    Label uname = new Label();
                    uname = new Label();
                    uname.Name = table.Rows[j][3].ToString();
                    uname.AutoSize = true;
                    uname.ForeColor = Color.DarkGreen;
                    uname.Font = new Font("Cambria", 12, FontStyle.Bold);
                    uname.Text = fullname;
                    uname.Cursor = Cursors.Hand;
                    uname.Click += new EventHandler(uname_Click);

                    //Confirm Button
                    BunifuFlatButton bt = new BunifuFlatButton();
                    bt.Name = table.Rows[j][0].ToString();
                    bt.Text = "Confirm";
                    bt.Height = 25;
                    bt.Width = 60;
                    bt.Normalcolor = Color.FromArgb(0, 122, 204);
                    bt.OnHovercolor = Color.FromArgb(32, 9, 191);
                    bt.Activecolor = Color.FromArgb(0, 122, 204);
                    bt.Iconimage = null;
                    bt.TextAlign = ContentAlignment.MiddleCenter;
                    bt.BorderRadius = 5;
                    bt.Click += new EventHandler(addFriendBtn_Click);
                   
                    //Cancel Button
                    BunifuFlatButton bt1 = new BunifuFlatButton();
                    bt1.Name = table.Rows[j][0].ToString();
                    bt1.Text = "Cancel";
                    bt1.Height = 25;
                    bt1.Width = 60;
                    bt1.Normalcolor = Color.FromArgb(0, 122, 204);
                    bt1.OnHovercolor = Color.FromArgb(32, 9, 191);
                    bt1.Activecolor = Color.FromArgb(0, 122, 204);
                    bt1.Iconimage = null;
                    bt1.TextAlign = ContentAlignment.MiddleCenter;
                    bt1.BorderRadius = 5;
                    bt1.Click += new EventHandler(CancelFriendBtn_Click);

                    //panel for username
                    FlowLayoutPanel unameP = new FlowLayoutPanel();
                    unameP.FlowDirection = FlowDirection.LeftToRight;
                    unameP.AutoSize = true;
                    unameP.Controls.Add(uname);

                    //panel for buttons
                    FlowLayoutPanel BtP = new FlowLayoutPanel();
                    BtP.FlowDirection = FlowDirection.LeftToRight;
                    BtP.AutoSize = true;
                    BtP.WrapContents = false;
                    BtP.Controls.Add(bt);
                    BtP.Controls.Add(bt1);


                    //adding user name to the panel
                    flowLayoutPanel1.Controls.Add(unameP);
                    
                    //adding confirm button to the panel
                    flowLayoutPanel1.Controls.Add(BtP);
                    
                }

                }
            ad.Dispose();
            con.Close();  
            }



        //a function for adding friends
        private string btnName;
        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            btnName = button.Name;
            addFriend();
            loadFriendTimer.Start();
            

        }

        //function to cancel request
       
        private void CancelFriendBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            btnName = button.Name;
            cancelReq();
        }
        public static int user_id;
        public static bool profile = false;
        //a function for lable click
        private void uname_Click(object sender, EventArgs e)
        {
            var button = sender as Label;
            user_id = int.Parse(button.Name);
            profile = true;
            postb.profile = false;
            userMenu usMn = new userMenu();
            usMn.Show();

        }

        private void photo_Click(object sender, EventArgs e)
        {
            var photo = sender as PictureBox;
            user_id = int.Parse(photo.Name);
            profile = true;
            postb.profile = false;
            userMenu usMn = new userMenu();
            usMn.Show();

        }

        private void friendtb_Load(object sender, EventArgs e)
        {
            friendRequestTimer.Start();
            loadFriendTimer.Start();
           
        }

        private void friendRequestTimer_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            friendRequestTimer.Stop();
            fetchRequest();
        }


        //function to add friend
        private void addFriend()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from requests where request_id = '"+ btnName + "'";
            string deleteReq = "delete from requests where request_id = '" + btnName + "'";
           
            MySqlCommand com = new MySqlCommand(detail, con);
            MySqlDataReader rd;

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                ad.Dispose();

                //checking if the user exist in the friend table
                string chek = "select * from friends where user_id = '" + table.Rows[0][3] + "' and myuserid = '" + myuserid + "'";
                MySqlCommand com3 = new MySqlCommand(chek, con);
                ad = new MySqlDataAdapter(com3);
                DataTable table1 = new DataTable();
                ad.Fill(table1);
                ad.Dispose();
                if (table1.Rows.Count > 0)
                {
                    MessageBox.Show("Sorry, This User is already added as a friend");

                }
                else
                {
                    //command to insert friend request
                    string addfriend = "insert into friends(user_id,username,myuserid) values('" + table.Rows[0][3] + "','" + table.Rows[0][4] + "','" + myuserid + "')";
                    MySqlCommand com1 = new MySqlCommand(addfriend, con);

                    //adding a friend in database
                    rd = com1.ExecuteReader();
                    rd.Close();

                    //command to remove the request from the database
                    MySqlCommand com2 = new MySqlCommand(deleteReq, con);

                    rd = com2.ExecuteReader();
                    rd.Close();

                    loadFriendTimer.Start();
                    friendRequestTimer.Start();
                    
                   

                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //afunction to cancel the request
        private void cancelReq()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from requests where request_id = '" + btnName + "'";
            string deleteReq = "delete from requests where request_id = '" + btnName + "'";
            MySqlCommand com = new MySqlCommand(detail, con);
            MySqlDataReader rd;

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                ad.Dispose();

                //command to remove the request from the database
                MySqlCommand com2 = new MySqlCommand(deleteReq, con);

                rd = com2.ExecuteReader();
                rd.Close();

                friendRequestTimer.Start();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //a function to load friends
        private void loadFrineds()
        {
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

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
                ad.Dispose();

                string detail = "SELECT * FROM friends,users where friends.user_id = users.user_id and friends.myuserid = '"+user_id+"'";
                MySqlCommand com1 = new MySqlCommand(detail, con);
                ad = new MySqlDataAdapter(com1);
                DataTable table = new DataTable();
                ad.Fill(table);

                //execute ones to check if the database is empty or not
                object nullValue = com1.ExecuteScalar();

                if (nullValue == null || nullValue == DBNull.Value)
                {
                    //do nothing 
                    friendNumberLabel.Text = "(0)";
                }
                else
                {
                    PictureBox[] phot = new PictureBox[table.Rows.Count];
                    friendNumberLabel.Text = "(" + table.Rows.Count + ")";
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        //User Full name
                        string fullname = table.Rows[i][2].ToString();
                        Label uname = new Label();
                        uname = new Label();
                        uname.Name = table.Rows[i][1].ToString();
                        uname.AutoSize = true;
                        uname.ForeColor = Color.DarkGreen;
                        uname.Font = new Font("Cambria", 16, FontStyle.Bold);
                        uname.Text = fullname;
                        uname.Cursor = Cursors.Hand;
                        uname.Click += new EventHandler(uname_Click);
                       

                        //Image
                        phot[i] = new PictureBox();
                        phot[i].Width = 100;
                        phot[i].Height = 65;
                        phot[i].Name = table.Rows[i][1].ToString();
                        phot[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        phot[i].Cursor = Cursors.Hand;
                        phot[i].Click += new EventHandler(photo_Click);
                        //takking photo to the panel
                        try
                        {
                            byte[] img = (byte[])table.Rows[i][11];
                            MemoryStream ms = new MemoryStream(img);
                            phot[i].Image = Image.FromStream(ms);


                        }
                        catch
                        {

                        }
                        //adding the profile pic to the panel
                         flowLayoutPanel2.Controls.Add(phot[i]);
                        //adding the name to the flowlayout
                        flowLayoutPanel2.Controls.Add(uname);
                      
                    }

                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
       
        private void loadFriendTimer_Tick(object sender, EventArgs e)
        {
            
                flowLayoutPanel2.Controls.Clear();
                loadFrineds();
            loadFriendTimer.Stop();
        }
    }

}
