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
using Bunifu.Framework.UI;

namespace OnlineMongo
{
    public partial class chatRoom : Form
    {
        public chatRoom()
        {
            InitializeComponent();
        }
        private static bool check = false;
        private void chatRoom_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            todayChats();
        }

       
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DateTime date;
        private string username;
        int changeUsernameColor1 = 0;
        int changeUsernameColor2 = 0;
        private void loadChats()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;

            //query to check if the chat is added at instant
            string chat = "SELECT * FROM chats order by chat_id DESC LIMIT 1";

            MySqlCommand com = new MySqlCommand(chat, con);
            ad = new MySqlDataAdapter(com);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
            for(int j =0; j < table1.Rows.Count; j++)
            {
                //Username
                Label uname = new Label();
                uname = new Label();
                uname.Name = table1.Rows[j][0].ToString();
                uname.AutoSize = true;
                if(changeUsernameColor1 == 0)
                {
                    uname.ForeColor = Color.Indigo;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 1)
                {
                    uname.ForeColor = Color.Green;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 2)
                {
                    uname.ForeColor = Color.Yellow;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 3)
                {
                    uname.ForeColor = Color.Aqua;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 4)
                {
                    uname.ForeColor = Color.Brown;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 5)
                {
                    uname.ForeColor = Color.FromArgb(30,0,40);
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 6)
                {
                    uname.ForeColor = Color.Chocolate;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 7)
                {
                    uname.ForeColor = Color.LightGreen;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 8)
                {
                    uname.ForeColor = Color.LightPink;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 9)
                {
                    uname.ForeColor = Color.LightYellow;
                    changeUsernameColor1++;
                }
                else if (changeUsernameColor1 == 10)
                {
                    uname.ForeColor = Color.Magenta;
                    changeUsernameColor1++;
                }
                else
                {
                    changeUsernameColor1 = 0;

                }
                uname.Font = new Font("Cambria", 12,FontStyle.Bold);
                uname.Text = username ;

                //chat message
                Label chatSms = new Label();
                chatSms.Name = table1.Rows[j][0].ToString();
                chatSms.AutoSize = true;
                chatSms.ForeColor = Color.LightGray;
                chatSms.Font = new Font("Cambria", 12);
                chatSms.Text = table1.Rows[j][2].ToString();

                //separater
                BunifuSeparator spr = new BunifuSeparator();
                spr.LineThickness = 2;
                spr.Height = 1;
                spr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                spr.LineColor = Color.DarkBlue;
                spr.Transparency = 30;

                //adding user name to the panel
           
                flowLayoutPanel1.Controls.Add(chatSms);
                flowLayoutPanel1.Controls.Add(uname);
                flowLayoutPanel1.Controls.Add(spr);

               

            }
            
        ad.Dispose();
    }

        //the function to load chats of todate
        private void todayChats()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            MySqlDataAdapter ad;
            date = DateTime.Today;
            //query to check if the post is added at instant
            string chat = "SELECT * FROM chats where date = '"+date.ToShortDateString()+"'";
           
            MySqlCommand com = new MySqlCommand(chat, con);
            DataTable table1 = new DataTable();
           
           
            try
            {
                con.Open();
                //taking the chat
                ad = new MySqlDataAdapter(com);
                ad.Fill(table1);
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                    //chat message
                    Label chatSms = new Label();
                    chatSms.Name = table1.Rows[j][0].ToString();
                    chatSms.AutoSize = true;
                    chatSms.ForeColor = Color.LightGray;
                    chatSms.Font = new Font("Cambria", 12);
                    chatSms.Text = table1.Rows[j][2].ToString();

                    //Username
                    Label uname = new Label();
                    uname = new Label();
                    uname.Name = table1.Rows[j][0].ToString();
                    uname.AutoSize = true;
                    if (changeUsernameColor2 == 0)
                    {
                        uname.ForeColor = Color.Indigo;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 1)
                    {
                        uname.ForeColor = Color.Green;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 2)
                    {
                        uname.ForeColor = Color.Yellow;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 3)
                    {
                        uname.ForeColor = Color.Aqua;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 4)
                    {
                        uname.ForeColor = Color.Brown;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 5)
                    {
                        uname.ForeColor = Color.FromArgb(30, 0, 40);
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 6)
                    {
                        uname.ForeColor = Color.Chocolate;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 7)
                    {
                        uname.ForeColor = Color.LightGreen;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 8)
                    {
                        uname.ForeColor = Color.LightPink;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 9)
                    {
                        uname.ForeColor = Color.LightYellow;
                        changeUsernameColor2++;
                    }
                    else if (changeUsernameColor2 == 10)
                    {
                        uname.ForeColor = Color.Magenta;
                        changeUsernameColor2++;
                    }
                    else
                    {
                        changeUsernameColor2 = 0;

                    }
                    uname.Font = new Font("Cambria", 12, FontStyle.Bold);
                    uname.Text = table1.Rows[j][4].ToString();

                    //separater
                    BunifuSeparator spr = new BunifuSeparator();
                    spr.LineThickness = 3;
                    spr.Height = 2;
                    spr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    spr.LineColor = Color.DarkBlue;
                    spr.Transparency = 30;

                    //adding user name to the panel
                    
                    flowLayoutPanel1.Controls.Add(chatSms);
                    flowLayoutPanel1.Controls.Add(uname);
                    flowLayoutPanel1.Controls.Add(spr);

                  

                }
                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(check == true)
            {
               loadChats();
                check = false;
            }
           else
            {

            }
                
             
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            if (e.KeyCode == Keys.Enter)
            {
                date = DateTime.Today;
               
                string takeUserName = "select * from users where user_id = '" + login.user_id + "'";
               
               
                MySqlCommand com1 = new MySqlCommand(takeUserName, con);
                MySqlDataReader rd;
                MySqlDataAdapter da;
                DataTable table = new DataTable();
                try
                {

                    con.Open();
                    da = new MySqlDataAdapter(com1);
                    da.Fill(table);
                    username = table.Rows[0][6].ToString();
                    string chat = "insert into chats(user_id,chat,date,uname) values ('" + login.user_id + "','" + richTextBox1.Text + "','" + date.ToShortDateString() + "','"+ table.Rows[0][6].ToString()+"')";
                    MySqlCommand com = new MySqlCommand(chat, con);
                    // inserting a chat reader;
                    rd = com.ExecuteReader();
                    rd.Close();

                   
                    richTextBox1.Text = null;
                    check = true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }

            }
        }
}
