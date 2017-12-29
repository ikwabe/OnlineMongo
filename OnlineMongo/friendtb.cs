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

       
    
        //function to read requests 

        private void fetchRequest()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            MySqlDataAdapter ad;

            string readLoginAccount = "select * from users where username = '" + login.txt.Text + "'";

            //for login users 
            MySqlCommand com3 = new MySqlCommand(readLoginAccount, con);
            ad = new MySqlDataAdapter(com3);
            DataTable table2 = new DataTable();
            ad.Fill(table2);
            string loginUserID = table2.Rows[0][0].ToString();
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

            }
            else
            {
                for (int j = 0; j < table.Rows.Count; j++)
                {
                   
                    //User Full name
                    string fullname = table.Rows[j][4].ToString();
                    Label uname = new Label();
                    uname = new Label();
                    uname.Name = table.Rows[j][3].ToString();
                    uname.AutoSize = true;
                    uname.ForeColor = Color.DarkGreen;
                    uname.Font = new Font("Cambria", 11, FontStyle.Bold);
                    uname.Text = fullname;
                    uname.Cursor = Cursors.Hand;
                    uname.Click += new EventHandler(uname_Click);

                    //Confirm Button
                    BunifuFlatButton bt = new BunifuFlatButton();
                    bt.Name = table.Rows[j][0].ToString();
                    bt.Text = "Confirm";
                    bt.Height = 20;
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
                    bt1.Height = 20;
                    bt1.Width = 60;
                    bt1.Normalcolor = Color.FromArgb(0, 122, 204);
                    bt1.OnHovercolor = Color.FromArgb(32, 9, 191);
                    bt1.Activecolor = Color.FromArgb(0, 122, 204);
                    bt1.Iconimage = null;
                    bt1.TextAlign = ContentAlignment.MiddleCenter;
                    bt1.BorderRadius = 5;
                    bt1.Click += new EventHandler(CancelFriendBtn_Click);
                    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                   
                    //adding user name to the panel
                    flowLayoutPanel1.Controls.Add(uname);
                    
                    //adding confirm button to the panel
                    flowLayoutPanel1.Controls.Add(bt);
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                    //adding cancel button to the panel
                    flowLayoutPanel1.Controls.Add(bt1);

                    



                }

                }
            ad.Dispose();
            con.Close();  
            }



        //a function for adding friends

        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MessageBox.Show(button.Name);

        }

        //function to cancel request
        private void CancelFriendBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MessageBox.Show(button.Name);

        }
        public static int user_id;

        //a function for lable click
        private void uname_Click(object sender, EventArgs e)
        {
            var button = sender as Label;
            user_id = int.Parse(button.Name);

            userInfo uInf = new userInfo();
            uInf.Show();

        }

        private void friendtb_Load(object sender, EventArgs e)
        {
            friendRequestTimer.Start();
        }

        private void friendRequestTimer_Tick(object sender, EventArgs e)
        {
            friendRequestTimer.Stop();
            fetchRequest();
        }
    }

}
