﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineMongo
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        //for message noticification
        public static bool sound = false;
        //for item check
        public static bool iCheck = false;
        public static bool emailCheck = false;
       
        string currentComputerUserName = Environment.UserName;
        //a function to download the tone from the database


        static void createDirectory()
        {
            string rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UdoRead";
           try
            {
                if (!Directory.Exists(rootDirectory)) { Directory.CreateDirectory(rootDirectory); }
                if (!Directory.Exists(rootDirectory + "\\Sent emails")) { Directory.CreateDirectory(rootDirectory + "\\Sent emails"); }
                if (!Directory.Exists(rootDirectory + "\\Videos")) { Directory.CreateDirectory(rootDirectory + "\\Videos"); }
                if (!Directory.Exists(rootDirectory + "\\Lectures")) { Directory.CreateDirectory(rootDirectory + "\\Lectures"); }
                if (!Directory.Exists(rootDirectory + "\\Books")) { Directory.CreateDirectory(rootDirectory + "\\Books"); }
                if (!Directory.Exists(rootDirectory + "\\Profile Photo(s)")) { Directory.CreateDirectory(rootDirectory + "\\Profile Photo(s)"); }
                if (!Directory.Exists(rootDirectory + "\\Ring Tone")) { Directory.CreateDirectory(rootDirectory + "\\Ring Tone"); }
                if (!Directory.Exists(rootDirectory + "\\Item(s)")) { Directory.CreateDirectory(rootDirectory + "\\Item(s)"); }
                if (!Directory.Exists(rootDirectory + "\\Image")) { Directory.CreateDirectory(rootDirectory + "\\Image"); }
            }
            catch
            {

            }
               
           
        }
        private void dashBoard_Load_1(object sender, EventArgs e)
        {



            //reyrieve new emails
            emailCheckTimer.Start();
           
            
            check = true;
            iCheck = true;
          soundTimer.Start();
            //maximize the window
           maximize();
            emailNumberLabel.Visible = true;

            //creating Directory for the app Data.
            createDirectory();
            line.Visible = true;
            line.Width = home.Width;
            line.Left = home.Left;
            pic.Instance.Visible = false;
            postb.Instance.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            hometb.Instance.Visible = true;
            myProfile.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
           
            hometb.Instance.BringToFront();
            panel4.Controls.Add(hometb.Instance);
            hometb.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(hometb.Instance);
            panel2.Visible = true;
            panel2.Width = 50;
            panel4.Width = 1015;
            logo.Visible = false;
            mnBtn.Location = new Point(12, mnBtn.Location.Y);
            panelAnimator.ShowSync(panel2);
            hometb.Instance.Width = 1015;
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoTransition.ShowSync(logo);
        }

        //function to maximize the screen

            private void maximize()
        {
            this.WindowState = FormWindowState.Maximized;
            panel2.AutoScroll = false;
            panel4.Height = 600;
            restoreDownBtn.Visible = true;
            restoreDownBtn.BringToFront();
            maximizeBtn.Visible = false;
            closeBtn.Location = new Point(1320, closeBtn.Location.Y);
            miniMizeBtn.Location = new Point(1260, miniMizeBtn.Location.Y);
            maximizeBtn.Location = new Point(1290, maximizeBtn.Location.Y);
            restoreDownBtn.Location = new Point(1290, restoreDownBtn.Location.Y);
            signOutBtn.Location = new Point(1200, signOutBtn.Location.Y);
        }

        //function for restoring the screen to normal size
        private void restoreDown()
        {
            panel4.Height = 336;
            this.WindowState = FormWindowState.Normal;
            panel2.AutoScroll = true;
            maximizeBtn.Visible = true;
            restoreDownBtn.Visible = false;
            closeBtn.Location = new Point(1063, closeBtn.Location.Y);
            miniMizeBtn.Location = new Point(1003, miniMizeBtn.Location.Y);
            maximizeBtn.Location = new Point(1033, maximizeBtn.Location.Y);
            signOutBtn.Location = new Point(776, signOutBtn.Location.Y);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public static bool check = false;

        //afunction to show inbox new emails
        int k = 0;
        int numb;
        private void loadEmail()
        {
           
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
           
            try
            {

                con.Open();
                //reading all emails correspond to the user email
                string readMesage = "select status from sentmail where receiveremail = '" + login.user_email + "' order by sentmail_id desc";
                //for reading the message in the file
                MySqlCommand com = new MySqlCommand(readMesage, con);
                MySqlDataReader reader;
                
                DataTable table = new DataTable();

                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                int j = 0;
                

                
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //the email is new
                    if (table.Rows[i][0].ToString() == "New")
                    {
                       
                        j++;
                    }
                    else
                    {
                       
                    }

                }
                
                if (j != 0)
                {
                   

                    if (k == 0)
                    {
                        numb = j;

                    }
                    emailNumberLabel.Visible = true;
                    emailNumberLabel.Text = j.ToString();
                    if(numb < j)
                    {

                        sound = true;
                        inbonTab.check = true;
                        numb = j;
                    }
                    else
                    {
                        sound = false;
                        inbonTab.check = false;
                        numb = j;
                    }
                }
                else
                {
                    emailNumberLabel.Visible = false;
                    numb = j;
                }
                k++;

                if(k >= 4)
                {
                    k = 1;
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void checkItems()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

        }
       private int[] chek = new int[1];
        private void loadItems()
        {
           
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string load = "select status from sentitems where status = 'New' and receiver_email = '" + login.user_email + "'";
            MySqlCommand com = new MySqlCommand(load, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                //taking the items from the database
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                //checking if the new item exist
                if (table.Rows.Count > 0)
                {
                    onlinePic.Visible = true;

                    if(chek[0] < table.Rows.Count || chek[0] > table.Rows.Count)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.tone);
                        player.Play();
                        chek[0] = table.Rows.Count;
                    }
                    else
                    {

                    }
                }
                else
                {
                    onlinePic.Visible = false;
                }
                da.Dispose();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        //reading the new emails
        private void emailCheckTimer_Tick(object sender, EventArgs e)
        {
          
                loadEmail();
           
          
                  
        }


        //a timer for playing new  message sound
        private void soundTimer_Tick(object sender, EventArgs e)
        {
           
            if (sound == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.tone1);
                player.Play();
                sound = false;
            }
            else
            {

            }
        }

        private void itemTimer_Tick(object sender, EventArgs e)
        {
            //loading the items
            if(iCheck == true)
            {
                loadItems();
                iCheck = false;
            }
            {

            }
            
        }

        private void mnBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (panel2.Width == 50)
                {
                    // timer1.Start();
                    panel2.Visible = false;
                    panel2.Width = 250;
                    mnBtn.Location = new Point(222, mnBtn.Location.Y);
                    panelAnimator.ShowSync(panel2);
                    logo.Visible = true;
                    panel4.Width = 810;
                    pic.Instance.Width = 810;
                    myProfile.Instance.Width = 810;
                    hometb.Instance.Width = 810;
                    aboutb.Instance.Width = 810;
                    postb.Instance.Width = 810;
                    classPage.Instance.Width = 810;
                    friendtb.Instance.Width = 810;
                    hometb.Instance.Dock = DockStyle.Fill;
                    signOutBtn.Location = new Point(1000, signOutBtn.Location.Y);


                }
                else
                {
                    panel2.Visible = false;
                    panel2.Width = 50;
                    logo.Visible = false;
                    mnBtn.Location = new Point(12, mnBtn.Location.Y);
                    signOutBtn.Location = new Point(1200, signOutBtn.Location.Y);
                    panelAnimator.ShowSync(panel2);
                    panel4.Width = 1015;
                    pic.Instance.Width = 1015;
                    myProfile.Instance.Width = 1015;
                    hometb.Instance.Width = 1015;
                    aboutb.Instance.Width = 1015;
                    postb.Instance.Width = 1015;
                    classPage.Instance.Width = 1015;
                    friendtb.Instance.Width = 1015;



                }
            }
            else
            {

            }
        }


        private void home_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                line.Visible = true;
                line.Width = home.Width;
                line.Left = home.Left;
                pic.Instance.Visible = false;
                postb.Instance.Visible = false;
                aboutb.Instance.Visible = false;
                friendtb.Instance.Visible = false;
                classPage.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
                sentTab.Instance.Visible = false;
                hometb.Instance.Visible = true;
                hometb.Instance.BringToFront();
                panel4.Controls.Add(hometb.Instance);
                hometb.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(hometb.Instance);

                if (panel2.Width == 50)
                {
                    hometb.Instance.Width = 1015;
                    panel4.Controls.Add(hometb.Instance);
                    hometb.Instance.Dock = DockStyle.Fill;
                    hometb.Instance.Visible = true;
                   // tabAnimator.ShowSync(hometb.Instance);

                }

                else
                {
                    panel4.Controls.Add(hometb.Instance);
                    hometb.Instance.Dock = DockStyle.Fill;
                    hometb.Instance.Visible = true;
                   // tabAnimator.ShowSync(hometb.Instance);


                }
            }
            else
            {

            }
        }

        private void photos_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                line.Width = photos.Width;
                line.Left = photos.Left;
                line.Visible = true;
                classPage.Instance.Visible = false;
                aboutb.Instance.Visible = false;
                friendtb.Instance.Visible = false;
                postb.Instance.Visible = false;
                hometb.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
                sentTab.Instance.Visible = false;
                pic.Instance.Visible = true;
                pic.Instance.BringToFront();

                if (panel2.Width == 50)
                {

                    panel4.Controls.Add(pic.Instance);
                    pic.Instance.Dock = DockStyle.Fill;
                   
                   // picAnimation.ShowSync(pic.Instance);
                }
                else if (panel2.Width == 250)
                {
                    panel4.Controls.Add(pic.Instance);
                    pic.Instance.Dock = DockStyle.Fill;
                   // picAnimation.ShowSync(pic.Instance);
                }

                else
                {
                    panel4.Controls.Add(pic.Instance);
                    pic.Instance.Dock = DockStyle.Fill;
                    //picAnimation.ShowSync(pic.Instance);
                }

            }
            else
            {

            }
        }

        private void post_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                line.Width = post.Width;
                line.Left = post.Left;
                line.Visible = true;
                pic.Instance.Visible = false;
                classPage.Instance.Visible = false;
                aboutb.Instance.Visible = false;
                friendtb.Instance.Visible = false;
                hometb.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
                sentTab.Instance.Visible = false;
                postb.Instance.Visible = true;
                postb.Instance.BringToFront();
                panel4.Controls.Add(postb.Instance);
                postb.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(postb.Instance);

                if (panel2.Width == 50)
                {
                    postb.Instance.Width = 1015;
                    panel4.Controls.Add(postb.Instance);
                    postb.Instance.Dock = DockStyle.Fill;
                   // tabAnimator.ShowSync(postb.Instance);
                }

                else
                {
                    panel4.Controls.Add(postb.Instance);
                    postb.Instance.Dock = DockStyle.Fill;
                    //tabAnimator.ShowSync(postb.Instance);
                }

            }
            else
            {

            }
        }

        private void friends_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                line.Visible = true;
                line.Width = friends.Width;
                line.Left = friends.Left;
                pic.Instance.Visible = false;
                classPage.Instance.Visible = false;
                aboutb.Instance.Visible = false;
                postb.Instance.Visible = false;
                hometb.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
                sentTab.Instance.Visible = false;
                friendtb.Instance.Visible = true;
                friendtb.Instance.BringToFront();
                panel4.Controls.Add(friendtb.Instance);
                friendtb.Instance.Dock = DockStyle.Fill;
                //tabAnimator.ShowSync(friendtb.Instance);

                if (panel2.Width == 50)
                {
                    friendtb.Instance.Width = 1015;
                    panel4.Controls.Add(friendtb.Instance);
                    friendtb.Instance.Dock = DockStyle.Fill;
                   // tabAnimator.ShowSync(friendtb.Instance);
                }

                else
                {
                    panel4.Controls.Add(friendtb.Instance);
                    friendtb.Instance.Dock = DockStyle.Fill;
                   // tabAnimator.ShowSync(friendtb.Instance);
                }
            }
            else
            {

            }
        }

        private void about_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                line.Visible = true;
                line.Width = about.Width;
                line.Left = about.Left;
                pic.Instance.Visible = false;
                postb.Instance.Visible = false;
                classPage.Instance.Visible = false;
                friendtb.Instance.Visible = false;
                hometb.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
                sentTab.Instance.Visible = false;
                aboutb.Instance.Visible = true;
                aboutb.Instance.BringToFront();
                panel4.Controls.Add(aboutb.Instance);
                aboutb.Instance.Dock = DockStyle.Fill;
                //tabAnimator.ShowSync(aboutb.Instance);

                if (panel2.Width == 50)
                {

                    panel4.Controls.Add(aboutb.Instance);
                    aboutb.Instance.Dock = DockStyle.Fill;
                    //tabAnimator.ShowSync(aboutb.Instance);
                }

                else
                {
                    panel4.Controls.Add(aboutb.Instance);
                    aboutb.Instance.Dock = DockStyle.Fill;
                    //tabAnimator.ShowSync(aboutb.Instance);

                }
            }
            else
            {

            }
        }

        private void signOutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Application.Restart();
            }
            else
            {

            }
        }

        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
                //pinWindow pinwd = new pinWindow();
                //pinwd.Show();
                //pinwd.WindowState = FormWindowState.Minimized;
            }
            else
            {

            }
        }

        private void restoreDownBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                restoreDown();
            }
            else
            {

            }
        }

        private void maximizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                maximize();
            }
            else
            {

            }
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();

                }
            }
            else
            {

            }
        }

        private void myProfileBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            myProfile.Instance.Visible = true;
            myProfile.Instance.BringToFront();
            panel4.Controls.Add(myProfile.Instance);
            myProfile.Instance.Dock = DockStyle.Fill;
           // picAnimation.ShowSync(myProfile.Instance);

            if (panel2.Width == 50)
            {
                myProfile.Instance.Width = 1015;
                panel4.Controls.Add(myProfile.Instance);
                myProfile.Instance.Dock = DockStyle.Fill;
                //picAnimation.ShowSync(myProfile.Instance);

            }

            else
            {
                panel4.Controls.Add(myProfile.Instance);
                myProfile.Instance.Dock = DockStyle.Fill;
               // picAnimation.ShowSync(myProfile.Instance);

            }
        }

        private void myClassBtn_Click(object sender, EventArgs e)
        {
            iCheck = true;

            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            classPage.Instance.Visible = true;
            classPage.Instance.BringToFront();
            panel4.Controls.Add(classPage.Instance);
            classPage.Instance.Dock = DockStyle.Fill;
           // picAnimation.ShowSync(classPage.Instance);

            if (panel2.Width == 50)
            {
                classPage.Instance.Width = 1015;
                panel4.Controls.Add(classPage.Instance);
                classPage.Instance.Dock = DockStyle.Fill;
               // picAnimation.ShowSync(classPage.Instance);

            }

            else
            {
                panel4.Controls.Add(classPage.Instance);
                classPage.Instance.Dock = DockStyle.Fill;
               // picAnimation.ShowSync(classPage.Instance);
            }
        }

        private void composeBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            composeMsg.Instance.Visible = true;
            composeMsg.Instance.BringToFront();
            panel4.Controls.Add(composeMsg.Instance);
            composeMsg.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(composeMsg.Instance);

            if (panel2.Width == 50)
            {
                composeMsg.Instance.Width = 1015;
                panel4.Controls.Add(composeMsg.Instance);
                composeMsg.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(composeMsg.Instance);

            }

            else
            {
                panel4.Controls.Add(composeMsg.Instance);
                composeMsg.Instance.Dock = DockStyle.Fill;
              //  tabAnimator.ShowSync(composeMsg.Instance);

            }
        }

        private void inboxBtn_Click(object sender, EventArgs e)
        {
            inbonTab.check = true;
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            inbonTab.Instance.Visible = true;
            inbonTab.Instance.BringToFront();
            panel4.Controls.Add(inbonTab.Instance);
            inbonTab.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(inbonTab.Instance);

            if (panel2.Width == 50)
            {
                inbonTab.Instance.Width = 1015;
                panel4.Controls.Add(inbonTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(inbonTab.Instance);

            }

            else
            {
                panel4.Controls.Add(inbonTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
              //  tabAnimator.ShowSync(inbonTab.Instance);

            }
        }

        private void sentBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = true;
            sentTab.Instance.BringToFront();
            panel4.Controls.Add(sentTab.Instance);
            sentTab.Instance.Dock = DockStyle.Fill;
            //tabAnimator.ShowSync(sentTab.Instance);

            if (panel2.Width == 50)
            {
                sentTab.Instance.Width = 1015;
                panel4.Controls.Add(sentTab.Instance);
                sentTab.Instance.Dock = DockStyle.Fill;
              //  tabAnimator.ShowSync(sentTab.Instance);

            }

            else
            {
                panel4.Controls.Add(sentTab.Instance);
                sentTab.Instance.Dock = DockStyle.Fill;
              //  tabAnimator.ShowSync(sentTab.Instance);

            }
        }

        private void draftBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            draftTab.Instance.Visible = true;
            draftTab.Instance.BringToFront();
            panel4.Controls.Add(draftTab.Instance);
            draftTab.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(draftTab.Instance);

            if (panel2.Width == 50)
            {
                draftTab.Instance.Width = 1015;
                panel4.Controls.Add(draftTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(draftTab.Instance);

            }

            else
            {
                panel4.Controls.Add(draftTab.Instance);
                draftTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(draftTab.Instance);

            }
        }

        private void trashBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            trashTab.Instance.Visible = true;
            trashTab.Instance.BringToFront();
            panel4.Controls.Add(trashTab.Instance);
            trashTab.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(trashTab.Instance);

            if (panel2.Width == 50)
            {
                trashTab.Instance.Width = 1015;
                panel4.Controls.Add(trashTab.Instance);
                trashTab.Instance.Dock = DockStyle.Fill;
              //  tabAnimator.ShowSync(trashTab.Instance);

            }

            else
            {
                panel4.Controls.Add(trashTab.Instance);
                trashTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(trashTab.Instance);

            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            iCheck = true;

            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            settingTab.Instance.Visible = true;
            settingTab.Instance.BringToFront();
            panel4.Controls.Add(settingTab.Instance);
            settingTab.Instance.Dock = DockStyle.Fill;
           // tabAnimator.ShowSync(settingTab.Instance);

            if (panel2.Width == 50)
            {
                settingTab.Instance.Width = 1015;
                panel4.Controls.Add(settingTab.Instance);
                settingTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(settingTab.Instance);

            }

            else
            {
                panel4.Controls.Add(settingTab.Instance);
                settingTab.Instance.Dock = DockStyle.Fill;
               // tabAnimator.ShowSync(settingTab.Instance);

            }

        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            chatRoom cht = new chatRoom();
            cht.Show();
        }

        private void itemBtn_Click(object sender, EventArgs e)
        {
            items item = new items();
            item.Show();
        }

        private void chooseQn_Click(object sender, EventArgs e)
        {
            secretWord sc = new secretWord();
            sc.Show();
        }
    }
}
